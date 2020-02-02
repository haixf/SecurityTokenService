using SecurityTokenService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibrary
{
    public static class MockModels
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

        public static Resource ApiResource
        {
            get
            {
                return new Resource
                {
                    ResourceType = ResourceTableModel.ResourceTypes.API,
                    Name = "UnitTest_ApiResource",
                    Description = "Unit test for api resource",
                    DisplayName = "UnitTest_ApiResource",
                    Enabled = true,
                    Emphasize = true,
                    Required = true,
                    ShowInDiscoveryDocument = true,
                    Key = Guid.NewGuid(),
                    Scopes = new List<Scope>()
                };
            }
        }

        public static Resource IdentityResource
        {
            get
            {
                return new Resource
                {
                    ResourceType = ResourceTableModel.ResourceTypes.IDENTITY,
                    Name = "UnitTest_IdentityResource",
                    Description = "Unit test for identity resource",
                    DisplayName = "UnitTest_IdentityResource",
                    Enabled = true,
                    Emphasize = true,
                    Required = true,
                    ShowInDiscoveryDocument = true,
                    Key = Guid.NewGuid(),
                    Scopes = new List<Scope>()
                };
            }
        }

        public static Scope Scope
        {
            get
            {
                return new Scope
                {
                    Key = Guid.NewGuid(),
                    Name = "UnitTestScope",
                    DisplayName = "UnitTestScope",
                    Description = "Scope for Unit Testing",
                    Emphasize = true,
                    Required = true,
                    ShowInDiscoveryDocument = true
                };
            }
        }
    }
}
