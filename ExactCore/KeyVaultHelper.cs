// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyVaultHelper.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the KeyVaultHelper type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ExactCore
{
    using System;
    using System.Collections.Generic;

    using Microsoft.Azure.KeyVault;
    using Microsoft.Azure.KeyVault.Models;
    using Microsoft.Azure.Services.AppAuthentication;

    /// <summary>
    /// Helper for keyvault.
    /// </summary>
    public static class KeyVaultHelper
    {
        /// <summary>
        ///  Get multiple secrets (max. 25).
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="secrets"></param>
        public static void GetKeyVaultSecret( string secretName, Dictionary<string, string> secrets)
        {
            //log.LogInformation($"Getting url of keyvault {GetEnvironmentVariable("KeyVaultUri")}");
            var keyVaultUrl = GetEnvironmentVariable("KeyVaultUri");

            var azureServiceTokenProvider = new  AzureServiceTokenProvider();
            var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));


            //log.LogInformation($"Getting secret {secretName}");
            try
            {
                var secret = keyVaultClient.GetSecretAsync(keyVaultUrl, secretName).Result;
                secrets.Add(secretName, secret.Value);
            }
            catch (KeyVaultErrorException ex)
            {
                if (!ex.Message.StartsWith("Secret not found in vault"))
                {
                   // log.LogError(ex.Message, ex);
                    // throw;
                }
            }
            catch (Exception exception)
            {
                if (exception.InnerException == null || !exception.InnerException.Message.StartsWith("Operation returned an invalid status code 'NotFound'"))
                {
                 //   log.LogError(exception.Message, exception);
                    throw;
                }
            }
        }


        /// <summary>
        /// Get single secret.
        /// </summary>
        /// <param name="secretName"></param>
        /// <returns></returns>
        public static string GetKeyVaultSecret( string secretName)
        {
        //    log.LogInformation($"Getting url of keyvault {GetEnvironmentVariable("KeyVaultUri")}");
            var keyVaultUrl = "https://kvdaniel.vault.azure.net/";// GetEnvironmentVariable("KeyVaultUri");

            var azureServiceTokenProvider = new AzureServiceTokenProvider();
            var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));

         //   log.LogInformation($"Getting secret {secretName}");
            try
            {
                var secret = keyVaultClient.GetSecretAsync(keyVaultUrl, secretName);
           //     log.LogInformation($"Got secret {secretName}");
                return secret.Result.Value;
            }
            catch (KeyVaultErrorException ex)
            {
                if (!ex.Message.StartsWith("Secret not found in vault"))
                {
             //       log.LogError(ex.Message, ex);
                    throw;
                }
            }

            return string.Empty;
        }

        public static string SetKeyVaultSecret(string secretName, string value)
        {
            //    log.LogInformation($"Getting url of keyvault {GetEnvironmentVariable("KeyVaultUri")}");
            var keyVaultUrl = "https://kvdaniel.vault.azure.net/";// GetEnvironmentVariable("KeyVaultUri");

            var azureServiceTokenProvider = new AzureServiceTokenProvider();
            var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));

            //   log.LogInformation($"Getting secret {secretName}");
            try
            {
                var secret = keyVaultClient.SetSecretAsync(keyVaultUrl, secretName, value);
                //     log.LogInformation($"Got secret {secretName}");
                return secret.Result.Value;
            }
            catch (KeyVaultErrorException ex)
            {
                if (!ex.Message.StartsWith("Secret not found in vault"))
                {
                    //       log.LogError(ex.Message, ex);
                    throw;
                }
            }

            return string.Empty;
        }

        public static string GetEnvironmentVariable(string name)
        {
            return System.Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process);
        }
    }
}
