using SecurityTokenService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibrary
{
    public static class Models
    {

        public static Client Client
        {
            get
            {
                return new Client
                {
                    ClientName = "UnitTest",
                    AccessTokenLifetime = 100,
                    AllowOfflineAcccess = true,
                    ClientId = "UnitTest",
                    Description = "Client for unit testing",
                    Enabled = true,
                    SlidingTokenLifetime = 100,
                    AuthorizationCodeLifetime = 100,
                    IdentityTokenLifetime = 100,
                    EnableLocalLogin = true,
                    Key = Guid.NewGuid(),
                    AllowedScopes = new List<ClientScope>(),
                    ClientSecrets = new List<ClientSecret>(),
                    ClientUris = new List<ClientUri>()
                };
            }
        }
    }
}
