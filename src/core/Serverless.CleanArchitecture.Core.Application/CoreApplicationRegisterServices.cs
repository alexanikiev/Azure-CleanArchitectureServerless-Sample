// Copyright (c) 2024 alexanikiev.dev.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serverless.CleanArchitecture.Core.Application.Mappers;

namespace Serverless.CleanArchitecture.Core.Application
{
    /// <summary>
    /// RegisterServices at shared infrastructure layer.
    /// </summary>
    public static class CoreApplicationRegisterServices
    {
        /// <summary>
        /// Adds the core application concerns to the service collection.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddCoreApplication(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            _ = configuration;
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile(new CoreApplicationAutomapperProfile()));
        }
    }
}