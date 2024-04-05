
# Transform Via File Request Body

## Structure

`TransformViaFileRequestBody`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `File` | `Stream` | Required | The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats). |
| `ExportFormat` | [`ExportFormats`](../../doc/models/export-formats.md) | Required | The structure contains API specification formats that Transformer can convert to. |

## Example (as JSON)

```json
{
  "file": "file2",
  "export_format": "APIMATIC"
}
```

