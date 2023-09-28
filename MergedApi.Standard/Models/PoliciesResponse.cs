// <copyright file="PoliciesResponse.cs" company="APIMatic">
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
    /// PoliciesResponse.
    /// </summary>
    public class PoliciesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesResponse"/> class.
        /// </summary>
        public PoliciesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="included">included.</param>
        public PoliciesResponse(
            Models.Data9 data,
            object included)
        {
            this.Data = data;
            this.Included = included;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data9 Data { get; set; }

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

            return $"PoliciesResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PoliciesResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Included == null && other.Included == null) || (this.Included?.Equals(other.Included) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"Included = {(this.Included == null ? "null" : this.Included.ToString())}");
        }
    }
}