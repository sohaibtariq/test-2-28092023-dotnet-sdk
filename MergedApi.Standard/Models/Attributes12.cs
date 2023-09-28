// <copyright file="Attributes12.cs" company="APIMatic">
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
    /// Attributes12.
    /// </summary>
    public class Attributes12
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes12"/> class.
        /// </summary>
        public Attributes12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes12"/> class.
        /// </summary>
        /// <param name="factors">factors.</param>
        public Attributes12(
            object factors)
        {
            this.Factors = factors;
        }

        /// <summary>
        /// Object representation of the insured risk.
        /// </summary>
        [JsonProperty("factors")]
        public object Factors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes12 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes12 other &&                ((this.Factors == null && other.Factors == null) || (this.Factors?.Equals(other.Factors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Factors = {(this.Factors == null ? "null" : this.Factors.ToString())}");
        }
    }
}