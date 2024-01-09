// Copyright (c) 2024 alexanikiev.dev.

using System.Diagnostics.CodeAnalysis;
using Azure;
using Azure.Identity;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using Serverless.CleanArchitecture.Orchestration.Host.Function;

[assembly: Microsoft.Azure.Functions.Extensions.DependencyInjection.FunctionsStartup(typeof(Startup))]

namespace Serverless.CleanArchitecture.Orchestration.Host.Function
{
    /// <summary>
    /// FunctionsStartup.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Startup : FunctionsStartup
    {
        private IConfiguration configuration;

        /// <inheritdoc/>
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHostFunction(this.configuration);
        }

        /// <inheritdoc/>
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            #region Snippet:FunctionAppConfiguration

            // Get local app settings, these will include the AppConfigurationConnectionString.
            this.configuration = builder.ConfigurationBuilder.Build();

            // Use local settings to pull the rest of the remote config:
            // Ref: https://docs.microsoft.com/en-us/azure/azure-app-configuration/quickstart-aspnet-core-app?tabs=core5x
            // Ref: https://docs.microsoft.com/en-us/azure/azure-app-configuration/howto-labels-aspnet-core
            // Note that when using key-vault references, it requires additional setup:
            // Ref: https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references
            // Ref: https://docs.microsoft.com/en-us/azure/azure-app-configuration/use-key-vault-references-dotnet-core?tabs=cmd%2Ccore3x#update-your-code-to-use-a-key-vault-reference
            var appConfigurationConnectionString = this.configuration.GetValue<string>("AppConfigurationConnectionString");
            var deploymentEnvironmentLabel = this.configuration.GetValue<string>("AppConfigurationEnvironmentLabel");

            if (!string.IsNullOrEmpty(appConfigurationConnectionString))
            {
                builder.ConfigurationBuilder.AddAzureAppConfiguration(options =>
                    options
                        .Connect(appConfigurationConnectionString)
                        .Select(KeyFilter.Any, LabelFilter.Null)
                        .Select(KeyFilter.Any, deploymentEnvironmentLabel)
                        .ConfigureKeyVault(kv =>
                        {
                            kv.SetCredential(new DefaultAzureCredential(includeInteractiveCredentials: true));
                        }));
            }
            #endregion

            #region Snippet:FunctionAppConfigurationErrorHandling

            // Update the configuration
            try
            {
                this.configuration = builder.ConfigurationBuilder.Build();
            }
            catch (RequestFailedException e) when (e.Source == "Azure.Data.AppConfiguration")
            {
                _ = e;

                // When the app setting "AppConfigurationConnectionString" is set, this app is configured
                // to consume its app settings from a remote Azure App Configuration server.
                // Check that the connection string is correct.
                throw;
            }
            catch (KeyVaultReferenceException e) when (e.Source == "Microsoft.Extensions.Configuration.AzureAppConfiguration")
            {
                _ = e;

                // That app configuration server contains references to an azure key-vault which contains
                // connection string secrets.
                // The application is expected to use a managed service identity that has an appropriate
                // key-vault access policy when deployed on Azure.
                // When running locally, the app will attempt to use the local user's identity.  That user's
                // identity principal must also have key vault secret-read access.
                // Use the portal or the following to create a key-vault policy for you logged in user.
                //      $keyVaultName="your-vault"
                //      $targetUserPrincipalName = az ad signed-in-user show --query "userPrincipalName" -o tsv
                //      az keyvault set-policy --name $keyVaultName --secret-permissions list get --upn $targetUserPrincipalName
                throw;
            }
            catch (System.AggregateException e) when (e.Source == "Azure.Core")
            {
                _ = e;

                // Well-formed but incorrect app-configuration connections strings may retry three times and throw an aggregate exception.
                // Check that your app-configuration connection string points to the right server and has the right key.
                throw;
            }
            #endregion
        }
    }
}
