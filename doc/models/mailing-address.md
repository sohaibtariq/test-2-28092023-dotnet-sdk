
# Mailing Address

The mailing address of this customer.

## Structure

`MailingAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address1` | `string` | Required | The first line of the address. |
| `Address2` | `string` | Optional | The second line of the address. |
| `City` | `string` | Required | The city of the address. |
| `State` | [`StateEnum`](../../doc/models/state-enum.md) | Required | Two letter state code of the address. |
| `Zip` | `string` | Required | 5 or 10 character postal code of the address.<br>**Constraints**: *Pattern*: `^[0-9]{5}(-[0-9]{4})?$` |

## Example (as JSON)

```json
{
  "address1": "123 Main St",
  "address2": "Suite 123",
  "city": "New York",
  "state": "NY",
  "zip": "10016"
}
```

