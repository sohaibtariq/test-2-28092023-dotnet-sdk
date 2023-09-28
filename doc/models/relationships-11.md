
# Relationships 11

Related items.

## Structure

`Relationships11`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Coverages` | [`Coverages3`](../../doc/models/coverages-3.md) | Optional | List of coverages that were created. |
| `Customer` | [`Customer3`](../../doc/models/customer-3.md) | Required | Customer that was created. |
| `InsuredRisk` | [`InsuredRisk3`](../../doc/models/insured-risk-3.md) | Required | Insured risk attached to the quote. |
| `Product` | [`Product6`](../../doc/models/product-6.md) | Required | Boost supplied value representing the specific product type. The product's configuration<br>will determine allowable values for the Policy, such as limit and deductible. |
| `Agent` | [`Agent6`](../../doc/models/agent-6.md) | Optional | The Boost UUID of the agent. |

## Example (as JSON)

```json
{
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
```

