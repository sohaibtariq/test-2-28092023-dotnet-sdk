
# Included

## Structure

`Included`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"coverage"` |
| `Id` | `Guid` | Required | UUID that identifies this resource. |
| `Attributes` | [`Attributes4`](../../doc/models/attributes-4.md) | Required | Attributes of this coverage. |
| `Relationships` | [`Relationships4`](../../doc/models/relationships-4.md) | Required | Items related to this coverage. |

## Example (as JSON)

```json
{
  "type": "coverage",
  "id": "a5f0c4fc-737e-41e3-b88b-fb56020766a8",
  "attributes": {
    "created_date": "08/01/2018 10:41:32",
    "modified_date": "08/01/2018 10:41:32",
    "deductible": "1000",
    "limit": "1000000",
    "premium": "150.00",
    "additional_fees": "1.23",
    "revision_date": "01/30/2019 12:32:15"
  },
  "relationships": {
    "policy": {
      "data": {
        "type": "policy",
        "id": "f445dde9-32d2-46cf-8cac-9fe4409fee0b"
      }
    },
    "endorsement": {
      "data": {
        "type": "endorsement",
        "id": "b1deb55f-8108-400c-9443-e8bc61d1928d"
      }
    },
    "coverage": {
      "data": {
        "type": "product_coverage",
        "id": "902522f9-f38c-40c5-9b4c-bb401be5f0d9"
      }
    }
  }
}
```

