using SecurityTokenService.Stores;
using SecurityTokenService;
using TestLibrary;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace StsUnitTests.Stores
{
    public class ClientStoreTests
    {
        private DbContextOptions options;
        private ClientStore store;

        public ClientStoreTests()
        {
            options = TestHelper.PrepDbContextForUnitTesting();

            store = new ClientStore(options);
        }

        [Fact]
        public void FindClientByIdAsync_ClientExists()
        {
            DatabaseHelper.AddEntryIntoDatabase(options, MockModels.Client);
            
            Assert.NotNull(store.FindClientByIdAsync(MockModels.Client.ClientName).Result);
        }

        [Fact]
        public void FindClientByIdAsync_ClientNotExist()
        {
            Assert.Null(store.FindClientByIdAsync(MockModels.Client.ClientName).Result);
        }
    }
}
