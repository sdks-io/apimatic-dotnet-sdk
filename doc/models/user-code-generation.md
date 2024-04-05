
# User Code Generation

The Code Generation structure encapsulates all the  the details of an SDK generation performed by a user.

## Structure

`UserCodeGeneration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Unique Code Generation Identifier |
| `Template` | [`Platforms`](../../doc/models/platforms.md) | Required | The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in.<br>**Default**: `Platforms.CS_NET_STANDARD_LIB` |
| `GeneratedFile` | `string` | Required | The generated SDK |
| `GeneratedOn` | `DateTime` | Required | Generation Date and Time |
| `HashCode` | `string` | Required | The md5 hash of the API Description |
| `CodeGenerationSource` | `string` | Required | Generation Source |
| `CodeGenVersion` | `string` | Required | Generation Version |
| `Success` | `bool` | Required | Generation Status |
| `UserId` | `string` | Required | Unique User Identifier |
| `InputFile` | `string` | Required | API Specification file in a supported format |

## Example (as JSON)

```json
{
  "id": "5be08b2d83b41d0d8cdb3289",
  "template": "CS_NET_STANDARD_LIB",
  "generatedFile": "https://api.apimatic.io/code-generations/5be08b2d83b41d0d8cdb3289/generated-sdk",
  "generatedOn": "04/03/2024 15:46:32",
  "hashCode": "77BDA4F625EF512B336D0A77CE2BB2B6",
  "codeGenerationSource": "Api",
  "codeGenVersion": "1",
  "success": true,
  "userId": "5afc60380b9949253c6b7776",
  "inputFile": "https://api.apimatic.io/code-generations/5be08d7b83b41d0d8cdb3958/input-file"
}
```

