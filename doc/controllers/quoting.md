# Quoting

Quote Management

```csharp
QuotingController quotingController = client.QuotingController;
```

## Class Name

`QuotingController`


# Post Quote

Issues a new quote.

```csharp
PostQuoteAsync(
    Guid boostUser,
    Models.QuotesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `boostUser` | `Guid` | Header, Required | Boost provided agent UUID that identifies the user. |
| `body` | [`QuotesRequest`](../../doc/models/quotes-request.md) | Body, Required | - |

## Response Type

[`Task<Models.QuotesResponse>`](../../doc/models/quotes-response.md)

## Example Usage

```csharp
Guid boostUser = new Guid("0aa54c55-7890-abcd-1234-789012345678");
QuotesRequest body = new QuotesRequest
{
    Data = new Data39
    {
        Type = "quote",
        Attributes = new Attributes9
        {
            PolicyState = PolicyState2Enum.AZ,
            EffectiveDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            TermEndDate = DateTime.ParseExact("08/01/2018 00:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Limit = "1000",
            Deductible = "1000",
            ExternalReference = "000000001",
            BindableOn = DateTime.ParseExact("08/01/2018 00:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            TermPremium = "123.45",
            ValidUntil = DateTime.ParseExact("08/01/2018 00:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ConvertableOn = DateTime.ParseExact("08/01/2018 00:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            ConvertedOn = DateTime.ParseExact("08/01/2018 00:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Status = Status2Enum.Draft,
            MinPremium = "12.34",
            StateTax = "12.34",
            StateFees = "12.34",
            ServiceFees = "12.34",
            BillingFees = "12.34",
        },
        Relationships = new Relationships9
        {
            Customer = new Customer2
            {
                Data = new Data41
                {
                    Type = "customer",
                    Lid = "2",
                },
            },
            Product = new Product6
            {
                Data = new Data43
                {
                    Type = "product",
                    Id = new Guid("d64d47eb-c7a6-4128-985b-0ecc79284608"),
                },
            },
        },
    },
    Included = new List<object>
    {
        ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
};

try
{
    QuotesResponse result = await quotingController.PostQuoteAsync(
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
| 400 | Request is invalid. | [`Quotes400Error1Exception`](../../doc/models/quotes-400-error-1-exception.md) |
| 401 | Unauthorized. The bearer authentication failed. | [`Quotes401Error1Exception`](../../doc/models/quotes-401-error-1-exception.md) |
| 500 | Internal Server Error. | [`Quotes500Error1Exception`](../../doc/models/quotes-500-error-1-exception.md) |

