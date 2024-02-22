# Deploy a .NET Aspire app to Azure Container Apps
[Microsoft Tutorial](https://learn.microsoft.com/en-us/dotnet/aspire/deployment/azure/aca-deployment?tabs=visual-studio%2Cinstall-az-windows%2Cpowershell&pivots=azure-azd)

## What you'll learn
- How to provision an Azure resource group and Container Registry
- How to publish the .NET Aspire projects as container images in Azure Container Registry
- How to provision a Redis container in Azure
- How to deploy the apps to an Azure Container Apps environment
- How to view application console logs to troubleshoot application issues

## Setup the app
1. Bootstrap a new .NET Aspire project ```dotnet new aspire-starter --use-redis-cache --output AspireSample```
2. cd into the root of your .NET Aspire project
3. Execute the ```azd init``` command to initialize your project with azd, which will inspect the local directory structure and determine the type of app
4. Select **Use code in the current directory**
5. Select the **Confirm and continue initializing my app option**
6. Select only the **webfrontend** (using the spacebar), since you want the API to be private to the Azure Container Apps environment and not available publicly
7. Finally, specify the the environment name, which is used to name provisioned resources in Azure and managing different environments such as **dev** and **prod**.

### What does all this do?
`azd` generates a number of files and places them into the working directory. These files are:

#### azure.yaml: 
Describes the services of the app, such as .NET Aspire AppHost project, and maps them to Azure resources.
#### .azure/config.json: 
Configuration file that informs azd what the current active environment is.
#### .azure/aspireazddev/.env: 
Contains environment specific overrides.
#### .azure/aspireazddev/config.json: 
Configuration file that informs azd which services should have a public endpoint in this environment.

## Deploy the app
1. Run `azd up` to deploy the app to Azure Container Apps
2. Log into Azure, and navigate to rg-{environment-name} resource group to see all the stuff `azd up` created for the aspire app
3. Click on the web app to see the app running in the browser
4. Run `az group delete --name rg-<your-environment-name>` to delete the resource group and all the resources in it

[Back to solution readme](../README.md)