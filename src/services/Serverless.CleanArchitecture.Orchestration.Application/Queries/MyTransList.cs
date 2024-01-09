// Copyright (c) 2024 alexanikiev.dev.

using System.Threading;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Serverless.CleanArchitecture.Core.Application.Handlers;
using Serverless.CleanArchitecture.Core.Application.Services;
using Serverless.CleanArchitecture.Core.Domain.DTO.Notifications;
using Serverless.CleanArchitecture.Core.Domain.Entities;
using Serverless.CleanArchitecture.Core.Domain.Models;
using System.Collections.Generic;

namespace Serverless.CleanArchitecture.Orchestration.Application.Queries
{
    public static class MyTransList
    {
        public class Query : QueryBase, IRequest<Result>
        {
            public string MyId { get; set; }
        }

        public class Handler : RequestHandlerBase, IRequestHandler<Query, Result>
        {
            private readonly IPersistenceDbContext dbContext;
            private readonly ILogger<Handler> logger;

            public Handler(
                IPersistenceDbContext dbContext,
                IMediator mediator,
                IMapper mapper,
                ILogger<Handler> logger)
                : base(mediator, mapper)
            {
                this.dbContext = dbContext;
                this.logger = logger;
            }

            public async Task<Result> Handle(Query query, CancellationToken cancellationToken)
            {
                Guard.Against.Null(query, nameof(query));
                Guard.Against.NegativeOrZero(query.Id, nameof(query.Id));

                List<MyTrans> MyTrans = new List<MyTrans>();

                // TODO:

                return (Result)MyTrans;
            }
        }

        public class Result : List<MyTrans>
        {
        }
    }
}
