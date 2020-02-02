using Microsoft.EntityFrameworkCore;
using SecurityTokenService;
using SecurityTokenService.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using TestLibrary;
using Xunit;

namespace StsUnitTests.Stores
{
    public class ResourceStoreTests
    {
        private DbContextOptions options;
        private ResourceStore store;

        public ResourceStoreTests()
        {
            options = TestHelper.PrepDbContextForUnitTesting();
            store = new ResourceStore(options);
        }

        [Fact]
        public void FindApiResourceAsync_Null_NotExist()
        {
            Assert.Null(store.FindApiResourceAsync("DoesNotExist").Result);
        }

        [Fact]
        public void FindApiResourceAsync_Success()
        {
            var resourceModel = MockModels.ApiResource;
            DatabaseHelper.AddEntryIntoDatabase(options, resourceModel);

            Assert.NotNull(store.FindApiResourceAsync(resourceModel.Name).Result);
        }

        [Fact]
        public void FindApiResourcesByScopeAsync_Success()
        {
            var resourceModel = MockModels.ApiResource;
            var scopeModel = MockModels.Scope;

            scopeModel.ResourceKey = resourceModel.Key;
            resourceModel.Scopes.Add(scopeModel);

            DatabaseHelper.AddEntryIntoDatabase(options, resourceModel);
            Assert.NotNull(store.FindApiResourcesByScopeAsync(new List<string>() {scopeModel.Name }).Result);
        }

        [Fact]
        public void GetAllResourcesAsync_Success()
        {
            var resourceApiModel = MockModels.ApiResource;
            var resourceIdentityModel = MockModels.IdentityResource;

            DatabaseHelper.AddEntryIntoDatabase(options, resourceApiModel);
            DatabaseHelper.AddEntryIntoDatabase(options, resourceIdentityModel);

            var response = store.GetAllResourcesAsync().Result;
            Assert.Single(response.ApiResources);
            Assert.Single(response.IdentityResources);
        }
    }
}
