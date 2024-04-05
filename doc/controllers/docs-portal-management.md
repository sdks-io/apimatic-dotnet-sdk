# Docs Portal Management

```csharp
DocsPortalManagementController docsPortalManagementController = client.DocsPortalManagementController;
```

## Class Name

`DocsPortalManagementController`

## Methods

* [Publish Hosted Portal](../../doc/controllers/docs-portal-management.md#publish-hosted-portal)
* [Publish Embedded Portal](../../doc/controllers/docs-portal-management.md#publish-embedded-portal)
* [Generate On-Prem Portal Via API Entity](../../doc/controllers/docs-portal-management.md#generate-on-prem-portal-via-api-entity)
* [Generate On-Prem Portal Via Build Input](../../doc/controllers/docs-portal-management.md#generate-on-prem-portal-via-build-input)
* [Generate Build Input for Unpublished Portal](../../doc/controllers/docs-portal-management.md#generate-build-input-for-unpublished-portal)
* [Generate Build Input for Published Portal](../../doc/controllers/docs-portal-management.md#generate-build-input-for-published-portal)
* [Unpublish Portal](../../doc/controllers/docs-portal-management.md#unpublish-portal)


# Publish Hosted Portal

Publish artifacts for a Hosted Portal.

This endpoint regenerates all the artifacts for a hosted portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:

1. SDKs
2. Docs
3. API Specification files

Call this endpoint to update your Hosted Portal after you update an API Entity via any of the Import API Endpoints.

__**Note: If you have an embedded portal against the same API Entity, artifacts for that portal will get updated as well.**__

```csharp
PublishHostedPortalAsync(
    string apiEntityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to update the portal artifacts for. |

## Response Type

`Task`

## Example Usage

```csharp
string apiEntityId = "5f87f8ab9615d38a2eb990ca";
try
{
    await docsPortalManagementController.PublishHostedPortalAsync(apiEntityId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Publish Embedded Portal

Publish artifacts for an Embedded Portal and get the Portal Embed script.

This endpoint regenerates all the artifacts for an embedded portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:

1. SDKs
2. Docs
3. API Specification files

Call this endpoint to update your Embedded Portal after you update an API Entity via any of the Import API Endpoints. This endpoint returns the Portal Embed script in the response.

__**Note: If you have a hosted portal against the same API Entity, artifacts for that portal will get updated as well.**__

```csharp
PublishEmbeddedPortalAsync(
    string apiEntityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to update the portal artifacts for. |

## Response Type

`Task`

## Example Usage

```csharp
string apiEntityId = "5f87f8ab9615d38a2eb990ca";
try
{
    await docsPortalManagementController.PublishEmbeddedPortalAsync(apiEntityId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Generate On-Prem Portal Via API Entity

Generate an On-premise Documentation Portal for an API Entity. This endpoint generates all artifacts for the Portal and packages them together into a zip file along with the required HTML, CSS and JS files. The generated artifacts include:

1. SDKs
2. Docs
3. API Specification files

The endpoint returns a zip file that contains a static Site and can be hosted on any Web Server.

```csharp
GenerateOnPremPortalViaAPIEntityAsync(
    string apiEntityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to generate the Portal for. |

## Response Type

`Task`

## Example Usage

```csharp
string apiEntityId = "5f87f8ab9615d38a2eb990ca";
try
{
    await docsPortalManagementController.GenerateOnPremPortalViaAPIEntityAsync(apiEntityId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Generate On-Prem Portal Via Build Input

Generate an On-premise Documentation Portal by uploading a Portal Build Input. This endpoint generates all artifacts for the Portal and packages them together into a zip file along with the required HTML, CSS and JS files. The generated artifacts include:

1. SDKs
2. Docs
3. API Specification files

The endpoint returns a zip file that contains a static Site and can be hosted on any Web Server.

```csharp
GenerateOnPremPortalViaBuildInputAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | The input file to the Portal Generator. Must contain the build file. |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    Stream result = await docsPortalManagementController.GenerateOnPremPortalViaBuildInputAsync(file);
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
| 401 | Unauthorized | `ApiException` |
| 402 | Subscription Issue | `ApiException` |
| 422 | Unprocessable Entity | `ApiException` |


# Generate Build Input for Unpublished Portal

Generate Build Input for a Portal created using the UI workflow.  The Build Input will correspond to the draft version of the Portal i.e. unpublished changes will also be included.
This can be used to create a backup of your Portal or to migrate from the UI workflow to the docs as code workflow.

```csharp
GenerateBuildInputForUnpublishedPortalAsync(
    string apiGroupId,
    List<string> apiEntities = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiGroupId` | `string` | Template, Required | - |
| `apiEntities` | `List<string>` | Query, Optional | - |

## Response Type

`Task<string>`

## Example Usage

```csharp
string apiGroupId = "apiGroupId8";
try
{
    string result = await docsPortalManagementController.GenerateBuildInputForUnpublishedPortalAsync(apiGroupId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Generate Build Input for Published Portal

Generate Build Input for a Portal created using the UI workflow.  The Build Input will correspond to the published version of the Portal i.e. unpublished changes will not be inlcuded.
This can be used to create a backup of your Portal or to migrate from the UI workflow to the docs as code workflow.

```csharp
GenerateBuildInputForPublishedPortalAsync(
    string apiGroupId,
    List<string> apiEntities = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiGroupId` | `string` | Template, Required | - |
| `apiEntities` | `List<string>` | Query, Optional | - |

## Response Type

`Task<string>`

## Example Usage

```csharp
string apiGroupId = "apiGroupId8";
try
{
    string result = await docsPortalManagementController.GenerateBuildInputForPublishedPortalAsync(apiGroupId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Unpublish Portal

Unpublish a Hosted or Embedded Portal published for an API Entity. Calling this endpoint deletes all the published artifacts for a Portal from APIMatic's cloud storage.

In case of a Hosted Portal, to completely remove the Portal, this endpoint needs to be called against all API versions that the Portal hosts.

In case of an Embedded Portal, to completely remove the Portal, the user needs to manually remove the Portal Embed script from the embedding site.

```csharp
UnpublishPortalAsync(
    string apiEntityId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiEntityId` | `string` | Template, Required | The ID of the API Entity to unpublish the Portal artifacts for. |

## Response Type

`Task`

## Example Usage

```csharp
string apiEntityId = "5f87f8ab9615d38a2eb990ca";
try
{
    await docsPortalManagementController.UnpublishPortalAsync(apiEntityId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

