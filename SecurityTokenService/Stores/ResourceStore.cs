using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.EntityFrameworkCore;
using SecurityTokenService.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Stores
{
    public class ResourceStore : IResourceStore
    {


        public Task<ApiResource> FindApiResourceAsync(string name)
        {
            using (var context = new DatabaseContext())
            {
                return Task.FromResult(context.Resources.Where(x => x.ResourceType == Models.ResourceTableModel.ResourceTypes.API && x.Name == name).FirstOrDefault().ConvertToApiModel());
            }
        }

        public Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            using (var context = new DatabaseContext())
            {
                var apiResources = new List<ApiResource>();
                foreach (var resource in context.Resources.Where(x => x.ResourceType == Models.ResourceTableModel.ResourceTypes.API))
                {
                    GetAllResourceInformation(resource, context);
                    if (resource.Scopes.Select(x => x.Name).Intersect(scopeNames).Any())
                    {
                        apiResources.Add(resource.ConvertToApiModel());
                    }
                }

                return Task.FromResult(apiResources.AsEnumerable());
            }
        }

        public Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            using (var context = new DatabaseContext())
            {
                return Task.FromResult(context.Resources.Select(x => x.ConvertToIdentityModel()).AsEnumerable());
            }
        }

        public Task<Resources> GetAllResourcesAsync()
        {
            using (var context = new DatabaseContext())
            {
                var apiResources = context.Resources.Where(x => x.ResourceType == Models.ResourceTableModel.ResourceTypes.API)
                                                .Select(x => x.ConvertToApiModel())
                                                .AsEnumerable();

                var identityResources = context.Resources.Where(x => x.ResourceType == Models.ResourceTableModel.ResourceTypes.IDENTITY)
                                                         .Select(x => x.ConvertToIdentityModel())
                                                         .AsEnumerable();

                return Task.FromResult(new Resources(identityResources, apiResources));
            }
        }

        private static void GetAllResourceInformation(Models.Resource resource, DatabaseContext databaseContext)
        {
            resource.Scopes = databaseContext.Scopes.Where(x => x.ResourceKey == resource.Key).ToList();
        }

    }
}
