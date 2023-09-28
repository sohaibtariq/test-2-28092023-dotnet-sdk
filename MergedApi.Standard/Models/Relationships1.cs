// <copyright file="Relationships1.cs" company="APIMatic">
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
    /// Relationships1.
    /// </summary>
    public class Relationships1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships1"/> class.
        /// </summary>
        public Relationships1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships1"/> class.
        /// </summary>
        /// <param name="agent">agent.</param>
        /// <param name="product">product.</param>
        public Relationships1(
            Models.Agent agent,
            Models.Product product)
        {
            this.Agent = agent;
            this.Product = product;
        }

        /// <summary>
        /// UUID of the agent.
        /// </summary>
        [JsonProperty("agent")]
        public Models.Agent Agent { get; set; }

        /// <summary>
        /// Boost supplied value representing the specific product type. The product's configuration
        /// Determines allowable values, such as limits and deductibles.
        /// </summary>
        [JsonProperty("product")]
        public Models.Product Product { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships1 other &&                ((this.Agent == null && other.Agent == null) || (this.Agent?.Equals(other.Agent) == true)) &&
                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Agent = {(this.Agent == null ? "null" : this.Agent.ToString())}");
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product.ToString())}");
        }
    }
}