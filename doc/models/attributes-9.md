
# Attributes 9

Attributes for this object.

## Structure

`Attributes9`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Limit` | `string` | Optional | A value from the set denoting the user-selected limit of coverage. This is dependent<br>on the product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Deductible` | `string` | Optional | A value from the set denoting the user-selected deductible of coverage. This is dependent<br>on the product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `PolicyState` | [`PolicyState2Enum`](../../doc/models/policy-state-2-enum.md) | Required | The two letter state code (including Washington DC). |
| `EffectiveDate` | `DateTime` | Required | Effective date for when the resulting policy would go into effective should it be generated. |
| `TermEndDate` | `DateTime` | Required | The desired end date for the policy that results from this quote. The span from effective_date to this term_end_date must be allowable by the product's terms. |
| `ExternalReference` | `string` | Optional | Any value you wish to associate with this policy such as an ID from your system. |
| `Metadata` | `object` | Optional | Additional data about the policy. The required metadata fields are specific to the product. |
| `BindableOn` | `DateTime?` | Optional | The date this quote was rated and set to bindable. |
| `TermPremium` | `string` | Optional | Boost generated term premium for this quote.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `ValidUntil` | `DateTime?` | Optional | The date this quote is valid until after which point a new quote will need to be generated. |
| `ConvertableOn` | `DateTime?` | Optional | The date this quote satisfied all its dependencies to become a policy. |
| `ConvertedOn` | `DateTime?` | Optional | The date this quote was converted into a policy. |
| `Status` | [`Status2Enum?`](../../doc/models/status-2-enum.md) | Optional | The status of the quote. |
| `InstallmentPlans` | `object` | Optional | Payment installment plans that are available for this quote |
| `MinPremium` | `string` | Optional | Boost generated minimum premium for this product.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `StateTax` | `string` | Optional | Any state taxes that apply to this quote.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `StateFees` | `string` | Optional | Any state fees that apply to this quote.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `ServiceFees` | `string` | Optional | Any service fees that apply to this quote.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `BillingFees` | `string` | Optional | Any billing fees that apply to this quote.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |

## Example (as JSON)

```json
{
  "limit": "1000",
  "deductible": "1000",
  "policy_state": "AZ",
  "effective_date": "2016-03-13T12:52:32.123Z",
  "term_end_date": "08/01/2018 00:00:00",
  "external_reference": "000000001",
  "bindable_on": "08/01/2018 00:00:00",
  "term_premium": "123.45",
  "valid_until": "08/01/2018 00:00:00",
  "convertable_on": "08/01/2018 00:00:00",
  "converted_on": "08/01/2018 00:00:00",
  "status": "draft",
  "min_premium": "12.34",
  "state_tax": "12.34",
  "state_fees": "12.34",
  "service_fees": "12.34",
  "billing_fees": "12.34",
  "metadata": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

