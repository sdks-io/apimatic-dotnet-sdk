
# Environment

An environment consists of a set of servers with base URL values. The environment can be changed programatically allowing rapid switching between different environments. For example the user can specify a Production and Testing Environment and switch between them in the generated SDK.

## Structure

`Environment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Unique Environment Identifier |
| `Name` | `string` | Required | Environment Name |
| `Servers` | [`List<Server>`](../../doc/models/server.md) | Required | The user can specify multiple servers within an environment. A server comprises of a name and a url. |

## Example (as JSON)

```json
{
  "id": "5be0a21a83b41d0d8cdcd832",
  "name": "production",
  "servers": [
    {
      "id": "5be0a21a83b41d0d8cdcd831",
      "name": "default",
      "url": "{defaultServerUrl}"
    }
  ]
}
```

