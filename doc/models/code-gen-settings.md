
# Code Gen Settings

APIMatic’s code generation engine has various code generation configurations to customise the behaviour and outlook across the generated SDKS. This structure encapsulates all settings for CodeGeneration.

## Structure

`CodeGenSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IsAsync` | `bool` | Required | Generate asynchronous code for API Calls and deserialization |
| `UseHttpMethodPrefix` | `bool` | Required | Use HTTP Method prefixes for endpoint wrappers |
| `UseModelPrefix` | `bool` | Required | Use "Model" postfixes for generated class names |
| `UseEnumPrefix` | `bool` | Required | Use "Enum" postfixes for enumerated types |
| `UseConstructorsForConfig` | `bool` | Required | - |
| `UseCommonSdkLibrary` | `bool` | Required | Use common SDK library to reduce code duplication |
| `GenerateInterfaces` | `bool` | Required | Generates interfaces for controller classes in the generated SDKs |
| `GenerateAppveyorConfig` | `bool` | Required | Generate Appveyor configuration file |
| `GenerateCircleConfig` | `bool` | Required | Generate CircleCI configuration file |
| `GenerateJenkinsConfig` | `bool` | Required | Generate Jenkins configuration file |
| `GenerateTravisConfig` | `bool` | Required | Generate Travis CI configuration file |
| `AndroidUseAppManifest` | `bool` | Required | Use "AndroidManifest.xml" for config variables in Android |
| `IosUseAppInfoPlist` | `bool` | Required | Use "App-Info.plist" file for config variables in iOS |
| `IosGenerateCoreData` | `bool` | Required | Generate "CoreData" schema and entity classes in iOS? |
| `RunscopeEnabled` | `bool` | Required | Enable runscope |
| `CollapseParamsToArray` | `bool` | Required | Collect Parameters as arrays |
| `PreserveParameterOrder` | `bool` | Required | Attempts to preserve parameter order for endpoints |
| `AppendContentHeaders` | `bool` | Required | Append JSON/XML accept and content-type headers |
| `ModelSerializationIsJSON` | `bool` | Required | - |
| `Nullify404` | `bool` | Required | Return a null value on HTTP 404 |
| `ValidateRequiredParameters` | `bool` | Required | Validate required parameters to be Not Null |
| `EnableAdditionalModelProperties` | `bool` | Required | Allow models to have additional runtime properties |
| `JavaUsePropertiesConfig` | `bool` | Required | - |
| `UseControllerPrefix` | `bool` | Required | Use "Controller" postfixes for generated controller classes |
| `UseExceptionPrefix` | `bool` | Required | Use Exception Prefixes |
| `ParameterArrayFormat` | `string` | Required | Parameter Array format with index or without |
| `ObjCHttpClient` | `string` | Required | Configure the HTTP client for Objective C |
| `CSharpHttpClient` | `string` | Required | Configure the HTTP client for C# |
| `AndroidHttpClient` | `string` | Required | Configure the HTTP client for  Android |
| `NodeHttpClient` | `string` | Required | Configure the HTTP client for node |
| `PhpHttpClient` | `string` | Required | Configure the HTTP client for PHP |
| `BodySerialization` | `int` | Required | - |
| `ArraySerialization` | `string` | Required | Specify type of array serialisation |
| `Timeout` | `int` | Required | This option specifies the duration (in seconds) after which requests would timeout |
| `EnableLogging` | `bool` | Required | Enabling this generates code in the SDKs for logging events in the API cycle using a library. |
| `EnableHttpCache` | `bool` | Required | Enabling caching of responses (not available in all languages) |
| `Retries` | `int` | Required | Specify number of retries |
| `RetryInterval` | `int` | Required | Specify retry interval in case of failures |
| `GenerateAdvancedDocs` | `bool` | Required | Generate advanced read me files |
| `StoreTimezoneInformation` | `bool` | Required | Store Timezone information for the generation |
| `EnablePhpComposerVersionString` | `bool` | Required | Use "Controller" postfixes for generated controller classes |
| `SecurityProtocols` | `List<string>` | Required | Specify Security Protocols |
| `UnderscoreNumbers` | `bool` | Required | Use underscores before and after numbers for underscore case |
| `UseSingletonPattern` | `bool` | Required | Allow usage of a Singleton Pattern |
| `DisableLinting` | `bool` | Required | Files/dependencies used for linting are not generated if this option is enabled |
| `AllowSkippingSSLCertVerification` | `bool` | Required | Create a configuration option in SDKs to optionally skip certificate verification when establishing HTTPS connections. |
| `ApplyCustomizations` | `List<string>` | Required | Apply Customisations |
| `DoNotSplitWords` | `List<string>` | Required | Enabling this will stop splitting of words when converting identifiers from API specification to language-specific identifiers. |
| `SortResources` | `bool` | Required | Sorts resources such as endpoints, endpoint groups and models in generated documentation |
| `EnableGlobalUserAgent` | `bool` | Required | Enable a global user agent |

## Example (as JSON)

```json
{
  "isAsync": true,
  "useHttpMethodPrefix": true,
  "useModelPrefix": false,
  "useEnumPrefix": true,
  "useConstructorsForConfig": false,
  "useCommonSdkLibrary": false,
  "generateInterfaces": false,
  "generateAppveyorConfig": false,
  "generateCircleConfig": false,
  "generateJenkinsConfig": false,
  "generateTravisConfig": false,
  "androidUseAppManifest": false,
  "iosUseAppInfoPlist": false,
  "iosGenerateCoreData": false,
  "runscopeEnabled": false,
  "collapseParamsToArray": false,
  "preserveParameterOrder": true,
  "appendContentHeaders": true,
  "modelSerializationIsJSON": true,
  "nullify404": false,
  "validateRequiredParameters": false,
  "enableAdditionalModelProperties": false,
  "javaUsePropertiesConfig": false,
  "useControllerPrefix": true,
  "useExceptionPrefix": true,
  "parameterArrayFormat": "ParamArrayWithIndex",
  "objCHttpClient": "UNIREST",
  "cSharpHttpClient": "UNIREST",
  "androidHttpClient": "ANDROID_OK",
  "nodeHttpClient": "NODE_REQUEST",
  "phpHttpClient": "UNIREST",
  "bodySerialization": 0,
  "arraySerialization": "Indexed",
  "timeout": 0,
  "enableLogging": false,
  "enableHttpCache": false,
  "retries": 0,
  "retryInterval": 1,
  "generateAdvancedDocs": true,
  "storeTimezoneInformation": false,
  "enablePhpComposerVersionString": false,
  "securityProtocols": [
    "Ssl3",
    "Tls"
  ],
  "underscoreNumbers": true,
  "useSingletonPattern": true,
  "disableLinting": false,
  "allowSkippingSSLCertVerification": false,
  "applyCustomizations": [],
  "doNotSplitWords": [],
  "sortResources": false,
  "enableGlobalUserAgent": true
}
```

