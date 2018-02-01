using AzureDevHelper.StorageAccount.Services.ConnectionStringHelper;
using System;
using System.Collections.Generic;
using System.Text;
using BL = AzureDevHelper.StorageAccount.BusinessLogic;

namespace AzureDevHelper.StorageAccount.Helpers
{
    public class ConnectionStringHelper
    {
        BL.ConnectionString connectionString;
        public ConnectionStringHelper()
        {
            connectionString = new BL.ConnectionString(new ConnectionStringService());
        }

        public string GetConnectionStringFromConfigFile(string storageAccountConnectionKey)
        {
          return  connectionString.GetConnectionStringFromConfigFile(storageAccountConnectionKey);
        }


        public string GetConnectionstringByStorageAccountNameAndKey(string storageAccountName, string storageAccountAccessKey)
        {
            return connectionString.GetConnectionstringByStorageAccountNameAndKey(storageAccountName, storageAccountAccessKey);
        }

        public string GetConnectionstringByStorageAccountNameAndKey(string storageAccountName, string storageAccountAccessKey,bool isUseHttp)
        {
            return connectionString.GetConnectionstringByStorageAccountNameAndKey(storageAccountName, storageAccountAccessKey,isUseHttp);
        }

    }
}
