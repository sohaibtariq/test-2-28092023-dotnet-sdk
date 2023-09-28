// <copyright file="Data46.cs" company="APIMatic">
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
    /// Data46.
    /// </summary>
    public class Data46
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data46"/> class.
        /// </summary>
        public Data46()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data46"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        public Data46(
            string type,
            Guid id)
        {
            this.Type = type;
            this.Id = id;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data46 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data46 other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Id.Equals(other.Id);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Id = {this.Id}");
        }
    }
}