using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class ServiceBusTopicTriggerCSharp1
    {
        private readonly ILogger<ServiceBusTopicTriggerCSharp1> _logger;

        public ServiceBusTopicTriggerCSharp1(ILogger<ServiceBusTopicTriggerCSharp1> log)
        {
            _logger = log;
        }

        [FunctionName("ServiceBusTopicTriggerCSharp1")]
        public void Run([ServiceBusTrigger("mytopic", "mysubscription", Connection = "")]string mySbMsg)
        {
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
