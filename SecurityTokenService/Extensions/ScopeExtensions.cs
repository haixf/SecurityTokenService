using SecurityTokenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Extensions
{
    public static class ScopeExtensions
    {
        public static IdentityServer4.Models.Scope ConvertToIdsModel(this Scope scope)
        {
            return new IdentityServer4.Models.Scope
            {
                Name = scope.Name,
                Description = scope.Description,
                DisplayName = scope.DisplayName,
                Required = scope.Required,
                Emphasize = scope.Emphasize,
                ShowInDiscoveryDocument = scope.ShowInDiscoveryDocument
            };
        }
    }
}
