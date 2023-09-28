
# Relationships 2

Related items.

## Structure

`Relationships2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalInterests` | [`AdditionalInterests`](../../doc/models/additional-interests.md) | Optional | List of additional interests for this policy. |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Optional | ID of parent policy. Product must also be a parent product. |

## Example (as JSON)

```json
{
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
```

