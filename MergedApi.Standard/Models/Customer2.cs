// <copyright file="Customer2.cs" company="APIMatic">
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
    /// Customer2.
    /// </summary>
    public class Customer2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer2"/> class.
        /// </summary>
        public Customer2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer2"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public Customer2(
            Models.Data41 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Provided data for this customer relationship with local ID.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data41 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Customer2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Customer2 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}