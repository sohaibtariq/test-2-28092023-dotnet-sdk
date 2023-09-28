
# Auth Oauth 2 Token Response

## Structure

`AuthOauth2TokenResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TokenType` | [`TokenTypeEnum?`](../../doc/models/token-type-enum.md) | Optional | Type of token. |
| `AccessToken` | `string` | Optional | The token to be used in future API calls. |
| `ExpiresIn` | [`ExpiresInEnum?`](../../doc/models/expires-in-enum.md) | Optional | How long this token is valid for. |

## Example (as JSON)

```json
{
  "token_type": "bearer",
  "access_token": "JDKSjkdnasknxkasjd",
  "expires_in": 7200
}
```

