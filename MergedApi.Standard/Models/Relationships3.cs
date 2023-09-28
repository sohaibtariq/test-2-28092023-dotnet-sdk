// <copyright file="Relationships3.cs" company="APIMatic">
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
    /// Relationships3.
    /// </summary>
    public class Relationships3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships3"/> class.
        /// </summary>
        public Relationships3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships3"/> class.
        /// </summary>
        /// <param name="coverages">coverages.</param>
        /// <param name="insuredRisk">insured_risk.</param>
        /// <param name="customer">customer.</param>
        /// <param name="product">product.</param>
        /// <param name="parent">parent.</param>
        /// <param name="additionalInterests">additional_interests.</param>
        /// <param name="additionalInsured">additional_insured.</param>
        /// <param name="agent">agent.</param>
        /// <param name="installmentPlan">installment_plan.</param>
        public Relationships3(
            Models.Coverages coverages,
            Models.InsuredRisk insuredRisk,
            Models.Customer customer,
            Models.Product2 product,
            Models.Parent parent,
            Models.AdditionalInterests additionalInterests,
            Models.AdditionalInsured additionalInsured,
            Models.Agent agent,
            Models.InstallmentPlan installmentPlan)
        {
            this.Coverages = coverages;
            this.InsuredRisk = insuredRisk;
            this.Customer = customer;
            this.Product = product;
            this.Parent = parent;
            this.AdditionalInterests = additionalInterests;
            this.AdditionalInsured = additionalInsured;
            this.Agent = agent;
            this.InstallmentPlan = installmentPlan;
        }

        /// <summary>
        /// List of coverages that apply to this policy.
        /// </summary>
        [JsonProperty("coverages")]
        public Models.Coverages Coverages { get; set; }

        /// <summary>
        /// The risk insured by the policy.
        /// </summary>
        [JsonProperty("insured_risk")]
        public Models.InsuredRisk InsuredRisk { get; set; }

        /// <summary>
        /// Relationship containing the id that identifies the customer for this policy.
        /// </summary>
        [JsonProperty("customer")]
        public Models.Customer Customer { get; set; }

        /// <summary>
        /// Boost supplied value representing the specific product type. The product's configuration
        /// Determines allowable values, such as limit and deductible.
        /// </summary>
        [JsonProperty("product")]
        public Models.Product2 Product { get; set; }

        /// <summary>
        /// ID of parent policy. Product must also be a parent product.
        /// </summary>
        [JsonProperty("parent")]
        public Models.Parent Parent { get; set; }

        /// <summary>
        /// List of additional interests for this policy.
        /// </summary>
        [JsonProperty("additional_interests")]
        public Models.AdditionalInterests AdditionalInterests { get; set; }

        /// <summary>
        /// List of additional insured for this policy.
        /// </summary>
        [JsonProperty("additional_insured")]
        public Models.AdditionalInsured AdditionalInsured { get; set; }

        /// <summary>
        /// UUID of the agent.
        /// </summary>
        [JsonProperty("agent")]
        public Models.Agent Agent { get; set; }

        /// <summary>
        /// The Boost UUID for the `installment_plan` based on the chosen installment plan.
        /// </summary>
        [JsonProperty("installment_plan")]
        public Models.InstallmentPlan InstallmentPlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships3 other &&                ((this.Coverages == null && other.Coverages == null) || (this.Coverages?.Equals(other.Coverages) == true)) &&
                ((this.InsuredRisk == null && other.InsuredRisk == null) || (this.InsuredRisk?.Equals(other.InsuredRisk) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true)) &&
                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true)) &&
                ((this.AdditionalInterests == null && other.AdditionalInterests == null) || (this.AdditionalInterests?.Equals(other.AdditionalInterests) == true)) &&
                ((this.AdditionalInsured == null && other.AdditionalInsured == null) || (this.AdditionalInsured?.Equals(other.AdditionalInsured) == true)) &&
                ((this.Agent == null && other.Agent == null) || (this.Agent?.Equals(other.Agent) == true)) &&
                ((this.InstallmentPlan == null && other.InstallmentPlan == null) || (this.InstallmentPlan?.Equals(other.InstallmentPlan) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Coverages = {(this.Coverages == null ? "null" : this.Coverages.ToString())}");
            toStringOutput.Add($"this.InsuredRisk = {(this.InsuredRisk == null ? "null" : this.InsuredRisk.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product.ToString())}");
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
            toStringOutput.Add($"this.AdditionalInterests = {(this.AdditionalInterests == null ? "null" : this.AdditionalInterests.ToString())}");
            toStringOutput.Add($"this.AdditionalInsured = {(this.AdditionalInsured == null ? "null" : this.AdditionalInsured.ToString())}");
            toStringOutput.Add($"this.Agent = {(this.Agent == null ? "null" : this.Agent.ToString())}");
            toStringOutput.Add($"this.InstallmentPlan = {(this.InstallmentPlan == null ? "null" : this.InstallmentPlan.ToString())}");
        }
    }
}