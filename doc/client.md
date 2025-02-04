
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `CustomHeaderAuthenticationCredentials` | [`CustomHeaderAuthenticationCredentials`]($a/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
ApimaticAPI.Standard.ApimaticAPIClient client = new ApimaticAPI.Standard.ApimaticAPIClient.Builder()
    .CustomHeaderAuthenticationCredentials(
        new CustomHeaderAuthenticationModel.Builder(
            "Authorization"
        )
        .Build())
    .Build();
```

## Apimatic APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| ApisManagementController | Gets ApisManagementController controller. |
| CodeGenerationImportedApisController | Gets CodeGenerationImportedApisController controller. |
| CodeGenerationExternalApisController | Gets CodeGenerationExternalApisController controller. |
| TransformationController | Gets TransformationController controller. |
| DocsPortalManagementController | Gets DocsPortalManagementController controller. |
| APIValidationImportedApisController | Gets APIValidationImportedApisController controller. |
| APIValidationExternalApisController | Gets APIValidationExternalApisController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| CustomHeaderAuthenticationCredentials | Gets the credentials to use with CustomHeaderAuthentication. | [`ICustomHeaderAuthenticationCredentials`]($a/custom-header-signature.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Apimatic APIClient using the values provided for the builder. | `Builder` |

## Apimatic APIClient Builder Class

Class to build instances of Apimatic APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `CustomHeaderAuthenticationCredentials(Action<CustomHeaderAuthenticationModel.Builder> action)` | Sets credentials for CustomHeaderAuthentication. | `Builder` |

