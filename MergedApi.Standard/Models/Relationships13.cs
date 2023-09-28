// <copyright file="Relationships13.cs" company="APIMatic">
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
    /// Relationships13.
    /// </summary>
    public class Relationships13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships13"/> class.
        /// </summary>
        public Relationships13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships13"/> class.
        /// </summary>
        /// <param name="agent">agent.</param>
        public Relationships13(
            Models.Agent6 agent)
        {
            this.Agent = agent;
        }

        /// <summary>
        /// The Boost UUID of the agent.
        /// </summary>
        [JsonProperty("agent")]
        public Models.Agent6 Agent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships13 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships13 other &&                ((this.Agent == null && other.Agent == null) || (this.Agent?.Equals(other.Agent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Agent = {(this.Agent == null ? "null" : this.Agent.ToString())}");
        }
    }
}