using AzureDevHelper.StorageAccount.Helpers;
using System;

namespace AzureConnectionStringHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionStringHelper connectionString = new ConnectionStringHelper();

            string strConnectionStringFromConfigFile = connectionString.GetConnectionStringFromConfigFile("StorageConnectionString");

            string strConnectionStringUsingStorageAccountNameAndKey = connectionString.GetConnectionstringByStorageAccountNameAndKey("StorageAccountName", "StorageAccountKey");

            string strConnectionStringUsingStorageAccountNameAndKeyWithHttp = connectionString.GetConnectionstringByStorageAccountNameAndKey("StorageAccountName", "StorageAccountKey", false);

        }
    }
}
