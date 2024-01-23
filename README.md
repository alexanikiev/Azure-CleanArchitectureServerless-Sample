# Azure-CleanArchitectureServerless-Sample

Welcome to the Azure Clean Architecture Serverless Sample repository on GitHub. This code base written with the help of [ChatGPT](https://chat.openai.com/) and [GitHub Copilot](https://github.com/github/copilot) serves as a reference implementation of a Serverless Function Host in Microsoft Azure Cloud based on The Clean Architecture Design Template. It's built specifically with extensibility, testability, maintainability and scalability in mind in addition to other critical production grade solution attributes and baseline engineering fundamentals principles. And it showcases application of foundational design patterns such as Dependency Inversion/Dependency Injection (DI), Separation of concerns, CQRS (Command-Query-Responsibility-Segregation) & Mediator (MediatR).

## Motivation

Make everything as simple as possible, but not simpler.

## Getting Started

This .NET sample is optimized for .NET 6.0 and intended to be deployed in Microsoft Azure Cloud as a Serverless Function Host (Azure Function App) with .NET 6.0 (LTS) Windows runtime. It also leverages .NET Entity Framework (EF) for simplifying data access which is achieved through its ORM (Object-Relational Mapping) capabilities.

This sample is built based on the following foundational GitHub templates:

* [Clean Architecture Solution Template](https://github.com/ardalis/CleanArchitecture) by [ardalis](https://github.com/ardalis)
* [Clean Architecture Solution Template for .NET Core Worker Service](https://github.com/ardalis/CleanArchitecture.WorkerService) by [ardalis](https://github.com/ardalis)

Solution architecture of this template is described in detail in the following Medium articles:

* [Building AI Applications for Azure Cloud](https://alexanikiev.medium.com/building-ai-applications-for-azure-cloud-65252b602042)

This code base was created with the help of GitHub Copilot, and also GitHub Copilot can be used to effectively explore this code base and modify it to your needs. You can get started with GitHub Copilot [here](https://docs.github.com/en/copilot/using-github-copilot/getting-started-with-github-copilot?tool=visualstudio#seeing-your-first-suggestion-1).

## Prerequisites

Please see the list below to the core architecturals principles and design patterns that are applied in this template.

| Concept                                         | More Info                                                                                                                                                                                                                 |
|-------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Domain-Driven Design (DDD)                      | [Link](https://martinfowler.com/tags/domain%20driven%20design.html)                                                                                                                                                       |
| Dependency Inversion/Dependency Injection (DI)  | [Link](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection) & [Link](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#dependency-inversion) |
| Separation of concerns (SoC)                    | [Link](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#separation-of-concerns)                                                                                       |
| CQRS (Command-Query-Responsibility-Segregation) | [Link](https://learn.microsoft.com/en-us/azure/architecture/patterns/cqrs) & [Link](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/)                                  |
| Mediator (MediatR)                              | [Link](https://github.com/jbogard/MediatR)                                                                                                                                                                                |

## Technical Architecture

The details of the Technical Architecture for this template are described [here](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/).

![Clean Architecture](/docs/images/clean_architecture.png)

**Domain-Driven Design**: Domain-Driven Design (DDD) is a collection of principles and patterns that help developers craft elegant object systems. Properly applied it can lead to software abstractions called Domain Models. These models encapsulate complex business logic, closing the gap between business reality and code.

_Domain Model: A model of the problem space is composed of Entities, Interfaces, Services, etc. Interfaces define contracts for working with domain objects. Everything in the Application (including Infrastructure and Data Access) depends on these interfaces and domain objects._

**Engineering Fundamentals**: In modern Software Engineering, while adhering to the best design patterns is beneficial, it's not a silver bullet; the true efficiency and robustness of Software Development are anchored in the consistent application of core Engineering Fundamentals. More info about Engineering Fundamentals can be found [here](https://microsoft.github.io/code-with-engineering-playbook/).

Core Engineering Fundamentals:

* Accessibility
* Agile Development
* Automated Testing
* Code Reviews
* Continuos Integration (CI) & Continuous Delivery (CD)
* Design
* Developer Experience
* Documentation
* Engineering Feedback
* Observability
* Security
* Privacy
* Source Control
* Reliability

**Azure Well-Architected Framework (WAF)**: The Azure Well-Architected Framework (WAF) is a set of quality-driven tenets, architectural decision points, and review tools intended to help solution architects build a technical foundation for their workloads. More info about Azure Well-Architected Framework can be found [here](https://learn.microsoft.com/en-us/azure/well-architected/).

Main pillars of Azure Well-Architected Framework:

* Reliability
* Security
* Cost Optimization
* Operational Excellence
* Performance Efficiency

**Clean Architecture Design**: Apps that follow the Dependency Inversion (DI) principle as well as Domain-Driven Design (DDD) principles tend to arrive at a similar architecture. More info about Clean Architecture Design can be found [here](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures).

Key points of Clean Architecture Design:

* Domain contains enterprise logic and types
* Application contains business logic and types
* Infrastructure contains all external concerns
* Presentation and Infrastructure depend only on Application
* Infrastructure and Presentation can be replaced

Main rules for Clean Architecture Solution:

* The Application Core contains the Domain Model
* All projects depend on the Core project; dependencies point inward towards this Core
* Inner projects define interfaces; and outer projects implement them
* Database independent
* User Interface independent

**Microservices & Dapr (Distributed Application Runtime)**: For building Distributed Solutions with Polyglot Microservices Architecture (for example, .NET, NodeJS, Python, Java, etc.) you will likely be looking at containers & Kubernetes and may also be interested in leveraging Dapr. Dapr is a set of integrated APIs with built-in best practices and patterns to build distributed applications. More info about Dapr can be found [here](https://dapr.io/). And although your overall Solution Architecture will be larger and different, the same Clean Architecture principles will still apply to each individual Microservice, and this .NET-based Clean Architecture template can be a part of your overall Solution Architecture.

**Technical Debt**: Managing Technical Debt is increasingly important in Modern Software Engineering, particularly with the advent of generative AI tools like GitHub Copilot and ChatGPT for a number of reasons (Rapid Code Generation and Complexity, Quality and Reliability, Maintenance Challenges, Security and Compliance, Integrations with Existing Systems, Over-reliance of AI, Code Review and Understanding). And while tools like GitHub Copilot and ChatGPT can significantly boost productivity, they also underscore the importance of Software Engineering Best Practices like Code Review, Documentation, Refactoring, and adherence to Coding Standards to manage Technical Debt effectively. Balancing rapid development with sustainable and maintainable code practices is key in the era of AI-assisted Software Engineering.

**Site Reliability Engineering (SRE)**: SRE is a discipline that incorporates aspects of Software Engineering and applies them to Infrastructure and Operations problems. The goal is to create scalable and highly reliable software systems.

![Evolution to Cloud Native](/docs/images/evolution_to_cloud_native.png)

## Design Patterns

**Dependency Inversion/Dependency Injection (DI)**: Dependency Inversion is a design pattern that implements Inversion of Control (IoC) for resolving dependencies. A dependency is an object that can be used (a service). An injection is the passing of a dependency to a dependent object (a client) that would use it. Inversion of Control (IoC) is too generic term, that's why the industry settled on the name Dependency Injection (DI).

**Separation of concerns (SoC)**: The intent behind Dependency Injection (DI) is to achieve Separation of Concerns (SoC) in construction and use of objects. This can increase code readability and code reuse.

**CQRS (Command-Query-Responsibility-Segregation)**: CQRS is a pattern that segregates the operations that read data (queries) from the operations that update data (commands). Implementing CQRS in your application can maximize its performance, scalability, and security. It can also help you to isolate the impact of changes to individual components and to choose the right technologies for each job.

**Mediator (MediatR)**: MediatR is a simple library that allows for in-process messaging with no interfaces. It works by providing a mediator, a single, open generic method for sending requests and a collection of handlers, classes that handle those requests. The main advantage of using MediatR is that it helps to decouple your code, making it easier to maintain and test. However, it's not always the best solution for every situation. It's most beneficial in larger, more complex applications where you have many different operations and want to keep your code organized and decoupled.

## Installing

After you've cloned or downloaded the repository, please open the code base in Visual Studio or Visual Studio Code IDE(s) to review the code.

Before you build and launch the application in Visual Studio or Visual Studio Code, please make sure you have `Serverless.CleanArchitecture.Orchestration.Host.Function` project (in `services` folder) selected as a Start-Up Project, you specified environment variables in `local.settings.json` file, and your Azure Backend infrastructure has been successfully deployed and configured. Once launched locally, Azure Function Host will be up and running on your machine and you can grab Web API URL and test it, for example, in Postman. 

```curl
curl --location 'http://localhost:port/api/MyTransDocumentDBTrigger'
```

Solution structure for this template lools like this:
![Clean Architecture Solution Structure](/docs/images/clean_architecture_solution_structure.png)

For clarity the following diagram shows the dependencies between the projects in the solution:
![Clean Architecture Project Dependencies](/docs/images/clean_architecture_project_dependencies.png)

To illustrate the execution process on an example of EventGridTrigger and how solution components are connected the following diagram is provided:
![Clean Architecture Sample Execution Process](/docs/images/clean_architecture_eventgrid_process.png)

## Cloud Deployment

This sample will feature One-Click Deployment for deploying Azure Function Host. If you need to sign up for Azure Subscription please follow [this](https://azure.microsoft.com/en-us/free/) link.

Attention: This section is still under construction, please check back later. At this point for easy Azure Function Host deployment you may utilize One-Click deployment in Visual Studio or Visual Studio Code IDE(s).

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Falexanikiev%2FAzure-CleanArchitectureServerless-Sample%2Fmain%2Fcloud%2Finfra%2Ftemplate.json)

## Next Steps

This minimalistic template may be a great jump start for your own Clean Architecture project built for Azure Serverless Function Host and the possibilities from now on are truly endless.

## Future Updates

* Finalize infrastructure ARM template for Azure Function Host automated deployment

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
