
# Relationships 4

Items related to this coverage.

## Structure

`Relationships4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Policy` | [`Policy`](../../doc/models/policy.md) | Required | UUID that identifies this policy. |
| `Endorsement` | [`Endorsement`](../../doc/models/endorsement.md) | Required | UUID that identifies this endorsement. |
| `Coverage` | [`Coverage`](../../doc/models/coverage.md) | Required | UUID that identifies this product coverage. |

## Example (as JSON)

```json
{
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
```

