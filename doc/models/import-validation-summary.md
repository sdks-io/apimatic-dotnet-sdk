
# Import Validation Summary

## Structure

`ImportValidationSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Success` | `bool` | Required | - |
| `Errors` | `List<string>` | Required | - |
| `Warnings` | `List<string>` | Required | - |
| `Messages` | `List<string>` | Required | - |

## Example (as JSON)

```json
{
  "success": true,
  "errors": [],
  "warnings": [],
  "messages": [
    "One or more elements in the API specification has a missing description field."
  ]
}
```

