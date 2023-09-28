// <copyright file="Attributes5.cs" company="APIMatic">
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
    /// Attributes5.
    /// </summary>
    public class Attributes5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes5"/> class.
        /// </summary>
        public Attributes5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes5"/> class.
        /// </summary>
        /// <param name="createdDate">created_date.</param>
        /// <param name="modifiedDate">modified_date.</param>
        /// <param name="factors">factors.</param>
        public Attributes5(
            DateTime createdDate,
            DateTime modifiedDate,
            object factors)
        {
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.Factors = factors;
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
        /// Specific ratable factors that apply to this Insured Risk. The content must fully adhere to a product-specific, pre-defined schema.
        /// </summary>
        [JsonProperty("factors")]
        public object Factors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes5 other &&                this.CreatedDate.Equals(other.CreatedDate) &&
                this.ModifiedDate.Equals(other.ModifiedDate) &&
                ((this.Factors == null && other.Factors == null) || (this.Factors?.Equals(other.Factors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatedDate = {this.CreatedDate}");
            toStringOutput.Add($"this.ModifiedDate = {this.ModifiedDate}");
            toStringOutput.Add($"Factors = {(this.Factors == null ? "null" : this.Factors.ToString())}");
        }
    }
}