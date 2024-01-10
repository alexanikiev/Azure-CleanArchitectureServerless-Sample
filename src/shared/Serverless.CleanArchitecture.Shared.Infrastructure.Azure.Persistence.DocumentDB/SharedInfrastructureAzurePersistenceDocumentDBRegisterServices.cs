// Copyright (c) 2024 alexanikiev.dev.

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serverless.CleanArchitecture.Core.Application.Services.Persistence;
using Serverless.CleanArchitecture.Shared.Infrastructure.Azure.Persistence.DocumentDB.Services;

namespace Serverless.CleanArchitecture.Shared.Infrastructure.Azure.Persistence.DocumentDB
{
    /// <summary>
    /// RegisterServices at shared infrastructure layer for DocumentDB Persistence.
    /// </summary>
    public static class SharedInfrastructureAzurePersistenceDocumentDBRegisterServices
    {
        /// <summary>
        /// Adds the shared infrastructure SQL concerns to the service collection.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddSharedInfrastructureAzurePersistenceDocumentDB(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<PersistenceDbContext>(options =>
            {
                options.UseCosmos(configuration["CosmosDbEndpointUrl"], configuration["CosmosDbPrimaryKey"], configuration["CosmosDbDatabaseName"]);
            });

            serviceCollection.AddScoped<IMyTransService, MyTransService>();
        }
    }
}