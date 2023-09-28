
# Relationships 9

Related items.

## Structure

`Relationships9`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Coverages` | [`Coverages2`](../../doc/models/coverages-2.md) | Optional | List of coverages that will be created at the same time as this resource. |
| `Customer` | [`Customer2`](../../doc/models/customer-2.md) | Required | Customer that will be created at the same time as this resource. |
| `InsuredRisk` | [`InsuredRisk2`](../../doc/models/insured-risk-2.md) | Optional | Insured risk that will be created at the same time as this resource. |
| `Product` | [`Product6`](../../doc/models/product-6.md) | Required | Boost supplied value representing the specific product type. The product's configuration<br>will determine allowable values for the Policy, such as limit and deductible. |

## Example (as JSON)

```json
{
  "customer": {
    "data": {
      "type": "customer",
      "lid": "2"
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
        "lid": "lid2"
      },
      {
        "type": "type0",
        "lid": "lid2"
      }
    ]
  },
  "insured_risk": {
    "data": {
      "type": "type0",
      "lid": "lid2"
    }
  }
}
```

