using SecurityTokenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Extensions
{
    public static class ClientExtensions
    {
        public static IdentityServer4.Models.Client ConvertToIdsModel(this Client client, DatabaseContext context)
        {
            if(client == null)
            {
                return null;
            }
            var secrets = new List<IdentityServer4.Models.Secret>();
            foreach (var secret in client.ClientSecrets)
            {
                secrets.Add(secret.ConvertToIdsModel());
            }

            var scopes = new List<string>();
            foreach (var allowedScope in client.AllowedScopes)
            {
                scopes.Add(context.Scopes.Select(x => x.Name).Where(x => x.Equals(allowedScope)).FirstOrDefault());
            }

            var redirectUris = new List<string>();
            var postLogoutUris = new List<string>();

            foreach (var uri in client.ClientUris)
            {
                if (uri.Type == ClientUri.UriTypes.REDIRECT)
                {
                    redirectUris.Add(uri.Uri);
                }
                else if (uri.Type == ClientUri.UriTypes.POST)
                {
                    postLogoutUris.Add(uri.Uri);
                }
            }

            return new IdentityServer4.Models.Client
            {
                ClientId = client.ClientId,
                ClientName = client.ClientName,
                Description = client.Description,
                Enabled = client.Enabled,
                EnableLocalLogin = client.EnableLocalLogin,
                AllowOfflineAccess = client.AllowOfflineAcccess,
                AccessTokenLifetime = client.AccessTokenLifetime,
                IdentityTokenLifetime = client.IdentityTokenLifetime,
                AuthorizationCodeLifetime = client.AuthorizationCodeLifetime,
                SlidingRefreshTokenLifetime = client.SlidingTokenLifetime,
                ClientSecrets = secrets,
                AllowedScopes = scopes,
                RedirectUris = redirectUris,
                PostLogoutRedirectUris = postLogoutUris
            };
        }
    }
}
