# APIs Management

```csharp
ApisManagementController apisManagementController = client.ApisManagementController;
```

## Class Name

`ApisManagementController`

## Methods

* [Import API Via File](../../doc/controllers/apis-management.md#import-api-via-file)
* [Import API Via URL](../../doc/controllers/apis-management.md#import-api-via-url)
* [Import New API Version Via File](../../doc/controllers/apis-management.md#import-new-api-version-via-file)
* [Import New API Version Via URL](../../doc/controllers/apis-management.md#import-new-api-version-via-url)
* [Inplace API Import Via File](../../doc/controllers/apis-management.md#inplace-api-import-via-file)
* [Inplace API Import Via URL](../../doc/controllers/apis-management.md#inplace-api-import-via-url)
* [Fetch API Entity](../../doc/controllers/apis-management.md#fetch-api-entity)
* [Download API Specification](../../doc/controllers/apis-management.md#download-api-specification)


# Import API Via File

Import an API into the APIMatic Dashboard by uploading the API specification file.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
ImportAPIViaFileAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |

## Response Type

[`Task<Models.ApiEntity>`](../../doc/models/api-entity.md)

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    ApiEntity result = await apisManagementController.ImportAPIViaFileAsync(file);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 412 | Precondition Failed | `ApiException` |
| 422 | Unprocessable Entity | `ApiException` |
| 500 | Internal Server Error | `ApiException` |


# Import API Via URL

Import an API into the APIMatic Dashboard by providing the URL of the API specification file.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
ImportAPIViaURLAsync(
    Models.ImportApiViaUrlRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ImportApiViaUrlRequest`](../../doc/models/import-api-via-url-request.md) | Body, Required | Request Body |

## Response Type

[`Task<Models.ApiEntity>`](../../doc/models/api-entity.md)

## Example Usage

```csharp
ImportApiViaUrlRequest body = new ImportApiViaUrlRequest
{
    Url = "https://petstore.swagger.io/v2/swagger.json",
};

try
{
    ApiEntity result = await apisManagementController.ImportAPIViaURLAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 412 | Precondition Failed | `ApiException` |
| 422 | Unprocessable Entity | `ApiException` |
| 500 | Internal Server Error | `ApiException` |


# Import New API Version Via File

Import a new version for an API, against an existing API Group, by uploading the API specification file.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
ImportNewAPIVersionViaFileAsync(
    string apiGroupId,
    string versionOverride,
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiGroupId` | `string` | Template, Required | The ID of the API Group for which to import a new API version. |
| `versionOverride` | `string` | Form, Required | The version number with which the new API version will be imported. This version number will override the version specified in the API specification file.<br>APIMatic recommends versioning the API with the [versioning scheme](https://docs.apimatic.io/define-apis/basic-settings/#version) documented in the docs. |
| `file` | `FileStreamInfo` | Form, Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |

## Response Type

[`Task<Models.ApiEntity>`](../../doc/models/api-entity.md)

## Example Usage

```csharp
string apiGroupId = "api_group_id6";
string versionOverride = "version_override2";
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    ApiEntity result = await apisManagementController.ImportNewAPIVersionViaFileAsync(
        apiGroupId,
        versionOverride,
        file
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Import New API Version Via URL

Import a new version for an API, against an existing API Group, by providing the URL of the API specification file.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
ImportNewAPIVersionViaURLAsync(
    string apiGroupId,
    Models.ImportApiVersionViaUrlRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiGroupId` | `string` | Template, Required | The ID of the API Group for which to import a new API version. |
| `body` | [`ImportApiVersionViaUrlRequest`](../../doc/models/import-api-version-via-url-request.md) | Body, Required | Request Body |

## Response Type

[`Task<Models.ApiEntity>`](../../doc/models/api-entity.md)

## Example Usage

```csharp
string apiGroupId = "5c9de181dc6209221416f250";
ImportApiVersionViaUrlRequest body = new ImportApiVersionViaUrlRequest
{
    VersionOverride = "1.2.3",
    Url = "https://petstore.swagger.io/v2/swagger.json",
};

try
{
    ApiEntity result = await apisManagementController.ImportNewAPIVersionViaURLAsync(
        apiGroupId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Inplace API Import Via File

Replace an API version of an API Group, by uploading the API specification file that will replace the current version.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
InplaceAPIImportViaFileAsync(
    string apiEntityId,
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to replace. |
| `file` | `FileStreamInfo` | Form, Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |

## Response Type

`Task`

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    await apisManagementController.InplaceAPIImportViaFileAsync(
        apiEntityId,
        file
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Inplace API Import Via URL

Replace an API version of an API Group, by providing the URL of the API specification file that will replace the current version.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
InplaceAPIImportViaURLAsync(
    string apiEntityId,
    Models.InplaceImportApiViaUrlRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to replace. |
| `body` | [`InplaceImportApiViaUrlRequest`](../../doc/models/inplace-import-api-via-url-request.md) | Body, Required | Request Body |

## Response Type

`Task`

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
InplaceImportApiViaUrlRequest body = new InplaceImportApiViaUrlRequest
{
    Url = "https://petstore.swagger.io/v2/swagger.json",
};

try
{
    await apisManagementController.InplaceAPIImportViaURLAsync(
        apiEntityId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch API Entity

Fetch an API Entity.

```csharp
FetchAPIEntityAsync(
    string apiEntityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to fetch. |

## Response Type

[`Task<Models.ApiEntity>`](../../doc/models/api-entity.md)

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
try
{
    ApiEntity result = await apisManagementController.FetchAPIEntityAsync(apiEntityId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Download API Specification

Download the API Specification file for a an API Version in any of the API Specification formats supported by APIMatic.

```csharp
DownloadAPISpecificationAsync(
    string apiEntityId,
    Models.ExportFormats format)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to download. |
| `format` | [`ExportFormats`](../../doc/models/export-formats.md) | Query, Required | The format in which to download the API.<br>The format can be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string apiEntityId = "api_entity_id4";
ExportFormats format = ExportFormats.APIMATIC;
try
{
    Stream result = await apisManagementController.DownloadAPISpecificationAsync(
        apiEntityId,
        format
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

