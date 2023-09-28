# Policy

Policy Management

```csharp
PolicyController policyController = client.PolicyController;
```

## Class Name

`PolicyController`

## Methods

* [List Policies](../../doc/controllers/policy.md#list-policies)
* [Post Policy](../../doc/controllers/policy.md#post-policy)


# List Policies

List previously created policies

```csharp
ListPoliciesAsync(
    Guid boostUser,
    Models.ContentType1Enum? accept = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `boostUser` | `Guid` | Header, Required | UUID that identifies the user. |
| `accept` | [`ContentType1Enum?`](../../doc/models/content-type-1-enum.md) | Header, Optional | Header to indicate that desired response type is JSON:API. |

## Response Type

[`Task<Models.PoliciesResponse1>`](../../doc/models/policies-response-1.md)

## Example Usage

```csharp
Guid boostUser = new Guid("53f85c54-f471-444d-80a7-9feb1951ff46");
try
{
    PoliciesResponse1 result = await policyController.ListPoliciesAsync(boostUser);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Post Policy

Issues a new policy with the given the input data. Policy goes in force on the specified effective_date.

```csharp
PostPolicyAsync(
    Guid boostUser,
    Models.PoliciesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `boostUser` | `Guid` | Header, Required | UUID that identifies the user. |
| `body` | [`PoliciesRequest`](../../doc/models/policies-request.md) | Body, Required | - |

## Response Type

[`Task<Models.PoliciesResponse>`](../../doc/models/policies-response.md)

## Example Usage

```csharp
Guid boostUser = new Guid("53f85c54-f471-444d-80a7-9feb1951ff46");
PoliciesRequest body = new PoliciesRequest
{
    Data = new Data6
    {
        Type = "policy",
        Attributes = new Attributes2
        {
            QuoteNumber = "BLU-XX-T63XWYHFE",
            InstallmentPlan = "ANNUAL",
            StripeToken = "tok_mastercard",
            ExternalId = "1234567890",
        },
        Relationships = new Relationships2
        {
        },
    },
};

try
{
    PoliciesResponse result = await policyController.PostPolicyAsync(
        boostUser,
        body
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
| 400 | Request is invalid. | [`Policies400Error1Exception`](../../doc/models/policies-400-error-1-exception.md) |
| 401 | Unauthorized. The bearer authentication failed. | [`Policies401Error1Exception`](../../doc/models/policies-401-error-1-exception.md) |
| 403 | Forbidden. The operation is not allowed. | [`Policies403Error1Exception`](../../doc/models/policies-403-error-1-exception.md) |
| 500 | Internal Server Error. | [`Policies500Error1Exception`](../../doc/models/policies-500-error-1-exception.md) |

