
# Policies Request

## Structure

`PoliciesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Data6`](../../doc/models/data-6.md) | Required | Data for creating a policy from a quote requiring a stripe token. |

## Example (as JSON)

```json
{
  "data": {
    "type": "policy",
    "attributes": {
      "quote_number": "BLU-XX-T63XWYHFE",
      "installment_plan": "ANNUAL",
      "stripe_token": "tok_mastercard",
      "external_id": "1234567890"
    },
    "relationships": {
      "additional_interests": {
        "data": [
          {
            "type": "type0",
            "id": "00001c2a-0000-0000-0000-000000000000"
          },
          {
            "type": "type0",
            "id": "00001c2a-0000-0000-0000-000000000000"
          },
          {
            "type": "type0",
            "id": "00001c2a-0000-0000-0000-000000000000"
          }
        ],
        "meta": {
          "count": 14
        }
      },
      "parent": {
        "data": {
          "type": "type0",
          "id": "00001c2a-0000-0000-0000-000000000000"
        }
      }
    }
  }
}
```

