
# Relationships 1

Related objects.

## Structure

`Relationships1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Agent` | [`Agent`](../../doc/models/agent.md) | Required | UUID of the agent. |
| `Product` | [`Product`](../../doc/models/product.md) | Required | Boost supplied value representing the specific product type. The product's configuration<br>Determines allowable values, such as limits and deductibles. |

## Example (as JSON)

```json
{
  "agent": {
    "data": {
      "type": "agent",
      "id": "6a04ddef-b9fa-48b0-8c46-1a580868491e"
    }
  },
  "product": {
    "data": {
      "type": "product",
      "id": "7fca5107-79c0-4b1d-88e7-0a3155a42aba"
    }
  }
}
```

