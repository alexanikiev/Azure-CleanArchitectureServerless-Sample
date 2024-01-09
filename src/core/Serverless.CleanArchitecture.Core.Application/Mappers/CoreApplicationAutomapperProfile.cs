// Copyright (c) 2024 alexanikiev.dev.

using System;
using AutoMapper;
using Serverless.CleanArchitecture.Core.Domain.DTO.Notifications;
using Serverless.CleanArchitecture.Core.Domain.Models;

namespace Serverless.CleanArchitecture.Core.Application.Mappers
{
    /// <summary>
    /// Automapper profile for core application layer.
    /// </summary>
    public class CoreApplicationAutomapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreApplicationAutomapperProfile"/> class.
        /// </summary>
        public CoreApplicationAutomapperProfile()
        {
            this.CreateMap<CommandBase, Acknowledgement>()
                .ForMember(dest => dest.RequestIdAcknowledged, source => source.MapFrom(s => s.Id))
                .ForMember(dest => dest.Id, source => source.MapFrom(s => Guid.NewGuid().ToString()));
        }
    }
}