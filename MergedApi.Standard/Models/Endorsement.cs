// <copyright file="Endorsement.cs" company="APIMatic">
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
    /// Endorsement.
    /// </summary>
    public class Endorsement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endorsement"/> class.
        /// </summary>
        public Endorsement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Endorsement"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public Endorsement(
            Models.Data20 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Provided data for this endorsement relationship.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data20 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Endorsement : ({string.Join(", ", toStringOutput)})";
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
            return obj is Endorsement other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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