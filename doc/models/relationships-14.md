
# Relationships 14

Related items.

## Structure

`Relationships14`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Product` | [`Product6`](../../doc/models/product-6.md) | Required | Boost supplied value representing the specific product type. The product's configuration<br>will determine allowable values for the Policy, such as limit and deductible. |
| `Agent` | [`Agent6`](../../doc/models/agent-6.md) | Required | The Boost UUID of the agent. |

## Example (as JSON)

```json
{
  "product": {
    "data": {
      "type": "product",
      "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
    }
  },
  "agent": {
    "data": {
      "type": "product",
      "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
    }
  }
}
```

