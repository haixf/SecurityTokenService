using SecurityTokenService.Stores;
using SecurityTokenService;
using TestLibrary;
using Xunit;

namespace StsUnitTests
{
    public class ClientStoreTests
    {
        private DatabaseContext context;
        private ClientStore store;

        public ClientStoreTests()
        {
            context = TestHelper.PrepDbContextForUnitTesting();
            store = new ClientStore();
        }

        [Fact]
        public void FindClientByIdAsync_ClientExists()
        {
            DatabaseHelper.AddEntryIntoDatabase(context, Models.Client);
            
            Assert.NotNull(store.FindClientByIdAsync(Models.Client.ClientName).Result);
        }

        [Fact]
        public void FindClientByIdAsync_ClientNotExist()
        {
            Assert.Null(store.FindClientByIdAsync(Models.Client.ClientName).Result);
        }
    }
}
