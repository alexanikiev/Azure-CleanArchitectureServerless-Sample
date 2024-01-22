using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class RabbitMQTriggerCSharp1
    {
        [FunctionName("RabbitMQTriggerCSharp1")]
        public void Run([RabbitMQTrigger("myqueue", ConnectionStringSetting = "")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
