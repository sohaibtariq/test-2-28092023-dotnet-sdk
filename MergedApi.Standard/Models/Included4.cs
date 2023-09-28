// <copyright file="Included4.cs" company="APIMatic">
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
    /// Included4.
    /// </summary>
    public class Included4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Included4"/> class.
        /// </summary>
        public Included4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Included4"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        /// <param name="lid">lid.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="relationships">relationships.</param>
        public Included4(
            string type,
            Guid id,
            string lid,
            Models.Attributes10 attributes,
            Models.Relationships10 relationships)
        {
            this.Type = type;
            this.Id = id;
            this.Lid = lid;
            this.Attributes = attributes;
            this.Relationships = relationships;
        }

        /// <summary>
        /// The type of resource being represented.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Unique Boost-generated UUID that identifies this resource.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The local ID that ties this resource to a related object in `data.relationships`.
        /// </summary>
        [JsonProperty("lid")]
        public string Lid { get; set; }

        /// <summary>
        /// Attributes for this object.
        /// </summary>
        [JsonProperty("attributes")]
        public Models.Attributes10 Attributes { get; set; }

        /// <summary>
        /// Related items.
        /// </summary>
        [JsonProperty("relationships")]
        public Models.Relationships10 Relationships { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Included4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Included4 other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Id.Equals(other.Id) &&
                ((this.Lid == null && other.Lid == null) || (this.Lid?.Equals(other.Lid) == true)) &&
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
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Lid = {(this.Lid == null ? "null" : this.Lid)}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.Relationships = {(this.Relationships == null ? "null" : this.Relationships.ToString())}");
        }
    }
}