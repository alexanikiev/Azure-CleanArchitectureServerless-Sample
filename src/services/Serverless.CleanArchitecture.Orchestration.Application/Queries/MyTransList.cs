// Copyright (c) 2024 alexanikiev.dev.

using Ardalis.GuardClauses;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Serverless.CleanArchitecture.Core.Application.Handlers;
using Serverless.CleanArchitecture.Core.Application.Services;
using Serverless.CleanArchitecture.Core.Domain.Entities;
using Serverless.CleanArchitecture.Core.Domain.Models;
using Serverless.CleanArchitecture.Core.Application.Services.Persistence;

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
            private readonly IMyTransService myTransService;
            private readonly ILogger<Handler> logger;

            public Handler(
                IPersistenceDbContext dbContext,
                IMyTransService myTransService,
                IMediator mediator,
                IMapper mapper,
                ILogger<Handler> logger)
                : base(mediator, mapper)
            {
                this.dbContext = dbContext;
                this.myTransService = myTransService;
                this.logger = logger;
            }

            public async Task<Result> Handle(Query query, CancellationToken cancellationToken)
            {
                Guard.Against.Null(query, nameof(query));
                //Guard.Against.NullOrEmpty(query.MyId, nameof(query.MyId));

                return new Result()
                {
                    Records = await this.myTransService.ReadAllMyTransAsync(),
                };
            }
        }

        public class Result : List<MyTrans>
        {
            public List<MyTrans>? Records { get; set; }
        }
    }
}
