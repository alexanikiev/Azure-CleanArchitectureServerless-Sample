// Copyright (c) 2024 alexanikiev.dev.

using Ardalis.GuardClauses;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Serverless.CleanArchitecture.Core.Application.Handlers;
using Serverless.CleanArchitecture.Core.Application.Services;
using Serverless.CleanArchitecture.Core.Domain.Models;

namespace Serverless.CleanArchitecture.Orchestration.Application.Commands
{
    /// <summary>
    /// Implements the business logic for processing of a test job.
    /// </summary>
    /// <remarks>
    /// This implementation of the CQRS pattern with MediatR uses a pattern promoted by Jonathan Williams,
    /// wherein Command, Handler and Result are all within a static class.
    /// This seeks to avoids the 'feature folder' pattern and keep concerns in one file.
    /// Ref: https://www.youtube.com/watch?v=mdzEKGlH0_Q .
    /// </remarks>
    public static class MyTransJob
    {
        /// <summary>
        /// Command used within the application layer.
        /// </summary>
        public class Command : CommandBase, IRequest<Result>
        {
            /// <summary>
            /// Gets or sets Job Id.
            /// </summary>
            public string JobId { get; set; }
        }

        /// <summary>
        /// Handler which processes commands, it contains the business logic.
        /// </summary>
        public class Handler : RequestHandlerBase, IRequestHandler<Command, Result>
        {
            private readonly INotificationService notificationService;
            private readonly IPersistenceDbContext dbContext;
            private readonly ILogger<Handler> logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="Handler"/> class.
            /// </summary>
            /// <param name="notificationService">notificationService.</param>
            /// <param name="dbContext">persistenceDbContext.</param>
            /// <param name="mediator">mediator.</param>
            /// <param name="mapper">mapper.</param>
            /// <param name="logger">logger.</param>
            public Handler(
                INotificationService notificationService,
                IPersistenceDbContext dbContext,
                IMediator mediator,
                IMapper mapper,
                ILogger<Handler> logger)
                : base(mediator, mapper)
            {
                this.dbContext = dbContext;
                this.notificationService = notificationService;
                this.logger = logger;
            }

            /// <inheritdoc/>
            public async Task<Result> Handle(Command command, CancellationToken cancellationToken)
            {
                Guard.Against.Null(command, nameof(command));
                Guard.Against.NullOrEmpty(command.JobId, nameof(command.JobId));

                // TODO:

                return new Result() { RecordId = "test" };
            }
        }

        /// <summary>
        /// Command used within the application layer.
        /// </summary>
        public class Result : OperationResult
        {
            /// <summary>
            /// Gets or sets the entity id that was saved.
            /// </summary>
            public string RecordId { get; set; }
        }
    }
}