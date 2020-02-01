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
        public static bool isUnitTesting = false;
        public static int unitTestSeed = 1;

        public DatabaseContext() : base(GetOptions())
        {

        }

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


        public static void SetUnitTestSeed(int seed)
        {
            unitTestSeed = seed;
        }
        /// <summary>
        /// Retrieve the default database connection from the appsettings file
        /// </summary>
        /// <returns></returns>
        public static DbContextOptions GetOptions()
        {
            if (isUnitTesting)
            {
                return new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(unitTestSeed.ToString()).Options;
            }
            return new DbContextOptionsBuilder<DatabaseContext>().UseSqlServer(ConfigurationHelper.Instance.ConnectionString).Options;
        }
    }
}
