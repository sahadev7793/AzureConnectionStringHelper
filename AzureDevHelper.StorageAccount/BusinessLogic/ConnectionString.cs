using AzureDevHelper.StorageAccount.Services.ConnectionStringHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureDevHelper.StorageAccount.BusinessLogic
{
   
    internal class ConnectionString
    {
        private IConnnectionStringService _ConnnectionStringService;

        public ConnectionString(IConnnectionStringService connnectionStringService)
        {
            this._ConnnectionStringService = connnectionStringService;
        }
        public string GetConnectionStringFromConfigFile(string storageAccountConnectionString)
        {
            return _ConnnectionStringService.GetConnectionStringFromConfigFile(storageAccountConnectionString);
        }

        public string GetConnectionstringByStorageAccountNameAndKey(string storageAccountName, string storageAccountAccessKey)
        {
            return _ConnnectionStringService.GetConnectionstringByStorageAccountNameAndKey(storageAccountName, storageAccountAccessKey);
        }

        public string GetConnectionstringByStorageAccountNameAndKey(string storageAccountName, string storageAccountAccessKey, bool isUseHttp)
        {
            return _ConnnectionStringService.GetConnectionstringByStorageAccountNameAndKey(storageAccountName, storageAccountAccessKey,isUseHttp);
        }
    }
}
