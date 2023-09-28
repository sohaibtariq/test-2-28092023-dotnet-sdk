// <copyright file="Included32.cs" company="APIMatic">
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
    /// Included32.
    /// </summary>
    public class Included32
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Included32"/> class.
        /// </summary>
        public Included32()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Included32"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="lid">lid.</param>
        /// <param name="attributes">attributes.</param>
        public Included32(
            string type,
            string lid,
            Models.Attributes12 attributes)
        {
            this.Type = type;
            this.Lid = lid;
            this.Attributes = attributes;
        }

        /// <summary>
        /// The type of resource being represented.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The local ID that ties this resource to a related object in `data.relationships`.
        /// </summary>
        [JsonProperty("lid")]
        public string Lid { get; set; }

        /// <summary>
        /// The insured risk.
        /// </summary>
        [JsonProperty("attributes")]
        public Models.Attributes12 Attributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Included32 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Included32 other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Lid == null && other.Lid == null) || (this.Lid?.Equals(other.Lid) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Lid = {(this.Lid == null ? "null" : this.Lid)}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
        }
    }
}