# Code Generation-External APIs

```csharp
CodeGenerationExternalApisController codeGenerationExternalApisController = client.CodeGenerationExternalApisController;
```

## Class Name

`CodeGenerationExternalApisController`

## Methods

* [Generate SDK Via File](../../doc/controllers/code-generation-external-apis.md#generate-sdk-via-file)
* [Generate SDK Via URL](../../doc/controllers/code-generation-external-apis.md#generate-sdk-via-url)
* [Download Generated SDK](../../doc/controllers/code-generation-external-apis.md#download-generated-sdk)
* [List All Code Generations External](../../doc/controllers/code-generation-external-apis.md#list-all-code-generations-external)
* [Download Input File Codegen](../../doc/controllers/code-generation-external-apis.md#download-input-file-codegen)
* [Get a Code Generation Codegen](../../doc/controllers/code-generation-external-apis.md#get-a-code-generation-codegen)
* [Delete Code Generation 1](../../doc/controllers/code-generation-external-apis.md#delete-code-generation-1)


# Generate SDK Via File

Generate an SDK for an API by by uploading the API specification file.

This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.

This endpoint does not import an API into APIMatic.

```csharp
GenerateSDKViaFileAsync(
    FileStreamInfo file,
    Models.Platforms template)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |
| `template` | [`Platforms`](../../doc/models/platforms.md) | Form, Required | The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in. |

## Response Type

[`Task<Models.UserCodeGeneration>`](../../doc/models/user-code-generation.md)

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
Platforms template = Platforms.CSNETSTANDARDLIB;
try
{
    UserCodeGeneration result = await codeGenerationExternalApisController.GenerateSDKViaFileAsync(
        file,
        template
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Generate SDK Via URL

Generate an SDK for an API by providing the URL of the API specification file.

This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.

This endpoint does not import an API into APIMatic.

```csharp
GenerateSDKViaURLAsync(
    Models.GenerateSdkViaUrlRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GenerateSdkViaUrlRequest`](../../doc/models/generate-sdk-via-url-request.md) | Body, Required | Request Body |

## Response Type

[`Task<Models.UserCodeGeneration>`](../../doc/models/user-code-generation.md)

## Example Usage

```csharp
GenerateSdkViaUrlRequest body = new GenerateSdkViaUrlRequest
{
    Url = "http://petstore.swagger.io/v2/swagger.json",
    Template = Platforms.CSNETSTANDARDLIB,
};

try
{
    UserCodeGeneration result = await codeGenerationExternalApisController.GenerateSDKViaURLAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Download Generated SDK

Download the SDK generated via the Generate SDK endpoints.

```csharp
DownloadGeneratedSDKAsync(
    string codegenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `codegenId` | `string` | Template, Required | The ID of code generation received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls. |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string codegenId = "codegen_id6";
try
{
    Stream result = await codeGenerationExternalApisController.DownloadGeneratedSDKAsync(codegenId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# List All Code Generations External

Get a list of all SDK generations performed with external APIs via the Generate SDK endpoints.

```csharp
ListAllCodeGenerationsExternalAsync()
```

## Response Type

[`Task<List<Models.UserCodeGeneration>>`](../../doc/models/user-code-generation.md)

## Example Usage

```csharp
try
{
    List<UserCodeGeneration> result = await codeGenerationExternalApisController.ListAllCodeGenerationsExternalAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Download Input File Codegen

Download the API Specification file used as input for a specific SDK generation performed via the Generate SDK endpoints.

```csharp
DownloadInputFileCodegenAsync(
    string codegenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `codegenId` | `string` | Template, Required | The ID of the code generation to download the API specification for. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string codegenId = "codegen_id6";
try
{
    Stream result = await codeGenerationExternalApisController.DownloadInputFileCodegenAsync(codegenId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get a Code Generation Codegen

Get details on an SDK generation performed for an external API via the Generate SDK endpoints.

```csharp
GetACodeGenerationCodegenAsync(
    string codegenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `codegenId` | `string` | Template, Required | The ID of the code generation to fetch. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls. |

## Response Type

[`Task<Models.UserCodeGeneration>`](../../doc/models/user-code-generation.md)

## Example Usage

```csharp
string codegenId = "codegen_id6";
try
{
    UserCodeGeneration result = await codeGenerationExternalApisController.GetACodeGenerationCodegenAsync(codegenId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Code Generation 1

Delete an SDK generation performed for an API via the Generate SDK endpoints.

```csharp
DeleteCodeGeneration1Async(
    string codegenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `codegenId` | `string` | Template, Required | The ID of the code generation to delete. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls. |

## Response Type

`Task`

## Example Usage

```csharp
string codegenId = "codegen_id6";
try
{
    await codeGenerationExternalApisController.DeleteCodeGeneration1Async(codegenId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

