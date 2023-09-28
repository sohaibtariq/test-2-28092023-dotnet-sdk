
# Insured Risks Response

## Structure

`InsuredRisksResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Data3`](../../doc/models/data-3.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "type": "insured_risk",
    "id": "00001c2a-0000-0000-0000-000000000000",
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
}
```

