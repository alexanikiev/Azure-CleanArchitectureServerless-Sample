// Copyright (c) 2024 alexanikiev.dev.

using System.Reflection;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serverless.CleanArchitecture.Shared.Infrastructure.Azure.Mappers;

namespace Serverless.CleanArchitecture.Shared.Infrastructure.Azure
{
    /// <summary>
    /// RegisterServices at shared infrastructure layer.
    /// </summary>
    public static class SharedInfrastructureAzureRegisterServices
    {
        /// <summary>
        /// Adds the shared infrastructure concerns to the service collection.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddSharedInfrastructureAzure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            // Add automapper and mediatr for this application layer:
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile(new SharedInfrastructureAzureAutomapperProfile()));
            serviceCollection.AddMediatR(typeof(SharedInfrastructureAzureRegisterServices).GetTypeInfo().Assembly);

            // TODO:
        }
    }
}