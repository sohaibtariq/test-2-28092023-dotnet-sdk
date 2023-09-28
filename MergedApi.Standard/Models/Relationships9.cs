// <copyright file="Relationships9.cs" company="APIMatic">
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
    /// Relationships9.
    /// </summary>
    public class Relationships9
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships9"/> class.
        /// </summary>
        public Relationships9()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships9"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        /// <param name="product">product.</param>
        /// <param name="coverages">coverages.</param>
        /// <param name="insuredRisk">insured_risk.</param>
        public Relationships9(
            Models.Customer2 customer,
            Models.Product6 product,
            Models.Coverages2 coverages = null,
            Models.InsuredRisk2 insuredRisk = null)
        {
            this.Coverages = coverages;
            this.Customer = customer;
            this.InsuredRisk = insuredRisk;
            this.Product = product;
        }

        /// <summary>
        /// List of coverages that will be created at the same time as this resource.
        /// </summary>
        [JsonProperty("coverages", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Coverages2 Coverages { get; set; }

        /// <summary>
        /// Customer that will be created at the same time as this resource.
        /// </summary>
        [JsonProperty("customer")]
        public Models.Customer2 Customer { get; set; }

        /// <summary>
        /// Insured risk that will be created at the same time as this resource.
        /// </summary>
        [JsonProperty("insured_risk", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InsuredRisk2 InsuredRisk { get; set; }

        /// <summary>
        /// Boost supplied value representing the specific product type. The product's configuration
        /// will determine allowable values for the Policy, such as limit and deductible.
        /// </summary>
        [JsonProperty("product")]
        public Models.Product6 Product { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships9 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships9 other &&                ((this.Coverages == null && other.Coverages == null) || (this.Coverages?.Equals(other.Coverages) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.InsuredRisk == null && other.InsuredRisk == null) || (this.InsuredRisk?.Equals(other.InsuredRisk) == true)) &&
                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true));
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
        }
    }
}