
# Parameter

Parameters are options passed with the endpoint

## Structure

`Parameter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Optional` | `bool` | Required | If parameter is optional |
| `Type` | `string` | Required | Type of Parameter |
| `Constant` | `bool` | Required | IF Parameter is constant |
| `IsArray` | `bool` | Required | If Param is collected as array |
| `IsStream` | `bool` | Required | - |
| `IsAttribute` | `bool` | Required | - |
| `IsMap` | `bool` | Required | - |
| `Attributes` | [`Attributes`](../../doc/models/attributes.md) | Required | The structure contain attribute details of a parameter type. |
| `Nullable` | `bool` | Required | If Parameter is nullable |
| `Id` | `string` | Required | Unique Parameter identifier |
| `Name` | `string` | Required | Parameter Name |
| `Description` | `string` | Required | Parameter Description |
| `DefaultValue` | `string` | Required | Default Values of a Parameter |
| `ParamFormat` | `string` | Required | Specify Parameter Format |

## Example (as JSON)

```json
{
  "optional": false,
  "type": "test\\r\\nstringEncoding",
  "constant": false,
  "isArray": false,
  "isStream": false,
  "isAttribute": false,
  "isMap": false,
  "attributes": {
    "id": "5be1603083b41d0b50110551"
  },
  "nullable": false,
  "id": "5a4e8675b724bb198c289f7a",
  "name": "body",
  "description": "description8",
  "defaultValue": "defaultValue4",
  "ParamFormat": "Body"
}
```

