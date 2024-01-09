// Copyright (c) 2024 alexanikiev.dev.

using AutoMapper;
using Serverless.CleanArchitecture.Core.Domain.Entities;
using Serverless.CleanArchitecture.Orchestration.Application.Commands;

namespace Serverless.CleanArchitecture.Orchestration.Application.Mappers
{
    /// <summary>
    /// Automapper profile for application layer.
    /// </summary>
    public class ApplicationAutomapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAutomapperProfile"/> class.
        /// </summary>
        public ApplicationAutomapperProfile()
        {
            this.CreateMap<MyTransJob.Command, MyTrans>()
                .ForMember(dest => dest.Id, source => source.Ignore());
        }
    }
}
