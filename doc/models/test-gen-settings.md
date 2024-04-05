
# Test Gen Settings

This structure helps specify additional test configurations which affects how test cases are generated.

## Structure

`TestGenSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrecisionDelta` | `double` | Required | Error margin for comparing values in decimal places |
| `TestTimeout` | `int` | Required | Number of seconds after which if the endpoint is not returning any response, the test is forced to fail e.g. a timeout of 60 |
| `Configuration` | `object` | Required | The parameters allows to provide values for configuration file for use in the test environment |

## Example (as JSON)

```json
{
  "precisionDelta": 0.01,
  "testTimeout": 30,
  "configuration": {}
}
```

