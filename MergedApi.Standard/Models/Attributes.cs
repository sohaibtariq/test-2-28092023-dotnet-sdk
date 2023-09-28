// <copyright file="Attributes.cs" company="APIMatic">
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
    /// Attributes.
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// </summary>
        public Attributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// </summary>
        /// <param name="factors">factors.</param>
        /// <param name="createdDate">created_date.</param>
        /// <param name="modifiedDate">modified_date.</param>
        public Attributes(
            object factors,
            DateTime? createdDate = null,
            DateTime? modifiedDate = null)
        {
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.Factors = factors;
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
        /// Specific ratable factors that apply to this Insured Risk. The content must fully adhere to a product-specific, pre-defined schema.
        /// </summary>
        [JsonProperty("factors")]
        public object Factors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes other &&                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.ModifiedDate == null && other.ModifiedDate == null) || (this.ModifiedDate?.Equals(other.ModifiedDate) == true)) &&
                ((this.Factors == null && other.Factors == null) || (this.Factors?.Equals(other.Factors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.ModifiedDate = {(this.ModifiedDate == null ? "null" : this.ModifiedDate.ToString())}");
            toStringOutput.Add($"Factors = {(this.Factors == null ? "null" : this.Factors.ToString())}");
        }
    }
}