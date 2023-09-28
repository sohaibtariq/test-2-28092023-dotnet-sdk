// <copyright file="Data6.cs" company="APIMatic">
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
    /// Data6.
    /// </summary>
    public class Data6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        public Data6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="relationships">relationships.</param>
        public Data6(
            string type,
            Models.Attributes2 attributes,
            Models.Relationships2 relationships)
        {
            this.Type = type;
            this.Attributes = attributes;
            this.Relationships = relationships;
        }

        /// <summary>
        /// The type of resource being represented.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Attributes for this policy.
        /// </summary>
        [JsonProperty("attributes")]
        public Models.Attributes2 Attributes { get; set; }

        /// <summary>
        /// Related items.
        /// </summary>
        [JsonProperty("relationships")]
        public Models.Relationships2 Relationships { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data6 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data6 other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.Relationships == null && other.Relationships == null) || (this.Relationships?.Equals(other.Relationships) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.Relationships = {(this.Relationships == null ? "null" : this.Relationships.ToString())}");
        }
    }
}