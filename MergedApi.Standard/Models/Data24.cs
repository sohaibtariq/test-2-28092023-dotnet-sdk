// <copyright file="Data24.cs" company="APIMatic">
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
    /// Data24.
    /// </summary>
    public class Data24
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data24"/> class.
        /// </summary>
        public Data24()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data24"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="relationships">relationships.</param>
        /// <param name="included">included.</param>
        public Data24(
            string type,
            Guid id,
            Models.Attributes6 attributes,
            Models.Relationships3 relationships,
            object included)
        {
            this.Type = type;
            this.Id = id;
            this.Attributes = attributes;
            this.Relationships = relationships;
            this.Included = included;
        }

        /// <summary>
        /// The type of resource being represented.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Attributes that describe a policy resource with optional writeable money fields.
        /// </summary>
        [JsonProperty("attributes")]
        public Models.Attributes6 Attributes { get; set; }

        /// <summary>
        /// Items related to this policy.
        /// </summary>
        [JsonProperty("relationships")]
        public Models.Relationships3 Relationships { get; set; }

        /// <summary>
        /// Array of included objects which provide additional data about an object from the
        /// above `data.relationships`.
        /// </summary>
        [JsonProperty("included")]
        public object Included { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data24 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data24 other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Id.Equals(other.Id) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.Relationships == null && other.Relationships == null) || (this.Relationships?.Equals(other.Relationships) == true)) &&
                ((this.Included == null && other.Included == null) || (this.Included?.Equals(other.Included) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.Relationships = {(this.Relationships == null ? "null" : this.Relationships.ToString())}");
            toStringOutput.Add($"Included = {(this.Included == null ? "null" : this.Included.ToString())}");
        }
    }
}