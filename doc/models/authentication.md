
# Authentication

This Structure encapsulates all details of API authentication.

## Structure

`Authentication`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Auth Id |
| `AuthType` | `string` | Required | Auth Type |
| `Scopes` | [`List<AuthScope>`](../../doc/models/auth-scope.md) | Required | Scope |
| `Parameters` | `List<string>` | Required | Auth Params |
| `AuthScopes` | `List<string>` | Required | Auth Scopes |
| `AuthGrantTypes` | `List<string>` | Required | Auth Grant Types |
| `ParamFormats` | `object` | Required | Paramater Formats |

## Example (as JSON)

```json
{
  "id": "5be0a21a83b41d0d8cdcd80f",
  "authType": "None",
  "scopes": [],
  "parameters": [],
  "authScopes": [],
  "authGrantTypes": [],
  "paramFormats": {}
}
```

