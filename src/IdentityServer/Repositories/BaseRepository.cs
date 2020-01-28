using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Repositories
{
    public abstract class BaseRepository
    {
        protected DatabaseContext context;

        public BaseRepository()
        {
            context = new DatabaseContext(DatabaseContext.GetOptions());
        }
        public BaseRepository(DbContextOptions options)
        {
            context = new DatabaseContext(options);
        }
    }
}
