using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    [Table("Client",Schema = "sts")]
    public class Client
    {
        [Key]
        public Guid Key { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool EnableLocalLogin { get; set; }
        public bool AllowOfflineAcccess { get; set; }
        public int AccessTokenLifetime { get; set; }
        public int IdentityTokenLifetime { get; set; }
        public int AuthorizationCodeLifetime { get; set; }
        public int SlidingTokenLifetime { get; set; }

        public List<ClientSecret> ClientSecrets { get; set; }
        public List<ClientScope> AllowedScopes { get; set; }
        public List<ClientUri> ClientUris { get; set; }

        public IdentityServer4.Models.Client ConvertToIdsModel(DatabaseContext context)
        {
            var secrets = new List<IdentityServer4.Models.Secret>();
            foreach(var secret in ClientSecrets)
            {
                secrets.Add(secret.ConvertToIdsModel());
            }

            var scopes = new List<string>();
            foreach (var allowedScope in AllowedScopes)
            {
                scopes.Add(context.Scopes.Select(x => x.Name).Where(x => x.Equals(allowedScope)).FirstOrDefault());
            }

            var redirectUris = new List<string>();
            var postLogoutUris = new List<string>();

            foreach (var uri in ClientUris)
            {
                if(uri.Type == ClientUri.UriTypes.REDIRECT)
                {
                    redirectUris.Add(uri.Uri);
                }else if(uri.Type == ClientUri.UriTypes.POST)
                {
                    postLogoutUris.Add(uri.Uri);
                }
            }



            return new IdentityServer4.Models.Client
            {
                ClientId = this.ClientId,
                ClientName = this.ClientName,
                Description = this.Description,
                Enabled = this.Enabled,
                EnableLocalLogin = this.EnableLocalLogin,
                AllowOfflineAccess = this.AllowOfflineAcccess,
                AccessTokenLifetime = this.AccessTokenLifetime,
                IdentityTokenLifetime = this.IdentityTokenLifetime,
                AuthorizationCodeLifetime = this.AuthorizationCodeLifetime,
                SlidingRefreshTokenLifetime = this.SlidingTokenLifetime,
                ClientSecrets = secrets,
                AllowedScopes = scopes,
                RedirectUris = redirectUris,
                PostLogoutRedirectUris = postLogoutUris
            };
        }
    }
}
