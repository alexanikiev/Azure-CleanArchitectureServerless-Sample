// Copyright (c) 2024 alexanikiev.dev.

using System;
using AutoMapper;
using Azure.Messaging.EventGrid.SystemEvents;

namespace Serverless.CleanArchitecture.Orchestration.Host.Function.Mappers
{
    /// <summary>
    /// Automapper profile for function layer.
    /// </summary>
    public class FunctionAutomapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionAutomapperProfile"/> class.
        /// </summary>
        public FunctionAutomapperProfile()
        {
            // TODO:
        }
    }
}
