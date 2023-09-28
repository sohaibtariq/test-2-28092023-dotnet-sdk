
# Included 42

## Structure

`Included42`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"insured_risk"` |
| `Id` | `Guid` | Required | Unique Boost-generated UUID that identifies this resource. |
| `Lid` | `string` | Required | The local ID that ties this resource to a related object in `data.relationships`. |
| `Attributes` | [`Attributes12`](../../doc/models/attributes-12.md) | Required | The insured risk. |
| `Relationships` | [`Relationships14`](../../doc/models/relationships-14.md) | Required | Related items. |

## Example (as JSON)

```json
{
  "type": "insured_risk",
  "id": "d64d47eb-c7a6-4128-985b-0ecc79284608",
  "lid": "2",
  "attributes": {
    "factors": {
      "key": "value"
    }
  },
  "relationships": {
    "product": {
      "data": {
        "type": "product",
        "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
      }
    },
    "agent": {
      "data": {
        "type": "product",
        "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
      }
    }
  }
}
```

