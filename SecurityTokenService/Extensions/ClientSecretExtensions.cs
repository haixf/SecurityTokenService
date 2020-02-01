using SecurityTokenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Extensions
{
    public static class ClientSecretExtensions
    {
        public static IdentityServer4.Models.Secret ConvertToIdsModel(this ClientSecret secret)
        {
            return new IdentityServer4.Models.Secret
            {
                Description = secret.Description,
                Expiration = secret.Expiration.Value.DateTime,
                Type = secret.Type,
                Value = secret.Value
            };
        }
    }
}
