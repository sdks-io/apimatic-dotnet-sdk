
# Custom Header Signature



Documentation for accessing and setting credentials for Authorization.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| Authorization | `string` | Auth Header. Provide your Auth key in the format `X-Auth-Key {auth-key}`. | `Authorization` | `Authorization` |



**Note:** Auth credentials can be set using `CustomHeaderAuthenticationCredentials` in the client builder and accessed through `CustomHeaderAuthenticationCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
ApimaticAPI.Standard.ApimaticAPIClient client = new ApimaticAPI.Standard.ApimaticAPIClient.Builder()
    .CustomHeaderAuthenticationCredentials(
        new CustomHeaderAuthenticationModel.Builder(
            "Authorization"
        )
        .Build())
    .Build();
```


