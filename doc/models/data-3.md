
# Data 3

## Structure

`Data3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"insured_risk"` |
| `Id` | `Guid` | Required | - |
| `Attributes` | [`Attributes1`](../../doc/models/attributes-1.md) | Required | Attributes that describe an Insured Risk. |
| `Relationships` | [`Relationships1`](../../doc/models/relationships-1.md) | Required | Related objects. |

## Example (as JSON)

```json
{
  "type": "insured_risk",
  "id": "00001f5c-0000-0000-0000-000000000000",
  "attributes": {
    "created_date": "08/01/2018 10:41:32",
    "modified_date": "08/01/2018 10:41:32",
    "factors": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "relationships": {
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
}
```

