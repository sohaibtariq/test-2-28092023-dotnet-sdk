// <copyright file="Relationships4.cs" company="APIMatic">
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
    /// Relationships4.
    /// </summary>
    public class Relationships4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships4"/> class.
        /// </summary>
        public Relationships4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships4"/> class.
        /// </summary>
        /// <param name="policy">policy.</param>
        /// <param name="endorsement">endorsement.</param>
        /// <param name="coverage">coverage.</param>
        public Relationships4(
            Models.Policy policy,
            Models.Endorsement endorsement,
            Models.Coverage coverage)
        {
            this.Policy = policy;
            this.Endorsement = endorsement;
            this.Coverage = coverage;
        }

        /// <summary>
        /// UUID that identifies this policy.
        /// </summary>
        [JsonProperty("policy")]
        public Models.Policy Policy { get; set; }

        /// <summary>
        /// UUID that identifies this endorsement.
        /// </summary>
        [JsonProperty("endorsement")]
        public Models.Endorsement Endorsement { get; set; }

        /// <summary>
        /// UUID that identifies this product coverage.
        /// </summary>
        [JsonProperty("coverage")]
        public Models.Coverage Coverage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships4 other &&                ((this.Policy == null && other.Policy == null) || (this.Policy?.Equals(other.Policy) == true)) &&
                ((this.Endorsement == null && other.Endorsement == null) || (this.Endorsement?.Equals(other.Endorsement) == true)) &&
                ((this.Coverage == null && other.Coverage == null) || (this.Coverage?.Equals(other.Coverage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Policy = {(this.Policy == null ? "null" : this.Policy.ToString())}");
            toStringOutput.Add($"this.Endorsement = {(this.Endorsement == null ? "null" : this.Endorsement.ToString())}");
            toStringOutput.Add($"this.Coverage = {(this.Coverage == null ? "null" : this.Coverage.ToString())}");
        }
    }
}