# Authentication

```csharp
AuthenticationController authenticationController = client.AuthenticationController;
```

## Class Name

`AuthenticationController`


# Get O Auth Token

Generates an access token which must be used on all subsequent API calls.

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetOAuthTokenAsync(
    string clientId,
    string clientSecret)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `clientId` | `string` | Form, Required | Your Client ID |
| `clientSecret` | `string` | Form, Required | Your Client Secret |

## Response Type

[`Task<Models.AuthOauth2TokenResponse>`](../../doc/models/auth-oauth-2-token-response.md)

## Example Usage

```csharp
string clientId = "client_id8";
string clientSecret = "client_secret8";
try
{
    AuthOauth2TokenResponse result = await authenticationController.GetOAuthTokenAsync(
        clientId,
        clientSecret
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Request is invalid | [`AuthOauth2Token400Error1Exception`](../../doc/models/auth-oauth-2-token-400-error-1-exception.md) |
| 500 | Internal Server Error | `ApiException` |

