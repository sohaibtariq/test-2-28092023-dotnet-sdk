
# Data 45

All values for this quote are in this top-level object.

## Structure

`Data45`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"quote"` |
| `Id` | `string` | Required | Unique Boost generated identifier for this resource that adheres to the above pattern.<br>**Constraints**: *Pattern*: `^BLU-[0-9a-zA-Z]{2}-[0-9a-zA-Z]{9}$` |
| `Attributes` | [`Attributes9`](../../doc/models/attributes-9.md) | Required | Attributes for this object. |
| `Relationships` | [`Relationships11`](../../doc/models/relationships-11.md) | Required | Related items. |

## Example (as JSON)

```json
{
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
}
```

