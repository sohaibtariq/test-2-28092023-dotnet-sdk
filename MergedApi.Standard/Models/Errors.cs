// <copyright file="Errors.cs" company="APIMatic">
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
    /// Errors.
    /// </summary>
    public class Errors
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Errors"/> class.
        /// </summary>
        public Errors()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Errors"/> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="errorDescription">error_description.</param>
        public Errors(
            string error = null,
            string errorDescription = null)
        {
            this.Error = error;
            this.ErrorDescription = errorDescription;
        }

        /// <summary>
        /// Type of error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <summary>
        /// Detailed information about the error.
        /// </summary>
        [JsonProperty("error_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Errors : ({string.Join(", ", toStringOutput)})";
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
            return obj is Errors other &&                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.ErrorDescription == null && other.ErrorDescription == null) || (this.ErrorDescription?.Equals(other.ErrorDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error)}");
            toStringOutput.Add($"this.ErrorDescription = {(this.ErrorDescription == null ? "null" : this.ErrorDescription)}");
        }
    }
}