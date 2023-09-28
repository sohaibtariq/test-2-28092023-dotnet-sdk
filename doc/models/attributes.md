
# Attributes

Attributes that describe an Insured Risk.

## Structure

`Attributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreatedDate` | `DateTime?` | Optional | Date time when this resource was created in our system. |
| `ModifiedDate` | `DateTime?` | Optional | Date time when this resource was last modified in our system. |
| `Factors` | `object` | Required | Specific ratable factors that apply to this Insured Risk. The content must fully adhere to a product-specific, pre-defined schema. |

## Example (as JSON)

```json
{
  "created_date": "08/01/2018 10:41:32",
  "modified_date": "08/01/2018 10:41:32",
  "factors": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

