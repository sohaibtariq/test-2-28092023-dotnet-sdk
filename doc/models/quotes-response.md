
# Quotes Response

Data representing a quote.

## Structure

`QuotesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Data45`](../../doc/models/data-45.md) | Required | All values for this quote are in this top-level object. |
| `Included` | `object` | Required | Array of included objects. |

## Example (as JSON)

```json
{
  "data": {
    "type": "quote",
    "id": "BLU-XX-T63XWYHFE",
    "attributes": {
      "limit": "1000",
      "deductible": "1000",
      "policy_state": "AZ",
      "effective_date": "2016-03-13T12:52:32.123Z",
      "term_end_date": "08/01/2018 00:00:00",
      "external_reference": "000000001",
      "bindable_on": "08/01/2018 00:00:00",
      "term_premium": "123.45",
      "valid_until": "08/01/2018 00:00:00",
      "convertable_on": "08/01/2018 00:00:00",
      "converted_on": "08/01/2018 00:00:00",
      "status": "draft",
      "min_premium": "12.34",
      "state_tax": "12.34",
      "state_fees": "12.34",
      "service_fees": "12.34",
      "billing_fees": "12.34",
      "metadata": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "relationships": {
      "customer": {
        "data": {
          "type": "customer",
          "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
        }
      },
      "insured_risk": {
        "data": {
          "type": "customer",
          "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
        }
      },
      "product": {
        "data": {
          "type": "product",
          "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
        }
      },
      "coverages": {
        "data": [
          {
            "type": "type0",
            "id": "00001c2a-0000-0000-0000-000000000000"
          },
          {
            "type": "type0",
            "id": "00001c2a-0000-0000-0000-000000000000"
          }
        ]
      },
      "agent": {
        "data": {
          "type": "type0",
          "id": "00001c2a-0000-0000-0000-000000000000"
        }
      }
    }
  },
  "included": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ]
}
```

