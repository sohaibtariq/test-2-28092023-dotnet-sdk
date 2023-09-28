
# Attributes 4

Attributes of this coverage.

## Structure

`Attributes4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreatedDate` | `DateTime` | Required | Date time when this resource was created in our system. |
| `ModifiedDate` | `DateTime` | Required | Date time when this resource was last modified in our system. |
| `Deductible` | `string` | Required | A value from the set denoting the user-selected deductible of coverage. This is dependent<br>on the product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Limit` | `string` | Required | A value from the set denoting the user-selected limit of coverage. This is dependent<br>on the product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Premium` | `string` | Required | Term premium for this coverage<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `AdditionalFees` | `string` | Required | Additional fees relating to this coverage.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `RevisionDate` | `DateTime` | Required | Date for when this coverage goes into effect on the policy. |

## Example (as JSON)

```json
{
  "created_date": "08/01/2018 10:41:32",
  "modified_date": "08/01/2018 10:41:32",
  "deductible": "1000",
  "limit": "1000000",
  "premium": "150.00",
  "additional_fees": "1.23",
  "revision_date": "01/30/2019 12:32:15"
}
```

