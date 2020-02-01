using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Helpers
{
    /// <summary>
    /// Single instance class that grabs configurations from the appsettings file
    /// </summary>
    public sealed class ConfigurationHelper
    {
        private static readonly ConfigurationHelper instance = new ConfigurationHelper();
        private IConfiguration configurations;

        private ConfigurationHelper()
        {
            configurations = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        }

        public static ConfigurationHelper Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Retrieve the connection string that is set in the appsettings.json.
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return configurations.GetConnectionString(StsConstants.AppSettings.ConnectionStringName);
            }
        }
    }
}
