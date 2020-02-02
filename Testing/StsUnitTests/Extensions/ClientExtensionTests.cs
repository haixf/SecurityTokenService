using Microsoft.EntityFrameworkCore;
using SecurityTokenService;
using SecurityTokenService.Extensions;
using SecurityTokenService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using TestLibrary;
using Xunit;

namespace StsUnitTests.Extensions
{
    public class ClientExtensionTests
    {
        private DatabaseContext context;
        public ClientExtensionTests()
        {

            context = new DatabaseContext(TestHelper.PrepDbContextForUnitTesting());
        }

        [Fact]
        public void ConvertToIdsModel_Null()
        {
            Client client = null;

            Assert.Null(client.ConvertToIdsModel(context));
        }

        [Fact]
        public void ConvertToIdsModel_Success()
        {
            Client client = MockModels.Client;
            Assert.NotNull(client.ConvertToIdsModel(context));
        }
    }
}
