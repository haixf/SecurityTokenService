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
        public Task<Client> FindClientByIdAsync(string clientId)
        {
            using (var context = new DatabaseContext())
            {
                var client = context.Clients.Where(x => x.ClientId == clientId).FirstOrDefault();
                
                return Task.FromResult(GetAllClientInformation(client, context).ConvertToIdsModel(context));
            }
        }

        private static Models.Client GetAllClientInformation(Models.Client client, DatabaseContext databaseContext)
        {
            client.ClientUris = databaseContext.ClientUris.Where(x => x.ClientKey == client.Key).ToList();
            client.ClientSecrets = databaseContext.ClientSecrets.Where(x => x.ClientKey == client.Key).ToList();
            client.AllowedScopes = databaseContext.ClientScopes.Where(x => x.ClientKey == client.Key).ToList();

            return client;
        }
    }
}
