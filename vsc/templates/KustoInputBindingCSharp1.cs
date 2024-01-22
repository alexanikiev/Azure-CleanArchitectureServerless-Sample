using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Kusto;

namespace Company.Function {
  public static class KustoInputBindingCSharp1 {
    // Visit https://github.com/Azure/Webjobs.Extensions.Kusto/tree/main/samples/samples-csharp#kustoattribute-for-input-bindings
    // KustoInputBinding sample 
    // Execute queries against the ADX cluster.
    // Add `KustoConnectionString` to the local.settings.json
    [FunctionName("KustoInputBindingCSharp1")]
    public static IActionResult Run(
      [HttpTrigger(AuthorizationLevel.Function, "get", Route = "api/item/get")] HttpRequest req,
      [Kusto(Database: "",
        KqlCommand = "", // KQL to execute : declare query_parameters (records:int); | take records
        KqlParameters = "", // Parameters to bind : @records={records}
        Connection = "KustoConnectionString")] IEnumerable <Object> result,
      ILogger log) {
      log.LogInformation("C# HTTP trigger with Kusto Input Binding function processed a request.");

      return new OkObjectResult(result);
    }
  }
}