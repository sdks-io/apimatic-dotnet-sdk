# API Validation-External APIs

```csharp
APIValidationExternalApisController aPIValidationExternalApisController = client.APIValidationExternalApisController;
```

## Class Name

`APIValidationExternalApisController`

## Methods

* [Validate API Via File](../../doc/controllers/api-validation-external-apis.md#validate-api-via-file)
* [Validate API Via URL](../../doc/controllers/api-validation-external-apis.md#validate-api-via-url)


# Validate API Via File

Validate an API by uploading the API specification file.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while validating the API using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
ValidateAPIViaFileAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |

## Response Type

[`Task<Models.ApiValidationSummary>`](../../doc/models/api-validation-summary.md)

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    ApiValidationSummary result = await aPIValidationExternalApisController.ValidateAPIViaFileAsync(file);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "success": true,
  "errors": [],
  "warnings": [
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getRealTimeData</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getRealTimeData</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getDataPerCategory</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getDataPerCategory</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getData</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getData</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getActiveStatuses</code></i> of group <i><code>statuses</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getActiveStatuses</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>200</code></i> in endpoint <i><code>getDevices</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>deviceModelId</code></i>, <i><code>manufacturer</code></i>, <i><code>model</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getDevices</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getDevices</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getAlarms</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getAlarms</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getActiveAlerts</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getActiveAlerts</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getAlerts</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getAlerts</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getConfiguration</code></i> of group <i><code>configuration data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getConfiguration</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getActiveAlarms</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getActiveAlarms</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getPowerCurves</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getPowerCurves</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getDataSignals</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getDataSignals</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getStatuses</code></i> of group <i><code>statuses</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getStatuses</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getSites</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getSites</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>."
  ],
  "messages": [
    "One or more elements in the API specification has a missing description field."
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 401 | Unauthenticated | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 500 | Internal Server Error | `ApiException` |


# Validate API Via URL

Validate an API by providing the URL of the API specification file.

You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while validating the API using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.

```csharp
ValidateAPIViaURLAsync(
    string descriptionUrl)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `descriptionUrl` | `string` | Query, Required | The URL for the API specification file.<br><br>**Note:** This URL should be publicly accessible. |

## Response Type

[`Task<Models.ApiValidationSummary>`](../../doc/models/api-validation-summary.md)

## Example Usage

```csharp
string descriptionUrl = "https://petstore.swagger.io/v2/swagger.json";
try
{
    ApiValidationSummary result = await aPIValidationExternalApisController.ValidateAPIViaURLAsync(descriptionUrl);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "success": true,
  "errors": [],
  "warnings": [
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getRealTimeData</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getRealTimeData</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getDataPerCategory</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getDataPerCategory</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getData</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getData</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getActiveStatuses</code></i> of group <i><code>statuses</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getActiveStatuses</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>200</code></i> in endpoint <i><code>getDevices</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>deviceModelId</code></i>, <i><code>manufacturer</code></i>, <i><code>model</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getDevices</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getDevices</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getAlarms</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getAlarms</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getActiveAlerts</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getActiveAlerts</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getAlerts</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getAlerts</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getConfiguration</code></i> of group <i><code>configuration data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getConfiguration</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getActiveAlarms</code></i> of group <i><code>alerts</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getActiveAlarms</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getPowerCurves</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getPowerCurves</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getDataSignals</code></i> of group <i><code>data</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getDataSignals</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getStatuses</code></i> of group <i><code>statuses</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getStatuses</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>.",
    "Media type <i><code>application/json; charset=utf-8</code></i> content definition of response code <i><code>429</code></i> in endpoint <i><code>getSites</code></i> of group <i><code>assets</code></i> contains an example value with following undeclared fields: <i><code>detail</i></code>.",
    "Endpoint <i><code>getSites</code></i> has an example specified for error code <i><code>429</code></i> which contains following undeclared fields: <i><code>detail</i></code>."
  ],
  "messages": [
    "One or more elements in the API specification has a missing description field."
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | `ApiException` |
| 401 | Unauthenticated | `ApiException` |
| 403 | Forbidden | `ApiException` |
| 500 | Internal Server Error | `ApiException` |

