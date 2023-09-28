
# Data 42

Provided data for this insured risk relationship with local ID.

## Structure

`Data42`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"insured_risk"` |
| `Lid` | `string` | Required | The local ID that ties this resource to a related object in `data.included`. |

## Example (as JSON)

```json
{
  "type": "insured_risk",
  "lid": "2"
}
```

