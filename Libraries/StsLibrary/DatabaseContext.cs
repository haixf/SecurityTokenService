using SecurityTokenService.Helpers;
using Microsoft.EntityFrameworkCore;
using SecurityTokenService.Models;

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
        public DbSet<ClientScope> ClientScopes { get; set; }
        public DbSet<ClientUri> ClientUris { get; set; }
        public DbSet<ClientClaim> ClientClaims { get; set; }
        public DbSet<ClientSecret> ClientSecrets { get; set; }

        /// <summary>
        /// Retrieve the default database connection from the appsettings file
        /// </summary>
        /// <returns></returns>
        public static DbContextOptions GetOptions()
        {
            return new DbContextOptionsBuilder<DatabaseContext>().UseSqlServer(ConfigurationHelper.Instance.ConnectionString).Options;
        }

        public static DbContextOptions GetInMemoryOptions(int unitTestSeed)
        {
            return new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(unitTestSeed.ToString()).Options;
        }
    }
}
