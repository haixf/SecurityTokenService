using SecurityTokenService;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibrary
{
    public static class DatabaseHelper
    {
        public static void AddEntryIntoDatabase<T>(DatabaseContext databaseContext, T item)
        {
            databaseContext.Add(item);
            databaseContext.SaveChanges();
        }
    }
}
