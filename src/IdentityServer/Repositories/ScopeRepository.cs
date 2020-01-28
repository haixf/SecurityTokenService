﻿using IdentityServer4.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SecurityTokenService.Repositories
{
    public class ScopeRepository : BaseRepository
    {
        public Scope GetScopeByName(string name)
        {
            return context.Scopes.Where(x => x.Name == name).FirstOrDefault().ConvertToIdsModel();
        }
    }
}
