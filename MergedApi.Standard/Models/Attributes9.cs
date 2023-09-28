// <copyright file="Attributes9.cs" company="APIMatic">
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
    /// Attributes9.
    /// </summary>
    public class Attributes9
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes9"/> class.
        /// </summary>
        public Attributes9()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes9"/> class.
        /// </summary>
        /// <param name="policyState">policy_state.</param>
        /// <param name="effectiveDate">effective_date.</param>
        /// <param name="termEndDate">term_end_date.</param>
        /// <param name="limit">limit.</param>
        /// <param name="deductible">deductible.</param>
        /// <param name="externalReference">external_reference.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="bindableOn">bindable_on.</param>
        /// <param name="termPremium">term_premium.</param>
        /// <param name="validUntil">valid_until.</param>
        /// <param name="convertableOn">convertable_on.</param>
        /// <param name="convertedOn">converted_on.</param>
        /// <param name="status">status.</param>
        /// <param name="installmentPlans">installment_plans.</param>
        /// <param name="minPremium">min_premium.</param>
        /// <param name="stateTax">state_tax.</param>
        /// <param name="stateFees">state_fees.</param>
        /// <param name="serviceFees">service_fees.</param>
        /// <param name="billingFees">billing_fees.</param>
        public Attributes9(
            Models.PolicyState2Enum policyState,
            DateTime effectiveDate,
            DateTime termEndDate,
            string limit = null,
            string deductible = null,
            string externalReference = null,
            object metadata = null,
            DateTime? bindableOn = null,
            string termPremium = null,
            DateTime? validUntil = null,
            DateTime? convertableOn = null,
            DateTime? convertedOn = null,
            Models.Status2Enum? status = null,
            object installmentPlans = null,
            string minPremium = null,
            string stateTax = null,
            string stateFees = null,
            string serviceFees = null,
            string billingFees = null)
        {
            this.Limit = limit;
            this.Deductible = deductible;
            this.PolicyState = policyState;
            this.EffectiveDate = effectiveDate;
            this.TermEndDate = termEndDate;
            this.ExternalReference = externalReference;
            this.Metadata = metadata;
            this.BindableOn = bindableOn;
            this.TermPremium = termPremium;
            this.ValidUntil = validUntil;
            this.ConvertableOn = convertableOn;
            this.ConvertedOn = convertedOn;
            this.Status = status;
            this.InstallmentPlans = installmentPlans;
            this.MinPremium = minPremium;
            this.StateTax = stateTax;
            this.StateFees = stateFees;
            this.ServiceFees = serviceFees;
            this.BillingFees = billingFees;
        }

        /// <summary>
        /// A value from the set denoting the user-selected limit of coverage. This is dependent
        /// on the product's configuration.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// A value from the set denoting the user-selected deductible of coverage. This is dependent
        /// on the product's configuration.
        /// </summary>
        [JsonProperty("deductible", NullValueHandling = NullValueHandling.Ignore)]
        public string Deductible { get; set; }

        /// <summary>
        /// The two letter state code (including Washington DC).
        /// </summary>
        [JsonProperty("policy_state")]
        public Models.PolicyState2Enum PolicyState { get; set; }

        /// <summary>
        /// Effective date for when the resulting policy would go into effective should it be generated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("effective_date")]
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// The desired end date for the policy that results from this quote. The span from effective_date to this term_end_date must be allowable by the product's terms.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("term_end_date")]
        public DateTime TermEndDate { get; set; }

        /// <summary>
        /// Any value you wish to associate with this policy such as an ID from your system.
        /// </summary>
        [JsonProperty("external_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// Additional data about the policy. The required metadata fields are specific to the product.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object Metadata { get; set; }

        /// <summary>
        /// The date this quote was rated and set to bindable.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("bindable_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BindableOn { get; set; }

        /// <summary>
        /// Boost generated term premium for this quote.
        /// </summary>
        [JsonProperty("term_premium", NullValueHandling = NullValueHandling.Ignore)]
        public string TermPremium { get; set; }

        /// <summary>
        /// The date this quote is valid until after which point a new quote will need to be generated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("valid_until", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// The date this quote satisfied all its dependencies to become a policy.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("convertable_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ConvertableOn { get; set; }

        /// <summary>
        /// The date this quote was converted into a policy.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("converted_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ConvertedOn { get; set; }

        /// <summary>
        /// The status of the quote.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Status2Enum? Status { get; set; }

        /// <summary>
        /// Payment installment plans that are available for this quote
        /// </summary>
        [JsonProperty("installment_plans", NullValueHandling = NullValueHandling.Ignore)]
        public object InstallmentPlans { get; set; }

        /// <summary>
        /// Boost generated minimum premium for this product.
        /// </summary>
        [JsonProperty("min_premium", NullValueHandling = NullValueHandling.Ignore)]
        public string MinPremium { get; set; }

        /// <summary>
        /// Any state taxes that apply to this quote.
        /// </summary>
        [JsonProperty("state_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string StateTax { get; set; }

        /// <summary>
        /// Any state fees that apply to this quote.
        /// </summary>
        [JsonProperty("state_fees", NullValueHandling = NullValueHandling.Ignore)]
        public string StateFees { get; set; }

        /// <summary>
        /// Any service fees that apply to this quote.
        /// </summary>
        [JsonProperty("service_fees", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceFees { get; set; }

        /// <summary>
        /// Any billing fees that apply to this quote.
        /// </summary>
        [JsonProperty("billing_fees", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingFees { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes9 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes9 other &&                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Deductible == null && other.Deductible == null) || (this.Deductible?.Equals(other.Deductible) == true)) &&
                this.PolicyState.Equals(other.PolicyState) &&
                this.EffectiveDate.Equals(other.EffectiveDate) &&
                this.TermEndDate.Equals(other.TermEndDate) &&
                ((this.ExternalReference == null && other.ExternalReference == null) || (this.ExternalReference?.Equals(other.ExternalReference) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.BindableOn == null && other.BindableOn == null) || (this.BindableOn?.Equals(other.BindableOn) == true)) &&
                ((this.TermPremium == null && other.TermPremium == null) || (this.TermPremium?.Equals(other.TermPremium) == true)) &&
                ((this.ValidUntil == null && other.ValidUntil == null) || (this.ValidUntil?.Equals(other.ValidUntil) == true)) &&
                ((this.ConvertableOn == null && other.ConvertableOn == null) || (this.ConvertableOn?.Equals(other.ConvertableOn) == true)) &&
                ((this.ConvertedOn == null && other.ConvertedOn == null) || (this.ConvertedOn?.Equals(other.ConvertedOn) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.InstallmentPlans == null && other.InstallmentPlans == null) || (this.InstallmentPlans?.Equals(other.InstallmentPlans) == true)) &&
                ((this.MinPremium == null && other.MinPremium == null) || (this.MinPremium?.Equals(other.MinPremium) == true)) &&
                ((this.StateTax == null && other.StateTax == null) || (this.StateTax?.Equals(other.StateTax) == true)) &&
                ((this.StateFees == null && other.StateFees == null) || (this.StateFees?.Equals(other.StateFees) == true)) &&
                ((this.ServiceFees == null && other.ServiceFees == null) || (this.ServiceFees?.Equals(other.ServiceFees) == true)) &&
                ((this.BillingFees == null && other.BillingFees == null) || (this.BillingFees?.Equals(other.BillingFees) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit)}");
            toStringOutput.Add($"this.Deductible = {(this.Deductible == null ? "null" : this.Deductible)}");
            toStringOutput.Add($"this.PolicyState = {this.PolicyState}");
            toStringOutput.Add($"this.EffectiveDate = {this.EffectiveDate}");
            toStringOutput.Add($"this.TermEndDate = {this.TermEndDate}");
            toStringOutput.Add($"this.ExternalReference = {(this.ExternalReference == null ? "null" : this.ExternalReference)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.BindableOn = {(this.BindableOn == null ? "null" : this.BindableOn.ToString())}");
            toStringOutput.Add($"this.TermPremium = {(this.TermPremium == null ? "null" : this.TermPremium)}");
            toStringOutput.Add($"this.ValidUntil = {(this.ValidUntil == null ? "null" : this.ValidUntil.ToString())}");
            toStringOutput.Add($"this.ConvertableOn = {(this.ConvertableOn == null ? "null" : this.ConvertableOn.ToString())}");
            toStringOutput.Add($"this.ConvertedOn = {(this.ConvertedOn == null ? "null" : this.ConvertedOn.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"InstallmentPlans = {(this.InstallmentPlans == null ? "null" : this.InstallmentPlans.ToString())}");
            toStringOutput.Add($"this.MinPremium = {(this.MinPremium == null ? "null" : this.MinPremium)}");
            toStringOutput.Add($"this.StateTax = {(this.StateTax == null ? "null" : this.StateTax)}");
            toStringOutput.Add($"this.StateFees = {(this.StateFees == null ? "null" : this.StateFees)}");
            toStringOutput.Add($"this.ServiceFees = {(this.ServiceFees == null ? "null" : this.ServiceFees)}");
            toStringOutput.Add($"this.BillingFees = {(this.BillingFees == null ? "null" : this.BillingFees)}");
        }
    }
}