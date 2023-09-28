
# Relationships 3

Items related to this policy.

## Structure

`Relationships3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Coverages` | [`Coverages`](../../doc/models/coverages.md) | Required | List of coverages that apply to this policy. |
| `InsuredRisk` | [`InsuredRisk`](../../doc/models/insured-risk.md) | Required | The risk insured by the policy. |
| `Customer` | [`Customer`](../../doc/models/customer.md) | Required | Relationship containing the id that identifies the customer for this policy. |
| `Product` | [`Product2`](../../doc/models/product-2.md) | Required | Boost supplied value representing the specific product type. The product's configuration<br>Determines allowable values, such as limit and deductible. |
| `Parent` | [`Parent`](../../doc/models/parent.md) | Required | ID of parent policy. Product must also be a parent product. |
| `AdditionalInterests` | [`AdditionalInterests`](../../doc/models/additional-interests.md) | Required | List of additional interests for this policy. |
| `AdditionalInsured` | [`AdditionalInsured`](../../doc/models/additional-insured.md) | Required | List of additional insured for this policy. |
| `Agent` | [`Agent`](../../doc/models/agent.md) | Required | UUID of the agent. |
| `InstallmentPlan` | [`InstallmentPlan`](../../doc/models/installment-plan.md) | Required | The Boost UUID for the `installment_plan` based on the chosen installment plan. |

## Example (as JSON)

```json
{
  "coverages": {
    "data": [
      {
        "type": "customer",
        "id": "55efaaf6-2bb2-4cdd-b5ec-5475af712c52"
      }
    ],
    "meta": {
      "count": 14
    }
  },
  "insured_risk": {
    "data": {
      "type": "insured_risk",
      "id": "889c16f9-c236-4c29-9721-aa5bbaeb7107"
    }
  },
  "customer": {
    "data": {
      "type": "customer",
      "id": "fd5a4e30-a897-4383-a0a4-bd62970f6d23"
    }
  },
  "product": {
    "data": {
      "type": "product",
      "id": "7fca5107-79c0-4b1d-88e7-0a3155a42aba"
    }
  },
  "parent": {
    "data": {
      "type": "policy",
      "id": "9c5fa6b9-4107-4709-8b44-e188b9a45d33"
    }
  },
  "additional_interests": {
    "data": [
      {
        "type": "customer",
        "id": "55efaaf6-2bb2-4cdd-b5ec-5475af712c52"
      }
    ],
    "meta": {
      "count": 14
    }
  },
  "additional_insured": {
    "data": [
      {
        "type": "customer",
        "id": "55efaaf6-2bb2-4cdd-b5ec-5475af712c52"
      }
    ],
    "meta": {
      "count": 14
    }
  },
  "agent": {
    "data": {
      "type": "agent",
      "id": "6a04ddef-b9fa-48b0-8c46-1a580868491e"
    }
  },
  "installment_plan": {
    "data": {
      "type": "installment_plan",
      "id": "2e3dc75c-3f7d-4721-80df-b5fac6617825"
    }
  }
}
```

