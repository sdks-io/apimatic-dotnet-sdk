
# Import New API Version Via File Request Body

## Structure

`ImportNewAPIVersionViaFileRequestBody`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VersionOverride` | `string` | Required | The version number with which the new API version will be imported. This version number will override the version specified in the API specification file.<br>APIMatic recommends versioning the API with the [versioning scheme](https://docs.apimatic.io/define-apis/basic-settings/#version) documented in the docs. |
| `File` | `Stream` | Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |

## Example (as JSON)

```json
{
  "version_override": "version_override4",
  "file": "file8"
}
```

