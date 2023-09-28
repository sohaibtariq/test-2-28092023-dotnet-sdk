
# Included 41

## Structure

`Included41`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The type of resource being represented.<br>**Default**: `"customer"` |
| `Id` | `Guid` | Required | Unique Boost-generated UUID that identifies this resource. |
| `Lid` | `string` | Required | The local ID that ties this resource to a related object in `data.relationships`. |
| `Attributes` | [`Attributes11`](../../doc/models/attributes-11.md) | Required | The insured entity. |
| `Relationships` | [`Relationships13`](../../doc/models/relationships-13.md) | Required | Related items. |

## Example (as JSON)

```json
{
  "type": "customer",
  "id": "d64d47eb-c7a6-4128-985b-0ecc79284608",
  "lid": "2",
  "attributes": {
    "external_reference": "d64d47eb-c7a6-4128-985b-0ecc79284608",
    "entity_type": "business",
    "business_name": "Acme, Inc.",
    "first_name": "John",
    "last_name": "Smith",
    "email": "john.smith@example.com",
    "phone": "9175551212",
    "website": "https://www.insurtech.dev",
    "mailing_address": {
      "address1": "123 Main St",
      "address2": "Suite 123",
      "city": "New York",
      "state": "NY",
      "zip": "10016"
    },
    "billing_address": {
      "address1": "address16",
      "address2": "address20",
      "city": "city2",
      "state": "NM",
      "zip": "zip8"
    }
  },
  "relationships": {
    "agent": {
      "data": {
        "type": "product",
        "id": "d64d47eb-c7a6-4128-985b-0ecc79284608"
      }
    }
  }
}
```

