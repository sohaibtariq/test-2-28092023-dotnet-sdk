// <copyright file="Relationships10.cs" company="APIMatic">
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
    /// Relationships10.
    /// </summary>
    public class Relationships10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships10"/> class.
        /// </summary>
        public Relationships10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships10"/> class.
        /// </summary>
        /// <param name="productCoverage">product_coverage.</param>
        public Relationships10(
            Models.ProductCoverage productCoverage)
        {
            this.ProductCoverage = productCoverage;
        }

        /// <summary>
        /// Product coverage that applies to this policy.
        /// </summary>
        [JsonProperty("product_coverage")]
        public Models.ProductCoverage ProductCoverage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships10 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships10 other &&                ((this.ProductCoverage == null && other.ProductCoverage == null) || (this.ProductCoverage?.Equals(other.ProductCoverage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductCoverage = {(this.ProductCoverage == null ? "null" : this.ProductCoverage.ToString())}");
        }
    }
}