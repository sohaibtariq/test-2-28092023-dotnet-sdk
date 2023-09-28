
# Getting Started with Merged Api

## Introduction

Boost API example documentation.

### Authentication

<!-- ReDoc-Inject: <security-definitions> -->, Simple calculator API hosted on APIMATIC


## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (MergedApi.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the MergedApi.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Merged%20Api-CSharp&workspaceName=MergedApi&projectName=MergedApi.Standard&rootNamespace=MergedApi.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Merged%20Api-CSharp&workspaceName=MergedApi&projectName=MergedApi.Standard&rootNamespace=MergedApi.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Merged%20Api-CSharp&workspaceName=MergedApi&projectName=MergedApi.Standard&rootNamespace=MergedApi.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `MergedApi.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Merged%20Api-CSharp&workspaceName=MergedApi&projectName=MergedApi.Standard&rootNamespace=MergedApi.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `MergedApi.Standard` and click `OK`. By doing this, we have added a reference of the `MergedApi.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Merged%20Api-CSharp&workspaceName=MergedApi&projectName=MergedApi.Standard&rootNamespace=MergedApi.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Merged%20Api-CSharp&workspaceName=MergedApi&projectName=MergedApi.Standard&rootNamespace=MergedApi.Standard&step=addCode)

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production22`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `OAuthClientId` | `string` | OAuth 2 Client ID |
| `OAuthClientSecret` | `string` | OAuth 2 Client Secret |
| `OAuthToken` | `Models.OAuthToken` | Object for storing information about the OAuth token |

The API client can be initialized as follows:

```csharp
MergedApi.Standard.MergedApiClient client = new MergedApi.Standard.MergedApiClient.Builder()
    .ClientCredentialsAuth("OAuthClientId", "OAuthClientSecret")
    .Environment(MergedApi.Standard.Environment.Production22)
    .Build();
```

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| production22 | **Default** Production environment, This environment connect to the LIVE calculator API |
| development | development |

## Authorization

This API uses `OAuth 2 Client Credentials Grant`.

## Client Credentials Grant

Your application must obtain user authorization before it can execute an endpoint call in case this SDK chooses to use *OAuth 2.0 Client Credentials Grant*. This authorization includes the following steps

The `FetchToken()` method will exchange the OAuth client credentials for an *access token*. The access token is an object containing information for authorizing client requests and refreshing the token itself.

```csharp
var authManager = client.ClientCredentialsAuth;

try
{
    OAuthToken token = authManager.FetchToken();
    // re-instantiate the client with OAuth token
    client = client.ToBuilder().OAuthToken(token).Build();
}
catch (ApiException e)
{
    // TODO Handle exception
}
```

The client can now make authorized endpoint calls.

### Storing an access token for reuse

It is recommended that you store the access token for reuse.

```csharp
// store token
SaveTokenToDatabase(client.ClientCredentialsAuth.OAuthToken);
```

### Creating a client from a stored token

To authorize a client from a stored access token, just set the access token in Configuration along with the other configuration parameters before creating the client:

```csharp
// load token later
OAuthToken token = LoadTokenFromDatabase();

// Provide token along with other configuration properties while instantiating the client
MergedApiClient client = client.ToBuilder().OAuthToken(token).Build();
```

### Complete example

```csharp
using MergedApi.Standard;
using MergedApi.Standard.Models;
using MergedApi.Standard.Exceptions;
using MergedApi.Standard.Authentication;
using System.Collections.Generic;
namespace OAuthTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MergedApi.Standard.MergedApiClient client = new MergedApi.Standard.MergedApiClient.Builder()
                .ClientCredentialsAuth("OAuthClientId", "OAuthClientSecret")
                .Environment(MergedApi.Standard.Environment.Production22)
                .Build();
            try
            {
                OAuthToken token = LoadTokenFromDatabase();

                // Set the token if it is not set before
                if (token == null)
                {
                    var authManager = client.ClientCredentialsAuth;
                    token = authManager.FetchToken();
                }

                SaveTokenToDatabase(token);
                client = client.ToBuilder().OAuthToken(token).Build();
            }
            catch (OAuthProviderException e)
            {
                // TODO Handle exception
            }
        }

        //function for storing token to database
        static void SaveTokenToDatabase(OAuthToken token)
        {
            //Save token here
        }

        //function for loading token from database
        static OAuthToken LoadTokenFromDatabase()
        {
            OAuthToken token = null;
            //token = Get token here
            return token;
        }
    }
}

// the client is now authorized and you can use controllers to make endpoint calls
```

## List of APIs

* [Simple Calculator](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/controllers/simple-calculator.md)
* [O Auth Authorization](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/controllers/o-auth-authorization.md)
* [Authentication](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/controllers/authentication.md)
* [Quoting](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/controllers/quoting.md)
* [Policy](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/controllers/policy.md)
* [Insured-Risk](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/controllers/insured-risk.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sohaibtariq/test-2-28092023-dotnet-sdk/tree/0.0.1/doc/api-exception.md)

