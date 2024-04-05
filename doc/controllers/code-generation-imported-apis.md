# Code Generation-Imported APIs

```csharp
CodeGenerationImportedApisController codeGenerationImportedApisController = client.CodeGenerationImportedApisController;
```

## Class Name

`CodeGenerationImportedApisController`

## Methods

* [Generate SDK](../../doc/controllers/code-generation-imported-apis.md#generate-sdk)
* [Download SDK](../../doc/controllers/code-generation-imported-apis.md#download-sdk)
* [List All Code Generations Imported](../../doc/controllers/code-generation-imported-apis.md#list-all-code-generations-imported)
* [Get a Code Generation Imported](../../doc/controllers/code-generation-imported-apis.md#get-a-code-generation-imported)
* [Delete Code Generation](../../doc/controllers/code-generation-imported-apis.md#delete-code-generation)


# Generate SDK

Generate an SDK for an API Version.

This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.

```csharp
GenerateSDKAsync(
    string apiEntityId,
    Models.Platforms template)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to generate the SDK for. |
| `template` | [`Platforms`](../../doc/models/platforms.md) | Form, Required | The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in. |

## Response Type

[`Task<Models.APIEntityCodeGeneration>`](../../doc/models/api-entity-code-generation.md)

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
Platforms template = Platforms.CSNETSTANDARDLIB;
try
{
    APIEntityCodeGeneration result = await codeGenerationImportedApisController.GenerateSDKAsync(
        apiEntityId,
        template
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Download SDK

Download the SDK generated via the Generate SDK endpoint.

```csharp
DownloadSDKAsync(
    string apiEntityId,
    string codegenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity for which the SDK was generated. |
| `codegenId` | `string` | Template, Required | The ID of code generation received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk). |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
string codegenId = "codegen_id6";
try
{
    Stream result = await codeGenerationImportedApisController.DownloadSDKAsync(
        apiEntityId,
        codegenId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# List All Code Generations Imported

Get a list of all SDK generations done against an API Version via the Generate SDK endpoint.

```csharp
ListAllCodeGenerationsImportedAsync(
    string apiEntityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity for which to list code generations. |

## Response Type

[`Task<List<Models.APIEntityCodeGeneration>>`](../../doc/models/api-entity-code-generation.md)

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
try
{
    List<APIEntityCodeGeneration> result = await codeGenerationImportedApisController.ListAllCodeGenerationsImportedAsync(apiEntityId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get a Code Generation Imported

Get details on an SDK generation performed via the Generate SDK endpoint.

```csharp
GetACodeGenerationImportedAsync(
    string apiEntityId,
    string codegenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to fetch the code generation for. |
| `codegenId` | `string` | Template, Required | The ID of the code generation to fetch. The code generation ID is received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk). |

## Response Type

[`Task<Models.APIEntityCodeGeneration>`](../../doc/models/api-entity-code-generation.md)

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
string codegenId = "codegen_id6";
try
{
    APIEntityCodeGeneration result = await codeGenerationImportedApisController.GetACodeGenerationImportedAsync(
        apiEntityId,
        codegenId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Code Generation

Delete an SDK generation performed for an API Version via the Generate SDK endpoint.

```csharp
DeleteCodeGenerationAsync(
    string apiEntityId,
    string codegenId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to delete the code generation for. |
| `codegenId` | `string` | Template, Required | The ID of the code generation to delete. The code generation ID is received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk). |

## Response Type

`Task`

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
string codegenId = "codegen_id6";
try
{
    await codeGenerationImportedApisController.DeleteCodeGenerationAsync(
        apiEntityId,
        codegenId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

