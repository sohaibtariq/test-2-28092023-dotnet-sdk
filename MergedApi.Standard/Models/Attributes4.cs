// <copyright file="Attributes4.cs" company="APIMatic">
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
    /// Attributes4.
    /// </summary>
    public class Attributes4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes4"/> class.
        /// </summary>
        public Attributes4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes4"/> class.
        /// </summary>
        /// <param name="createdDate">created_date.</param>
        /// <param name="modifiedDate">modified_date.</param>
        /// <param name="deductible">deductible.</param>
        /// <param name="limit">limit.</param>
        /// <param name="premium">premium.</param>
        /// <param name="additionalFees">additional_fees.</param>
        /// <param name="revisionDate">revision_date.</param>
        public Attributes4(
            DateTime createdDate,
            DateTime modifiedDate,
            string deductible,
            string limit,
            string premium,
            string additionalFees,
            DateTime revisionDate)
        {
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.Deductible = deductible;
            this.Limit = limit;
            this.Premium = premium;
            this.AdditionalFees = additionalFees;
            this.RevisionDate = revisionDate;
        }

        /// <summary>
        /// Date time when this resource was created in our system.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date time when this resource was last modified in our system.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("modified_date")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// A value from the set denoting the user-selected deductible of coverage. This is dependent
        /// on the product's configuration.
        /// </summary>
        [JsonProperty("deductible")]
        public string Deductible { get; set; }

        /// <summary>
        /// A value from the set denoting the user-selected limit of coverage. This is dependent
        /// on the product's configuration.
        /// </summary>
        [JsonProperty("limit")]
        public string Limit { get; set; }

        /// <summary>
        /// Term premium for this coverage
        /// </summary>
        [JsonProperty("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// Additional fees relating to this coverage.
        /// </summary>
        [JsonProperty("additional_fees")]
        public string AdditionalFees { get; set; }

        /// <summary>
        /// Date for when this coverage goes into effect on the policy.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("revision_date")]
        public DateTime RevisionDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes4 other &&                this.CreatedDate.Equals(other.CreatedDate) &&
                this.ModifiedDate.Equals(other.ModifiedDate) &&
                ((this.Deductible == null && other.Deductible == null) || (this.Deductible?.Equals(other.Deductible) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Premium == null && other.Premium == null) || (this.Premium?.Equals(other.Premium) == true)) &&
                ((this.AdditionalFees == null && other.AdditionalFees == null) || (this.AdditionalFees?.Equals(other.AdditionalFees) == true)) &&
                this.RevisionDate.Equals(other.RevisionDate);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatedDate = {this.CreatedDate}");
            toStringOutput.Add($"this.ModifiedDate = {this.ModifiedDate}");
            toStringOutput.Add($"this.Deductible = {(this.Deductible == null ? "null" : this.Deductible)}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit)}");
            toStringOutput.Add($"this.Premium = {(this.Premium == null ? "null" : this.Premium)}");
            toStringOutput.Add($"this.AdditionalFees = {(this.AdditionalFees == null ? "null" : this.AdditionalFees)}");
            toStringOutput.Add($"this.RevisionDate = {this.RevisionDate}");
        }
    }
}