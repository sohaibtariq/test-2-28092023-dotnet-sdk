// <copyright file="Attributes10.cs" company="APIMatic">
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
    /// Attributes10.
    /// </summary>
    public class Attributes10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes10"/> class.
        /// </summary>
        public Attributes10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes10"/> class.
        /// </summary>
        /// <param name="deductible">deductible.</param>
        /// <param name="limit">limit.</param>
        /// <param name="premium">premium.</param>
        /// <param name="metadata">metadata.</param>
        public Attributes10(
            string deductible = null,
            string limit = null,
            string premium = null,
            object metadata = null)
        {
            this.Deductible = deductible;
            this.Limit = limit;
            this.Premium = premium;
            this.Metadata = metadata;
        }

        /// <summary>
        /// A value from the set denoting the user-selected deductible of coverage. This is dependent
        /// on the product's configuration.
        /// </summary>
        [JsonProperty("deductible", NullValueHandling = NullValueHandling.Ignore)]
        public string Deductible { get; set; }

        /// <summary>
        /// A value from the set denoting the user-selected limit of coverage. This is dependent
        /// on the product's configuration.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// Calculated premium for this coverage which is included in the policy's term premium.
        /// </summary>
        [JsonProperty("premium", NullValueHandling = NullValueHandling.Ignore)]
        public string Premium { get; set; }

        /// <summary>
        /// Additional data about the policy. The required metadata fields are specific to the product.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object Metadata { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes10 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes10 other &&                ((this.Deductible == null && other.Deductible == null) || (this.Deductible?.Equals(other.Deductible) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Premium == null && other.Premium == null) || (this.Premium?.Equals(other.Premium) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Deductible = {(this.Deductible == null ? "null" : this.Deductible)}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit)}");
            toStringOutput.Add($"this.Premium = {(this.Premium == null ? "null" : this.Premium)}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
        }
    }
}