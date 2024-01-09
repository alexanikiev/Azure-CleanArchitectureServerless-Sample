// Copyright (c) 2024 alexanikiev.dev.

using System.Reflection;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serverless.CleanArchitecture.Orchestration.Application.Mappers;

namespace Serverless.CleanArchitecture.Orchestration.Application
{
    /// <summary>
    /// RegisterServices at application layer.
    /// </summary>
    public static class ApplicationRegisterServices
    {
        /// <summary>
        /// Adds the application concerns to the service collection.
        /// </summary>
        /// <param name="serviceCollection">The service collection.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddApplication(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            _ = configuration;
            serviceCollection.AddMediatR(typeof(ApplicationRegisterServices).GetTypeInfo().Assembly);
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile(new ApplicationAutomapperProfile()));
        }
    }
}