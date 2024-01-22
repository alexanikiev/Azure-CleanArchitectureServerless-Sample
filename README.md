# Azure-CleanArchitectureServerless-Sample

Welcome to the Azure Clean Architecture Serverless Sample repository on GitHub. This code base written with the help of [ChatGPT](https://chat.openai.com/) and [GitHub Copilot](https://github.com/github/copilot) serves as a reference implementation of a Serverless Function Host in Microsoft Azure Cloud based on The Clean Architecture Design Template. It's built specifically with extensibility, testability, maintainability and scalability in mind in addition to other critical production grade solution attributes and baseline engineering fundamentals principles. And it showcases application of foundational design patterns such as Dependency Inversion/Dependency Injection (DI), Separation of concerns, CQRS (Command-Query-Responsibility-Segregation) & Mediator (MediatR).

## Motivation

Make everything as simple as possible, but not simpler.

## Getting Started

Still under development. Please check back later.

Solution architecture of this template is described in detail in the following Medium articles:

* [Building AI Applications for Azure Cloud](https://alexanikiev.medium.com/building-ai-applications-for-azure-cloud-65252b602042)

Getting Started with GitHub Copilot: [here](https://docs.github.com/en/copilot/using-github-copilot/getting-started-with-github-copilot?tool=visualstudio#seeing-your-first-suggestion-1)

## Cloud Deployment

This sample features One-Click Deployment for the necessary Azure Backend services. If you need to sign up for Azure Subscription please follow [this](https://azure.microsoft.com/en-us/free/) link.

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Falexanikiev%2FAzure-CleanArchitectureServerless-Sample%2Fmain%2Fcloud%2Finfra%2Ftemplate.json)

## Function Templates

| Function Template                | CSfile                                                                                                                                           | Link                                                                                                          |
|----------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------|
| BlobTrigger                      | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/BlobTriggerCSharp1.cs)                      | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-storage-blob-trigger)       |
| CosmosDBTrigger                  | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/CosmosDBTriggerCSharp1.cs)                  | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-cosmosdb-v2-trigger)        |
| DaprPublishOutputBinding         | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/DaprPublishOutputBindingCSharp1.cs)         | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-dapr-trigger)               |
| DaprServiceInvocationTrigger     | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/DaprServiceInvocationTriggerCSharp1.cs)     | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-dapr-trigger)               |
| DaprTopicTrigger                 | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/DaprTopicTriggerCSharp1.cs)                 | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-dapr-trigger)               |
| DurableFunctionsEntityHttp       | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/DurableFunctionsEntityHttpCSharp.cs)        | NA                                                                                                            |
| DurableFunctionsOrchestration    | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/DurableFunctionsOrchestrationCSharp1.cs)    | NA                                                                                                            |
| EventGridCloudEventTrigger       | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/EventGridCloudEventTriggerCSharp1.cs)       | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-event-grid-trigger)         |
| EventGridTrigger                 | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/EventGridTriggerCSharp1.cs)                 | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-event-grid-trigger)         |
| EventHubTrigger                  | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/EventHubTriggerCSharp1.cs)                  | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-event-hubs-trigger)         |
| HttpTriggerWithOpenAPI           | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/HttpTriggerWithOpenAPICSharp1.cs)           | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-http-webhook-trigger)       |
| HttpTrigger                      | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/HttpTrigger1.cs)                            | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-http-webhook-trigger)       |
| IotHubTrigger                    | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/IotHubTriggerCSharp1.cs)                    | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-event-iot-trigger)          |
| KafkaOutput                      | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/KafkaOutputCSharp1.cs)                      | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-kafka-trigger)              |
| KafkaTrigger                     | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/KafkaTriggerCSharp1.cs)                     | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-kafka-trigger)              |
| KustoInputBinding                | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/KustoInputBindingCSharp1.cs)                | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-azure-data-explorer-input)  |
| KustoOutputBinding               | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/KustoOutputBindingCSharp1.cs)               | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-azure-data-explorer-output) |
| QueueTrigger                     | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/QueueTrigger1.cs)                           | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-storage-queue-trigger)      |
| RabbitMQTrigger                  | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/RabbitMQTriggerCSharp1.cs)                  | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-rabbitmq-trigger)           |
| SendGrid                         | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/SendGridCSharp1.cs)                         | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-sendgrid)                   |
| ServiceBusQueueTrigger           | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/ServiceBusQueueTriggerCSharp1.cs)           | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-service-bus-trigger)        |
| ServiceBusTopicTrigger           | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/ServiceBusTopicTriggerCSharp1.cs)           | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-service-bus-trigger)        |
| SignalRConnectionInfoHttpTrigger | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/SignalRConnectionInfoHttpTriggerCSharp1.cs) | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-signalr-service-trigger)    |
| SqlInputBinding                  | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/SqlInputBindingCSharp1.cs)                  | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-azure-sql-input)            |
| SqlOutputBinding                 | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/SqlOutputBindingCSharp1.cs)                 | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-azure-sql-output)           |
| SqlTriggerBinding                | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/SqlTriggerBindingCSharp1.cs)                | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-azure-sql-trigger)          |
| TimerTrigger                     | [CS](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample/blob/main/vsc/templates/TimerTriggerCSharp1.cs)                     | [Link](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-timer)                      |

## Disclaimer

This code is provided "as is" without warranties to be used at your own risk.
