// <copyright file="QuotesRequest.cs" company="APIMatic">
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
    /// QuotesRequest.
    /// </summary>
    public class QuotesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesRequest"/> class.
        /// </summary>
        public QuotesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesRequest"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="included">included.</param>
        public QuotesRequest(
            Models.Data39 data,
            object included)
        {
            this.Data = data;
            this.Included = included;
        }

        /// <summary>
        /// All values for the request are in this top-level object.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data39 Data { get; set; }

        /// <summary>
        /// Array of included objects.
        /// </summary>
        [JsonProperty("included")]
        public object Included { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QuotesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is QuotesRequest other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
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