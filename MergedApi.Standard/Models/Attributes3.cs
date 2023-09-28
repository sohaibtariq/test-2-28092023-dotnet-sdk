// <copyright file="Attributes3.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MergedApi.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using MergedApi.Standard;
    using MergedApi.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Attributes3.
    /// </summary>
    public class Attributes3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes3"/> class.
        /// </summary>
        public Attributes3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes3"/> class.
        /// </summary>
        /// <param name="createdDate">created_date.</param>
        /// <param name="modifiedDate">modified_date.</param>
        /// <param name="actualEndDate">actual_end_date.</param>
        /// <param name="status">status.</param>
        /// <param name="earnedPremium">earned_premium.</param>
        /// <param name="earnedTax">earned_tax.</param>
        /// <param name="earnedFees">earned_fees.</param>
        /// <param name="cancelReason">cancel_reason.</param>
        /// <param name="cancelDescription">cancel_description.</param>
        /// <param name="policyNumber">policy_number.</param>
        /// <param name="effectiveDate">effective_date.</param>
        /// <param name="externalReference">external_reference.</param>
        /// <param name="limit">limit.</param>
        /// <param name="deductible">deductible.</param>
        /// <param name="policyState">policy_state.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="termEndDate">term_end_date.</param>
        /// <param name="installmentPlan">installment_plan.</param>
        /// <param name="writtenPremium">written_premium.</param>
        /// <param name="issueDate">issue_date.</param>
        /// <param name="nonRenewalNoticeDate">non_renewal_notice_date.</param>
        /// <param name="cancellationNoticeDate">cancellation_notice_date.</param>
        /// <param name="requestedCancellationDate">requested_cancellation_date.</param>
        /// <param name="stateTax">state_tax.</param>
        /// <param name="stateFees">state_fees.</param>
        /// <param name="serviceFees">service_fees.</param>
        /// <param name="termPremium">term_premium.</param>
        /// <param name="billingFees">billing_fees.</param>
        public Attributes3(
            DateTime? createdDate = null,
            DateTime? modifiedDate = null,
            DateTime? actualEndDate = null,
            Models.StatusEnum? status = null,
            string earnedPremium = null,
            string earnedTax = null,
            string earnedFees = null,
            string cancelReason = null,
            string cancelDescription = null,
            string policyNumber = null,
            DateTime? effectiveDate = null,
            string externalReference = null,
            string limit = null,
            string deductible = null,
            Models.PolicyStateEnum? policyState = null,
            object metadata = null,
            DateTime? termEndDate = null,
            string installmentPlan = null,
            string writtenPremium = null,
            DateTime? issueDate = null,
            DateTime? nonRenewalNoticeDate = null,
            DateTime? cancellationNoticeDate = null,
            DateTime? requestedCancellationDate = null,
            string stateTax = null,
            string stateFees = null,
            string serviceFees = null,
            string termPremium = null,
            string billingFees = null)
        {
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.ActualEndDate = actualEndDate;
            this.Status = status;
            this.EarnedPremium = earnedPremium;
            this.EarnedTax = earnedTax;
            this.EarnedFees = earnedFees;
            this.CancelReason = cancelReason;
            this.CancelDescription = cancelDescription;
            this.PolicyNumber = policyNumber;
            this.EffectiveDate = effectiveDate;
            this.ExternalReference = externalReference;
            this.Limit = limit;
            this.Deductible = deductible;
            this.PolicyState = policyState;
            this.Metadata = metadata;
            this.TermEndDate = termEndDate;
            this.InstallmentPlan = installmentPlan;
            this.WrittenPremium = writtenPremium;
            this.IssueDate = issueDate;
            this.NonRenewalNoticeDate = nonRenewalNoticeDate;
            this.CancellationNoticeDate = cancellationNoticeDate;
            this.RequestedCancellationDate = requestedCancellationDate;
            this.StateTax = stateTax;
            this.StateFees = stateFees;
            this.ServiceFees = serviceFees;
            this.TermPremium = termPremium;
            this.BillingFees = billingFees;
        }

        /// <summary>
        /// Date time when this resource was created in our system.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date time when this resource was last modified in our system.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The end date for this policy if it has been ended.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("actual_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ActualEndDate { get; set; }

        /// <summary>
        /// The status of the policy.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StatusEnum? Status { get; set; }

        /// <summary>
        /// Our calculated earned premium thus far for this policy.
        /// </summary>
        [JsonProperty("earned_premium", NullValueHandling = NullValueHandling.Ignore)]
        public string EarnedPremium { get; set; }

        /// <summary>
        /// Our calculated earned tax thus far for this policy.
        /// </summary>
        [JsonProperty("earned_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string EarnedTax { get; set; }

        /// <summary>
        /// Our calculated earned fees thus far for this policy.
        /// </summary>
        [JsonProperty("earned_fees", NullValueHandling = NullValueHandling.Ignore)]
        public string EarnedFees { get; set; }

        /// <summary>
        /// A value from the set denoting the reason for policy cancellation.
        /// </summary>
        [JsonProperty("cancel_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelReason { get; set; }

        /// <summary>
        /// User provided description for why policy was cancelled.
        /// </summary>
        [JsonProperty("cancel_description", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelDescription { get; set; }

        /// <summary>
        /// A unique alphanumeric string used as a human-readable value for the Policy.
        /// </summary>
        [JsonProperty("policy_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// The date and time this policy went into effect.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Any value you wish to associate with this policy such as an ID from your system.
        /// </summary>
        [JsonProperty("external_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// A value from the set denoting the user-selected limit of coverage. This is dependent on your product's configuration.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// A value from the set denoting the user-selected deductible of coverage. This is dependent on your product's configuration.
        /// </summary>
        [JsonProperty("deductible", NullValueHandling = NullValueHandling.Ignore)]
        public string Deductible { get; set; }

        /// <summary>
        /// The two letter state code (including Washington DC) for the state in which the issured entity resides.
        /// </summary>
        [JsonProperty("policy_state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PolicyStateEnum? PolicyState { get; set; }

        /// <summary>
        /// Additional data about the policy. The required metadata fields are specific to your product.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object Metadata { get; set; }

        /// <summary>
        /// The policy's natural term end date and time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("term_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TermEndDate { get; set; }

        /// <summary>
        /// The installment plan schedule that determines invoicing and/or automatic payment dates.
        /// </summary>
        [JsonProperty("installment_plan", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallmentPlan { get; set; }

        /// <summary>
        /// The written premium for this policy.
        /// </summary>
        [JsonProperty("written_premium", NullValueHandling = NullValueHandling.Ignore)]
        public string WrittenPremium { get; set; }

        /// <summary>
        /// The date and time that the policy was issued.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// The most recently set date and time that a non-renewal notice was set to be sent.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("non_renewal_notice_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NonRenewalNoticeDate { get; set; }

        /// <summary>
        /// The most recently set date and time that a cancellation notice was set to be sent.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("cancellation_notice_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CancellationNoticeDate { get; set; }

        /// <summary>
        /// The most recently set date and time that an allowed party requested a policy to be cancelled.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("requested_cancellation_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RequestedCancellationDate { get; set; }

        /// <summary>
        /// The term state tax
        /// </summary>
        [JsonProperty("state_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string StateTax { get; set; }

        /// <summary>
        /// The aggregate term state fees.
        /// </summary>
        [JsonProperty("state_fees", NullValueHandling = NullValueHandling.Ignore)]
        public string StateFees { get; set; }

        /// <summary>
        /// The term aggregate service fees
        /// </summary>
        [JsonProperty("service_fees", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceFees { get; set; }

        /// <summary>
        /// This term premium . This value includes taxes only for admitted products
        /// </summary>
        [JsonProperty("term_premium", NullValueHandling = NullValueHandling.Ignore)]
        public string TermPremium { get; set; }

        /// <summary>
        /// The term aggregate billing fees
        /// </summary>
        [JsonProperty("billing_fees", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingFees { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes3 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Attributes3 other &&                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.ModifiedDate == null && other.ModifiedDate == null) || (this.ModifiedDate?.Equals(other.ModifiedDate) == true)) &&
                ((this.ActualEndDate == null && other.ActualEndDate == null) || (this.ActualEndDate?.Equals(other.ActualEndDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.EarnedPremium == null && other.EarnedPremium == null) || (this.EarnedPremium?.Equals(other.EarnedPremium) == true)) &&
                ((this.EarnedTax == null && other.EarnedTax == null) || (this.EarnedTax?.Equals(other.EarnedTax) == true)) &&
                ((this.EarnedFees == null && other.EarnedFees == null) || (this.EarnedFees?.Equals(other.EarnedFees) == true)) &&
                ((this.CancelReason == null && other.CancelReason == null) || (this.CancelReason?.Equals(other.CancelReason) == true)) &&
                ((this.CancelDescription == null && other.CancelDescription == null) || (this.CancelDescription?.Equals(other.CancelDescription) == true)) &&
                ((this.PolicyNumber == null && other.PolicyNumber == null) || (this.PolicyNumber?.Equals(other.PolicyNumber) == true)) &&
                ((this.EffectiveDate == null && other.EffectiveDate == null) || (this.EffectiveDate?.Equals(other.EffectiveDate) == true)) &&
                ((this.ExternalReference == null && other.ExternalReference == null) || (this.ExternalReference?.Equals(other.ExternalReference) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Deductible == null && other.Deductible == null) || (this.Deductible?.Equals(other.Deductible) == true)) &&
                ((this.PolicyState == null && other.PolicyState == null) || (this.PolicyState?.Equals(other.PolicyState) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.TermEndDate == null && other.TermEndDate == null) || (this.TermEndDate?.Equals(other.TermEndDate) == true)) &&
                ((this.InstallmentPlan == null && other.InstallmentPlan == null) || (this.InstallmentPlan?.Equals(other.InstallmentPlan) == true)) &&
                ((this.WrittenPremium == null && other.WrittenPremium == null) || (this.WrittenPremium?.Equals(other.WrittenPremium) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.NonRenewalNoticeDate == null && other.NonRenewalNoticeDate == null) || (this.NonRenewalNoticeDate?.Equals(other.NonRenewalNoticeDate) == true)) &&
                ((this.CancellationNoticeDate == null && other.CancellationNoticeDate == null) || (this.CancellationNoticeDate?.Equals(other.CancellationNoticeDate) == true)) &&
                ((this.RequestedCancellationDate == null && other.RequestedCancellationDate == null) || (this.RequestedCancellationDate?.Equals(other.RequestedCancellationDate) == true)) &&
                ((this.StateTax == null && other.StateTax == null) || (this.StateTax?.Equals(other.StateTax) == true)) &&
                ((this.StateFees == null && other.StateFees == null) || (this.StateFees?.Equals(other.StateFees) == true)) &&
                ((this.ServiceFees == null && other.ServiceFees == null) || (this.ServiceFees?.Equals(other.ServiceFees) == true)) &&
                ((this.TermPremium == null && other.TermPremium == null) || (this.TermPremium?.Equals(other.TermPremium) == true)) &&
                ((this.BillingFees == null && other.BillingFees == null) || (this.BillingFees?.Equals(other.BillingFees) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.ModifiedDate = {(this.ModifiedDate == null ? "null" : this.ModifiedDate.ToString())}");
            toStringOutput.Add($"this.ActualEndDate = {(this.ActualEndDate == null ? "null" : this.ActualEndDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.EarnedPremium = {(this.EarnedPremium == null ? "null" : this.EarnedPremium)}");
            toStringOutput.Add($"this.EarnedTax = {(this.EarnedTax == null ? "null" : this.EarnedTax)}");
            toStringOutput.Add($"this.EarnedFees = {(this.EarnedFees == null ? "null" : this.EarnedFees)}");
            toStringOutput.Add($"this.CancelReason = {(this.CancelReason == null ? "null" : this.CancelReason)}");
            toStringOutput.Add($"this.CancelDescription = {(this.CancelDescription == null ? "null" : this.CancelDescription)}");
            toStringOutput.Add($"this.PolicyNumber = {(this.PolicyNumber == null ? "null" : this.PolicyNumber)}");
            toStringOutput.Add($"this.EffectiveDate = {(this.EffectiveDate == null ? "null" : this.EffectiveDate.ToString())}");
            toStringOutput.Add($"this.ExternalReference = {(this.ExternalReference == null ? "null" : this.ExternalReference)}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit)}");
            toStringOutput.Add($"this.Deductible = {(this.Deductible == null ? "null" : this.Deductible)}");
            toStringOutput.Add($"this.PolicyState = {(this.PolicyState == null ? "null" : this.PolicyState.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.TermEndDate = {(this.TermEndDate == null ? "null" : this.TermEndDate.ToString())}");
            toStringOutput.Add($"this.InstallmentPlan = {(this.InstallmentPlan == null ? "null" : this.InstallmentPlan)}");
            toStringOutput.Add($"this.WrittenPremium = {(this.WrittenPremium == null ? "null" : this.WrittenPremium)}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate.ToString())}");
            toStringOutput.Add($"this.NonRenewalNoticeDate = {(this.NonRenewalNoticeDate == null ? "null" : this.NonRenewalNoticeDate.ToString())}");
            toStringOutput.Add($"this.CancellationNoticeDate = {(this.CancellationNoticeDate == null ? "null" : this.CancellationNoticeDate.ToString())}");
            toStringOutput.Add($"this.RequestedCancellationDate = {(this.RequestedCancellationDate == null ? "null" : this.RequestedCancellationDate.ToString())}");
            toStringOutput.Add($"this.StateTax = {(this.StateTax == null ? "null" : this.StateTax)}");
            toStringOutput.Add($"this.StateFees = {(this.StateFees == null ? "null" : this.StateFees)}");
            toStringOutput.Add($"this.ServiceFees = {(this.ServiceFees == null ? "null" : this.ServiceFees)}");
            toStringOutput.Add($"this.TermPremium = {(this.TermPremium == null ? "null" : this.TermPremium)}");
            toStringOutput.Add($"this.BillingFees = {(this.BillingFees == null ? "null" : this.BillingFees)}");
        }
    }
}