// Copyright (c) 2024 alexanikiev.dev.

using AutoMapper;
using MediatR;

namespace Serverless.CleanArchitecture.Core.Application.Handlers
{
    /// <summary>
    /// The RequestHandler base class for common properties.
    /// </summary>
    public class RequestHandlerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestHandlerBase" /> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="mapper">The mapper.</param>
        public RequestHandlerBase(
            IMediator mediator,
            IMapper mapper)
        {
            this.Mediator = mediator;
            this.Mapper = mapper;
        }

        /// <summary>
        /// Gets the mediator.
        /// </summary>
        protected IMediator Mediator { get; private set; }

        /// <summary>
        /// Gets the mapper.
        /// </summary>
        protected IMapper Mapper { get; private set; }
    }
}