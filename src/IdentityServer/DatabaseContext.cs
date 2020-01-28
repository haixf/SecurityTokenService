using SecurityTokenService.Helpers;
using SecurityTokenService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService
{
    /// <summary>
    /// Class that allows access to the database. Also contains list of all DBSets
    /// </summary>
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Scope> Scopes { get; set; }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<Client> Clients { get; set; }



        /// <summary>
        /// Retrieve the default database connection from the appsettings file
        /// </summary>
        /// <returns></returns>
        public static DbContextOptions GetOptions()
        {
            return new DbContextOptionsBuilder<DatabaseContext>().UseSqlServer(ConfigurationHelper.Instance.ConnectionString).Options;
        }
    }
}
