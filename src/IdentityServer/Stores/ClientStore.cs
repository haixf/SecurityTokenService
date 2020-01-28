using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Stores
{
    public class ClientStore : IClientStore
    {
        private DatabaseContext context;

        public ClientStore()
        {
            context = new DatabaseContext(DatabaseContext.GetOptions());
        }

        public ClientStore(DbContextOptions options)
        {
            context = new DatabaseContext(options);
        }

        public Task<Client> FindClientByIdAsync(string clientId)
        {
            return Task.FromResult(context.Clients.Where(x => x.ClientId == clientId).FirstOrDefault().ConvertToIdsModel(context));
        }
    }
}
