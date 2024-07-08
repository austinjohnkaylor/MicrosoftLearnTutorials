# Build your first Orleans app with ASP.NET Core 8.0
[Microsoft Learn Link](https://learn.microsoft.com/en-us/training/modules/orleans-build-your-first-app/?source=recommendations)

# Background
## What is Microsoft Orleans?
Orleans is a cross-platform framework designed to simplify building scalable, distributed, cloud-native applications. Orleans runs anywhere that .NET is supported and integrates well with other platform features.
## Components of Microsoft Orleans
### Grains
- The most essential primitives and building blocks of Orleans applications. 
- They represent actors in the Actor model 
- They define the state data and behavior of an entity, such as shopping cart or product. 
- They are each identified and tracked through user-defined keys and other grains and clients can access them.
- Grains are stored in Silos
- Active Grains remain in-memory and are managed by the Silo
- Inactive Grains are stored in a database and are rehydrated when needed
### Silos
- A Silo is a container for Grains and manages their lifecycle
- Silos can contain one or more Grains
- A group of Silos is known as a `cluster`
### Clusters
- A cluster is a group of Silos
- It coordinates work between Silos, allowing communication with grains as though they were all available in a single process

## How are Grains implemented?
- Grains are implemented as classes that inherit from the `Grain` class

##  What is the goal of this module?
This module demonstrates how to build a small but scalable URL shortening app using Orleans. </br> You learn how to use core features of Orleans such as grains and silos to manage data. </br> You also see how to consume that data using clients, perform essential configurations and persist state.
# Pre-requisites
- A local installation of the .NET 8.0 SDK
- Visual Studio Code with the Azure development workload installed
# Architecture

# Learning Objectives
This tutorial demonstrates the following:
- Use Orleans to create and set up a project.
- Work with core Orleans components such as grains and silo.
- Integrate Orleans into web service endpoints.
- Persist and manage state with Orleans.
