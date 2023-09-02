# Build your first microservice with .NET

#### [Microsoft Learn Link](https://learn.microsoft.com/en-us/training/modules/dotnet-microservices/)

## Tutorial Project Information
Suppose that you've started a new job as a software developer at the world's most popular pizza joint, Contoso Pizza. 

Business is booming, and the Contoso Pizza's website that indicates whether pizzas are in stock or not. That website is a monolith right now, but is an ideal candidate for the microservice architecture. 

A team member has already refactored the monolith website into an ASP.NET Core Razor page application and ASP.NET Core web API. Your job is to deploy the services.

## What are microservices?
Microservice applications are composed of small, independently versioned, and scalable customer-focused services that communicate with each other over standard protocols with well-defined interfaces. 

Each microservice typically encapsulates simple business logic, which you can scale out or in, test, deploy, and manage independently. Smaller teams develop a microservice based on a customer scenario and use any technologies that they want to use. This module will teach you how to build your first microservice with .NET.

## What is a microservice architecture?
A large application is split up into a set of smaller bits of the application, usually through services.

Each service runs in its own process and communicates with other processes using protocols such as:
- HTTP/HTTPS
- WebSockets
- AMQP
- gRPC

Each microservice implements a specific end-to-end domain or business capability within a certain context boundary, and each must be developed autonomously and be deployable independently

Finally, each microservice should own its related domain data model and domain logic, and could be based on different data storage technologies (SQL, NoSQL) and different programming languages.

### Some key characteristics of microservices are:
- Microservices are small, independent, and loosely coupled.
- Each microservice has a separate codebase, which can be managed by a small development team.
- Microservices are deployed independently. A team can update an existing microservice without rebuilding and redeploying the entire application.
- Microservices are responsible for persisting their data or external state in their respective databases. Unlike the monolithic architecture, _microservices don't share databases_.
- Microservices communicate with each other by using well-defined APIs. Internal implementation details of each service are hidden from other services.
- Supports polyglot programming. For example, microservices don't need to share the same technology stack, libraries, or frameworks.

## Why develop in a microservice architecture?
One typically houses simple functionality for a customer, keeping in line with the [Single Responsibility Principle](https://en.wikipedia.org/wiki/Single-responsibility_principle)

The service can be tested, hosted, or scaled-out independently of the other services it communicates with

In terms of scaling, you can scale an individual service out without affecting the other services, giving it more computing power than the others in your microservice architecture, rather than scaling out all the services shared by the application that may not need it.

Microservices also allow for agile development and rapid-deployment since each service is siloed from the others.

Architecting fine-grained microservices-based applications enables continuous integration and continuous delivery practices, which also allows for faster delivery of new functionality to the core application

Fine-grained composition of applications also allows you to run and test microservices in isolation, and to evolve them autonomously while maintaining clear contracts between them. As long as you don't change the interfaces or contracts, you can change the internal implementation of any microservice or add new functionality without breaking other microservices

## What role do containers play?
Containerization is an approach to software development in which an application or service, its dependencies, and its configuration (abstracted as deployment manifest files) are packaged together as a container image

You can test the containerized application as a unit, and deploy them as a container image instance to the host operating system (OS)

software containers act as a standard unit of software deployment that can contain different code and dependencies

If that sounds like containerizing an application would be a great way to implement the microservice architecture pattern, it is. The benefits of containers almost line up exactly to the benefits of microservices one-to-one.

> Note
> 
> Containerizing an application is not the only way to deploy microservices. You could deploy microservices as individual services in Azure App Service, or via virtual machines, or any number of ways. However, containers are the tool that we'll use for the rest of this module in which to deploy our microservices.

## Container Technology Stacks
[Docker](https://www.docker.com) is an open-source project for automating the deployment of applications as portable, self-sufficient containers that can run in the cloud or on-premises

[Other Stacks](https://www.cloudzero.com/blog/docker-alternatives)