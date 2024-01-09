// Copyright (c) 2024 alexanikiev.dev.

using System.Reflection;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serverless.CleanArchitecture.Core.Application;
using Serverless.CleanArchitecture.Orchestration.Host.Function.Mappers;
using Serverless.CleanArchitecture.Orchestration.Application;
using Serverless.CleanArchitecture.Shared.Infrastructure.Azure;
using Serverless.CleanArchitecture.Shared.Infrastructure.Azure.Persistence.DocumentDB;

namespace Serverless.CleanArchitecture.Orchestration.Host.Function
{
    /// <summary>
    /// RegisterServices at host function layer.
    /// </summary>
    public static class HostFunctionRegisterServices
    {
        /// <summary>
        /// Adds the host function concerns to the service collection.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddHostFunction(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            // Add services from this project:
            serviceCollection.AddMediatR(typeof(HostFunctionRegisterServices).GetTypeInfo().Assembly);
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile(new FunctionAutomapperProfile()));

            // Add services from linked projects:
            serviceCollection.AddApplication(configuration);
            serviceCollection.AddCoreApplication(configuration);
            serviceCollection.AddSharedInfrastructureAzure(configuration);
            serviceCollection.AddSharedInfrastructureAzurePersistenceDocumentDB(configuration);
        }
    }
}
