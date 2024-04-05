# Transformation

```csharp
TransformationController transformationController = client.TransformationController;
```

## Class Name

`TransformationController`

## Methods

* [Transform Via File](../../doc/controllers/transformation.md#transform-via-file)
* [Transform Via URL](../../doc/controllers/transformation.md#transform-via-url)
* [Download Transformed File](../../doc/controllers/transformation.md#download-transformed-file)
* [Download Input File Transformation](../../doc/controllers/transformation.md#download-input-file-transformation)
* [List All Transformations](../../doc/controllers/transformation.md#list-all-transformations)
* [Get a Transformation](../../doc/controllers/transformation.md#get-a-transformation)
* [Delete Transformation](../../doc/controllers/transformation.md#delete-transformation)


# Transform Via File

Transform an API into any of the supported API specification formats by uploading the API specification file. This endpoint transforms and then uploads the transformed API specification to APIMatic's cloud storage. An ID for the transformation performed is returned as part of the response.

```csharp
TransformViaFileAsync(
    FileStreamInfo file,
    Models.ExportFormats exportFormat)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |
| `exportFormat` | [`ExportFormats`](../../doc/models/export-formats.md) | Form, Required | The structure contains API specification formats that Transformer can convert to. |

## Response Type

[`Task<Models.Transformation>`](../../doc/models/transformation.md)

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
ExportFormats exportFormat = ExportFormats.WSDL;
try
{
    Transformation result = await transformationController.TransformViaFileAsync(
        file,
        exportFormat
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Transform Via URL

Transform an API into any of the supported API specification formats by providing the URL of the API specification file.

This endpoint transforms and then uploads the transformed API specification to APIMatic's cloud storage. An ID for the transformation performed is returned as part of the response.

```csharp
TransformViaURLAsync(
    Models.TransformViaUrlRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`TransformViaUrlRequest`](../../doc/models/transform-via-url-request.md) | Body, Required | Request Body |

## Response Type

[`Task<Models.Transformation>`](../../doc/models/transformation.md)

## Example Usage

```csharp
TransformViaUrlRequest body = new TransformViaUrlRequest
{
    Url = "https://petstore.swagger.io/v2/swagger.json",
    ExportFormat = ExportFormats.APIMATIC,
};

try
{
    Transformation result = await transformationController.TransformViaURLAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Download Transformed File

Download the transformed API specification file transformed via the Transformation endpoints.

```csharp
DownloadTransformedFileAsync(
    string transformationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transformationId` | `string` | Template, Required | The ID of transformation received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL  ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls. |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string transformationId = "transformation_id6";
try
{
    Stream result = await transformationController.DownloadTransformedFileAsync(transformationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Download Input File Transformation

Download the API Specification file used as input for a particular Transformation performed via the Transformation endpoints.

```csharp
DownloadInputFileTransformationAsync(
    string transformationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transformationId` | `string` | Template, Required | The ID of the transformation to download the API specification for. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls. |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string transformationId = "transformation_id6";
try
{
    Stream result = await transformationController.DownloadInputFileTransformationAsync(transformationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# List All Transformations

Get a list of all API transformations performed.

```csharp
ListAllTransformationsAsync()
```

## Response Type

[`Task<List<Models.Transformation>>`](../../doc/models/transformation.md)

## Example Usage

```csharp
try
{
    List<Transformation> result = await transformationController.ListAllTransformationsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get a Transformation

Get details on a particular Transformation performed via the Transformation endpoints.

```csharp
GetATransformationAsync(
    string transformationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transformationId` | `string` | Template, Required | The ID of the transformation to fetch. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL  ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls. |

## Response Type

[`Task<Models.Transformation>`](../../doc/models/transformation.md)

## Example Usage

```csharp
string transformationId = "transformation_id6";
try
{
    Transformation result = await transformationController.GetATransformationAsync(transformationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Transformation

Delete a particular Transformation performed for an API via the Transformation endpoints.

```csharp
DeleteTransformationAsync(
    string transformationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transformationId` | `string` | Template, Required | The ID of the transformation to delete. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls. |

## Response Type

`Task`

## Example Usage

```csharp
string transformationId = "transformation_id6";
try
{
    await transformationController.DeleteTransformationAsync(transformationId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

