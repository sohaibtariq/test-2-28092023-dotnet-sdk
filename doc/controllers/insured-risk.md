# Insured-Risk

Insured Risk Management

```csharp
InsuredRiskController insuredRiskController = client.InsuredRiskController;
```

## Class Name

`InsuredRiskController`


# Post Insured Risk

Creates a new insured risk to then utilize when creating a policy.

```csharp
PostInsuredRiskAsync(
    Guid boostUser,
    Models.InsuredRisksRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `boostUser` | `Guid` | Header, Required | UUID that identifies the user. |
| `body` | [`InsuredRisksRequest`](../../doc/models/insured-risks-request.md) | Body, Required | - |

## Response Type

[`Task<Models.InsuredRisksResponse>`](../../doc/models/insured-risks-response.md)

## Example Usage

```csharp
Guid boostUser = new Guid("c336620b-4444-4a42-a2f1-643084046a01");
InsuredRisksRequest body = new InsuredRisksRequest
{
    Data = new Data
    {
        Type = "insured_risk",
        Attributes = new Attributes
        {
            Factors = ApiHelper.JsonDeserialize<object>("{\"foo\":\"bar\",\"baz\":true}"),
        },
        Relationships = new Relationships
        {
            Product = new Product
            {
                Data = new Data2
                {
                    Type = "product",
                    Id = new Guid("7c09a876-b53f-4939-b98d-a3630c936593"),
                },
            },
        },
    },
};

try
{
    InsuredRisksResponse result = await insuredRiskController.PostInsuredRiskAsync(
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
| 400 | Request is invalid. | [`InsuredRisks400Error1Exception`](../../doc/models/insured-risks-400-error-1-exception.md) |
| 401 | Unauthorized. The bearer authentication failed. | [`InsuredRisks401Error1Exception`](../../doc/models/insured-risks-401-error-1-exception.md) |
| 403 | Forbidden. The operation is not allowed. | [`InsuredRisks403Error1Exception`](../../doc/models/insured-risks-403-error-1-exception.md) |
| 415 | Unsupported Media Type. Only JSONAPI is supported. | [`InsuredRisks415Error1Exception`](../../doc/models/insured-risks-415-error-1-exception.md) |
| 500 | Internal Server Error. | [`InsuredRisks500Error1Exception`](../../doc/models/insured-risks-500-error-1-exception.md) |

