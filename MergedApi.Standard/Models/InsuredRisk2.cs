// <copyright file="InsuredRisk2.cs" company="APIMatic">
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
    /// InsuredRisk2.
    /// </summary>
    public class InsuredRisk2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsuredRisk2"/> class.
        /// </summary>
        public InsuredRisk2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsuredRisk2"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public InsuredRisk2(
            Models.Data42 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Provided data for this insured risk relationship with local ID.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data42 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InsuredRisk2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is InsuredRisk2 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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