// <copyright file="Relationships2.cs" company="APIMatic">
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
    /// Relationships2.
    /// </summary>
    public class Relationships2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships2"/> class.
        /// </summary>
        public Relationships2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships2"/> class.
        /// </summary>
        /// <param name="additionalInterests">additional_interests.</param>
        /// <param name="parent">parent.</param>
        public Relationships2(
            Models.AdditionalInterests additionalInterests = null,
            Models.Parent parent = null)
        {
            this.AdditionalInterests = additionalInterests;
            this.Parent = parent;
        }

        /// <summary>
        /// List of additional interests for this policy.
        /// </summary>
        [JsonProperty("additional_interests", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AdditionalInterests AdditionalInterests { get; set; }

        /// <summary>
        /// ID of parent policy. Product must also be a parent product.
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Parent Parent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships2 other &&                ((this.AdditionalInterests == null && other.AdditionalInterests == null) || (this.AdditionalInterests?.Equals(other.AdditionalInterests) == true)) &&
                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdditionalInterests = {(this.AdditionalInterests == null ? "null" : this.AdditionalInterests.ToString())}");
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
        }
    }
}