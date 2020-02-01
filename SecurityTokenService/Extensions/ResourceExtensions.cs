using SecurityTokenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Extensions
{
    public static class ResourceExtensions
    {
        public static IdentityServer4.Models.ApiResource ConvertToApiModel(this Resource resource)
        {
            return new IdentityServer4.Models.ApiResource
            {
                Name = resource.Name,
                Description = resource.Description,
                Enabled = resource.Enabled,
                DisplayName = resource.DisplayName,
            };
        }

        public static IdentityServer4.Models.IdentityResource ConvertToIdentityModel(this Resource resource)
        {
            return new IdentityServer4.Models.IdentityResource
            {
                Name = resource.Name,
                Description = resource.Description,
                Enabled = resource.Enabled,
                DisplayName = resource.DisplayName,
                ShowInDiscoveryDocument = true,
                Emphasize = true,
                Required = false
            };
        }
    }
}
