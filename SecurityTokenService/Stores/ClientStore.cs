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
    public class ClientStore : IClientStore
    {
        private DbContextOptions options;

        public ClientStore()
        {
            this.options = DatabaseContext.GetOptions();
        }

        public ClientStore(DbContextOptions options)
        {
            this.options = options;
        }

        public Task<Client> FindClientByIdAsync(string clientId)
        {
            using (var context = new DatabaseContext(options))
            {
                var client = context.Clients.Where(x => x.ClientId == clientId).FirstOrDefault();
                GetAllClientInformation(client, context);
                return Task.FromResult(client.ConvertToIdsModel(context));
            }
        }

        private static void GetAllClientInformation(Models.Client client, DatabaseContext databaseContext)
        {
            if(client == null)
            {
                return;
            }
            client.ClientUris = databaseContext.ClientUris.Where(x => x.ClientKey == client.Key).ToList();
            client.ClientSecrets = databaseContext.ClientSecrets.Where(x => x.ClientKey == client.Key).ToList();
            client.AllowedScopes = databaseContext.ClientScopes.Where(x => x.ClientKey == client.Key).ToList();
        }
    }
}
