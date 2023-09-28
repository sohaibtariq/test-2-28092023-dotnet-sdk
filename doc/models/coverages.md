
# Coverages

List of coverages that apply to this policy.

## Structure

`Coverages`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Data7>`](../../doc/models/data-7.md) | Required | List of coverages. |
| `Meta` | [`Meta`](../../doc/models/meta.md) | Optional | Additional meta information about this data. |

## Example (as JSON)

```json
{
  "data": [
    {
      "type": "customer",
      "id": "55efaaf6-2bb2-4cdd-b5ec-5475af712c52"
    }
  ],
  "meta": {
    "count": 14
  }
}
```

