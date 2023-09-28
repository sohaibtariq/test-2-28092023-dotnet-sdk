// <copyright file="Relationships5.cs" company="APIMatic">
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
    /// Relationships5.
    /// </summary>
    public class Relationships5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships5"/> class.
        /// </summary>
        public Relationships5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships5"/> class.
        /// </summary>
        /// <param name="product">product.</param>
        /// <param name="agent">agent.</param>
        public Relationships5(
            Models.Product3 product,
            Models.Agent3 agent)
        {
            this.Product = product;
            this.Agent = agent;
        }

        /// <summary>
        /// UUID that identifies this product.
        /// </summary>
        [JsonProperty("product")]
        public Models.Product3 Product { get; set; }

        /// <summary>
        /// UUID that identifies this agent.
        /// </summary>
        [JsonProperty("agent")]
        public Models.Agent3 Agent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships5 other &&                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true)) &&
                ((this.Agent == null && other.Agent == null) || (this.Agent?.Equals(other.Agent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product.ToString())}");
            toStringOutput.Add($"this.Agent = {(this.Agent == null ? "null" : this.Agent.ToString())}");
        }
    }
}