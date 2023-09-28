
# Attributes 3

Attributes that describe a policy resource with optional writeable money fields.

## Structure

`Attributes3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreatedDate` | `DateTime?` | Optional | Date time when this resource was created in our system. |
| `ModifiedDate` | `DateTime?` | Optional | Date time when this resource was last modified in our system. |
| `ActualEndDate` | `DateTime?` | Optional | The end date for this policy if it has been ended. |
| `Status` | [`StatusEnum?`](../../doc/models/status-enum.md) | Optional | The status of the policy. |
| `EarnedPremium` | `string` | Optional | Our calculated earned premium thus far for this policy.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{5})?$` |
| `EarnedTax` | `string` | Optional | Our calculated earned tax thus far for this policy.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{5})?$` |
| `EarnedFees` | `string` | Optional | Our calculated earned fees thus far for this policy.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{5})?$` |
| `CancelReason` | `string` | Optional | A value from the set denoting the reason for policy cancellation. |
| `CancelDescription` | `string` | Optional | User provided description for why policy was cancelled. |
| `PolicyNumber` | `string` | Optional | A unique alphanumeric string used as a human-readable value for the Policy.<br>**Constraints**: *Pattern*: `^BLU-[0-9a-zA-Z]{2}-[0-9a-zA-Z]{9}$` |
| `EffectiveDate` | `DateTime?` | Optional | The date and time this policy went into effect. |
| `ExternalReference` | `string` | Optional | Any value you wish to associate with this policy such as an ID from your system. |
| `Limit` | `string` | Optional | A value from the set denoting the user-selected limit of coverage. This is dependent on your product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `Deductible` | `string` | Optional | A value from the set denoting the user-selected deductible of coverage. This is dependent on your product's configuration.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `PolicyState` | [`PolicyStateEnum?`](../../doc/models/policy-state-enum.md) | Optional | The two letter state code (including Washington DC) for the state in which the issured entity resides. |
| `Metadata` | `object` | Optional | Additional data about the policy. The required metadata fields are specific to your product. |
| `TermEndDate` | `DateTime?` | Optional | The policy's natural term end date and time. |
| `InstallmentPlan` | `string` | Optional | The installment plan schedule that determines invoicing and/or automatic payment dates. |
| `WrittenPremium` | `string` | Optional | The written premium for this policy.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `IssueDate` | `DateTime?` | Optional | The date and time that the policy was issued. |
| `NonRenewalNoticeDate` | `DateTime?` | Optional | The most recently set date and time that a non-renewal notice was set to be sent. |
| `CancellationNoticeDate` | `DateTime?` | Optional | The most recently set date and time that a cancellation notice was set to be sent. |
| `RequestedCancellationDate` | `DateTime?` | Optional | The most recently set date and time that an allowed party requested a policy to be cancelled. |
| `StateTax` | `string` | Optional | The term state tax<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `StateFees` | `string` | Optional | The aggregate term state fees.<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `ServiceFees` | `string` | Optional | The term aggregate service fees<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `TermPremium` | `string` | Optional | This term premium . This value includes taxes only for admitted products<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |
| `BillingFees` | `string` | Optional | The term aggregate billing fees<br>**Constraints**: *Pattern*: `^[0-9]+(\.[0-9]{1,2})?$` |

## Example (as JSON)

```json
{
  "created_date": "08/01/2018 10:41:32",
  "modified_date": "08/01/2018 10:41:32",
  "actual_end_date": "06/01/2019 00:00:00",
  "status": "issued",
  "earned_premium": "100.00000",
  "earned_tax": "0.01644",
  "earned_fees": "0.10142",
  "cancel_reason": "fraud",
  "cancel_description": "Client committed fraud when applying for this policy.",
  "policy_number": "BLU-XX-2FM83109D",
  "effective_date": "08/01/2018 00:00:00",
  "external_reference": "000000001",
  "limit": "1000000",
  "deductible": "1000",
  "policy_state": "AZ",
  "term_end_date": "08/01/2019 00:00:00",
  "installment_plan": "ANNUAL",
  "written_premium": "1234.56",
  "issue_date": "08/01/2018 00:00:00",
  "non_renewal_notice_date": "08/01/2018 00:00:00",
  "cancellation_notice_date": "08/01/2018 00:00:00",
  "requested_cancellation_date": "08/01/2018 00:00:00",
  "state_tax": "12.34",
  "state_fees": "12.34",
  "service_fees": "12.34",
  "term_premium": "1234.56",
  "billing_fees": "12.34"
}
```

