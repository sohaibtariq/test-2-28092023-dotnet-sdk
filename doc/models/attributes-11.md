
# Attributes 11

The insured entity.

## Structure

`Attributes11`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExternalReference` | `string` | Optional | A reference that can be used to identify this customer in your system. |
| `EntityType` | [`EntityTypeEnum`](../../doc/models/entity-type-enum.md) | Required | The kind of customer this is. |
| `BusinessName` | `string` | Optional | The legal name of the business. |
| `FirstName` | `string` | Required | The first name of the contact. |
| `LastName` | `string` | Required | The last name of the contact. |
| `Email` | `string` | Required | The email address of the contact. |
| `Phone` | `string` | Required | The primary phone number of the contact. |
| `Website` | `string` | Optional | The website of the contact. |
| `MailingAddress` | [`MailingAddress`](../../doc/models/mailing-address.md) | Required | The mailing address of this customer. |
| `BillingAddress` | [`BillingAddress`](../../doc/models/billing-address.md) | Optional | The billing address of this customer. |

## Example (as JSON)

```json
{
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
}
```

