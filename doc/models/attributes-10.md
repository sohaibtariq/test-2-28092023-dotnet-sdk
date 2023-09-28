
# Attributes 10

Attributes for this object.

## Structure

`Attributes10`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Deductible` | `string` | Optional | A value from the set denoting the user-selected deductible of coverage. This is dependent<br>on the product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Limit` | `string` | Optional | A value from the set denoting the user-selected limit of coverage. This is dependent<br>on the product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Premium` | `string` | Optional | Calculated premium for this coverage which is included in the policy's term premium.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Metadata` | `object` | Optional | Additional data about the policy. The required metadata fields are specific to the product. |

## Example (as JSON)

```json
{
  "deductible": "1000",
  "limit": "1000",
  "premium": "100.00",
  "metadata": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

