
# Included 32

## Structure

`Included32`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"insured_risk"` |
| `Lid` | `string` | Required | The local ID that ties this resource to a related object in `data.relationships`. |
| `Attributes` | [`Attributes12`](../../doc/models/attributes-12.md) | Required | The insured risk. |

## Example (as JSON)

```json
{
  "type": "insured_risk",
  "lid": "2",
  "attributes": {
    "factors": {
      "key": "value"
    }
  }
}
```

