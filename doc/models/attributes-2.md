
# Attributes 2

Attributes for this policy.

## Structure

`Attributes2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QuoteNumber` | `string` | Required | Quote number received from quote creation.<br>**Constraints**: *Pattern*: `^BLU-[0-9a-zA-Z]{2}-[0-9a-zA-Z]{9}$` |
| `InstallmentPlan` | `string` | Required | Value from the set which controls invoicing and billing. This is dependent<br>on your product's configuration. |
| `StripeToken` | `string` | Required | Stripe credit card token that will be used for charge authorization. |
| `ExternalId` | `string` | Optional | Any value you wish to associate with this resource such as an ID from your system. |

## Example (as JSON)

```json
{
  "quote_number": "BLU-XX-T63XWYHFE",
  "installment_plan": "ANNUAL",
  "stripe_token": "tok_mastercard",
  "external_id": "1234567890"
}
```

