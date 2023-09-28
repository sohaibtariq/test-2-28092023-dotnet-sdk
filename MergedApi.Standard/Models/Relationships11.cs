// <copyright file="Relationships11.cs" company="APIMatic">
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
    /// Relationships11.
    /// </summary>
    public class Relationships11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships11"/> class.
        /// </summary>
        public Relationships11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships11"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="insuredRisk">insured_risk.</param>
        /// <param name="product">product.</param>
        /// <param name="coverages">coverages.</param>
        /// <param name="agent">agent.</param>
        public Relationships11(
            Models.Customer3 customer,
            Models.InsuredRisk3 insuredRisk,
            Models.Product6 product,
            Models.Coverages3 coverages = null,
            Models.Agent6 agent = null)
        {
            this.Coverages = coverages;
            this.Customer = customer;
            this.InsuredRisk = insuredRisk;
            this.Product = product;
            this.Agent = agent;
        }

        /// <summary>
        /// List of coverages that were created.
        /// </summary>
        [JsonProperty("coverages", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Coverages3 Coverages { get; set; }

        /// <summary>
        /// Customer that was created.
        /// </summary>
        [JsonProperty("customer")]
        public Models.Customer3 Customer { get; set; }

        /// <summary>
        /// Insured risk attached to the quote.
        /// </summary>
        [JsonProperty("insured_risk")]
        public Models.InsuredRisk3 InsuredRisk { get; set; }

        /// <summary>
        /// Boost supplied value representing the specific product type. The product's configuration
        /// will determine allowable values for the Policy, such as limit and deductible.
        /// </summary>
        [JsonProperty("product")]
        public Models.Product6 Product { get; set; }

        /// <summary>
        /// The Boost UUID of the agent.
        /// </summary>
        [JsonProperty("agent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Agent6 Agent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships11 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships11 other &&                ((this.Coverages == null && other.Coverages == null) || (this.Coverages?.Equals(other.Coverages) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.InsuredRisk == null && other.InsuredRisk == null) || (this.InsuredRisk?.Equals(other.InsuredRisk) == true)) &&
                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true)) &&
                ((this.Agent == null && other.Agent == null) || (this.Agent?.Equals(other.Agent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Coverages = {(this.Coverages == null ? "null" : this.Coverages.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.InsuredRisk = {(this.InsuredRisk == null ? "null" : this.InsuredRisk.ToString())}");
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product.ToString())}");
            toStringOutput.Add($"this.Agent = {(this.Agent == null ? "null" : this.Agent.ToString())}");
        }
    }
}