
# Installment Plan 2

## Structure

`InstallmentPlan2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingPeriod` | `DateTime` | Required | The billing period for this installment plan entry. |
| `AmountDue` | `string` | Required | Boost generated amount due for this installment plan entry.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `DueDate` | `DateTime` | Required | The date on which payment is due for this billing period. |
| `Taxes` | `string` | Required | Boost generated taxes due for this installment plan entry.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Fees` | `string` | Required | Boost generated fees due for this installment plan entry.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |

## Example (as JSON)

```json
{
  "billing_period": "08/01/2018 00:00:00",
  "amount_due": "123.45",
  "due_date": "08/01/2018 00:00:00",
  "taxes": "12.34",
  "fees": "12.34"
}
```

