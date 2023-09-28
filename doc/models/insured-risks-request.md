
# Insured Risks Request

## Structure

`InsuredRisksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Data`](../../doc/models/data.md) | Required | All values that describe this Insured Risk resource. |

## Example (as JSON)

```json
{
  "data": {
    "type": "insured_risk",
    "attributes": {
      "created_date": "08/01/2018 10:41:32",
      "modified_date": "08/01/2018 10:41:32",
      "factors": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "relationships": {
      "product": {
        "data": {
          "type": "product",
          "id": "7fca5107-79c0-4b1d-88e7-0a3155a42aba"
        }
      },
      "agent": {
        "data": {
          "type": "type0",
          "id": "00001c2a-0000-0000-0000-000000000000"
        }
      }
    },
    "id": "00001c2a-0000-0000-0000-000000000000"
  }
}
```

