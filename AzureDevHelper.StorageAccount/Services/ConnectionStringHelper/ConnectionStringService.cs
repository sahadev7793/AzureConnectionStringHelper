using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace AzureDevHelper.StorageAccount.Services.ConnectionStringHelper
{
    internal  class ConnectionStringService : IConnnectionStringService
    {

        /// <summary>
        ///  This function use for get connection string from webconfig or appconfig by just passing Key of config file
        /// </summary>
        /// <param name="storageAccountConnectionKey">Key in Config file</param>
        /// <returns>Connection string of azure storage account</returns>
        public string GetConnectionStringFromConfigFile(string storageAccountConnectionKey)
        {
            try
            {
                return ConfigurationManager.AppSettings[storageAccountConnectionKey].ToString(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// This Method generate string Format connection string using storage account name and storage account key
        /// </summary>
        /// <param name="storageAccountName">Azure storage account name</param>
        /// <param name="storageAccountAccessKey">Azure storage account key</param>
        /// <returns>Connection string  of storage account</returns>
        public string GetConnectionstringByStorageAccountNameAndKey(string storageAccountName, string storageAccountAccessKey)
        {
            return GetConnectionstringByStorageAccountNameAndKey(storageAccountName, storageAccountAccessKey, true);
        }



        /// <summary>
        /// This Method generate string Format connection string using storage account name and storage account key
        /// </summary>
        /// <param name="storageAccountName">Azure storage account name</param>
        /// <param name="storageAccountAccessKey">Azure storage account key</param>
        /// <param name="isUseHttp">Use http for storage account or not</param>
        /// <returns>connection string  of storage account</returns>
        public string GetConnectionstringByStorageAccountNameAndKey(string storageAccountName, string storageAccountAccessKey , bool isUseHttp)
        {
            try
            {
                StorageCredentials storageCredentials = new StorageCredentials(storageAccountName,storageAccountAccessKey);
                CloudStorageAccount storageAccount = new CloudStorageAccount(storageCredentials, true);
                return storageAccount.ToString(true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
