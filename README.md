
# Getting Started with Apimatic API

## Introduction

This API gives you programmatic access to APIMatic's Code Generation, Docs Generation and Transformation Engine

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.APIMaticApisSDK --version 3.0.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.APIMaticApisSDK/3.0.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `CustomHeaderAuthenticationCredentials` | [`CustomHeaderAuthenticationCredentials`](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/$a/https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
ApimaticAPI.Standard.ApimaticAPIClient client = new ApimaticAPI.Standard.ApimaticAPIClient.Builder()
    .CustomHeaderAuthenticationCredentials(
        new CustomHeaderAuthenticationModel.Builder(
            "Authorization"
        )
        .Build())
    .Build();
```

## Authorization

This API uses the following authentication schemes.

* [`Authorization (Custom Header Signature)`](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/$a/https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/custom-header-signature.md)

## List of APIs

* [APIs Management](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/controllers/apis-management.md)
* [Code Generation-Imported APIs](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/controllers/code-generation-imported-apis.md)
* [Code Generation-External APIs](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/controllers/code-generation-external-apis.md)
* [Docs Portal Management](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/controllers/docs-portal-management.md)
* [API Validation-Imported APIs](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/controllers/api-validation-imported-apis.md)
* [API Validation-External APIs](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/controllers/api-validation-external-apis.md)
* [Transformation](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/controllers/transformation.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/apimatic-dotnet-sdk/tree/3.0.0/doc/api-exception.md)

