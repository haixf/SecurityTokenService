using SecurityTokenService;
using System;

namespace TestLibrary
{
    
    public static class TestHelper
    {
        private static Random rn = new Random();

        public static int GenerateRandomNumber()
        {
            return rn.Next();
        }

        /// <summary>
        /// Set DatabaseContext to unit test and generates a randomly seeded database
        /// </summary>
        /// <returns></returns>
        public static DatabaseContext PrepDbContextForUnitTesting()
        {
            DatabaseContext.isUnitTesting = true;
            DatabaseContext.SetUnitTestSeed(TestHelper.GenerateRandomNumber());

            return new DatabaseContext();
        }
    }
}
