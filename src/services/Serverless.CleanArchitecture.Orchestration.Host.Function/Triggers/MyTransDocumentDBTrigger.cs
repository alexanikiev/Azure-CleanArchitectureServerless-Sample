// Copyright (c) 2024 alexanikiev.dev.

using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Serverless.CleanArchitecture.Orchestration.Application.Queries;

namespace Serverless.CleanArchitecture.Orchestration.Host.Function.Triggers
{
    internal class MyTransDocumentDBTrigger
    {
        private readonly IMediator mediator;

        public MyTransDocumentDBTrigger(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [FunctionName("MyTransDocumentDBTrigger")]
        public async Task<ActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger logger)
        {
            logger.LogInformation("C# HTTP trigger function processed a request.");

            var query = new MyTransList.Query();

            var res = await this.mediator.Send(query);

            return new OkObjectResult(res.Records);
        }
    }
}
