
# Data 41

Provided data for this customer relationship with local ID.

## Structure

`Data41`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"customer"` |
| `Lid` | `string` | Required | The local ID that ties this resource to a related object in `data.included`. |

## Example (as JSON)

```json
{
  "type": "customer",
  "lid": "2"
}
```

