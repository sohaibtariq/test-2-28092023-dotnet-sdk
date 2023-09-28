// <copyright file="BillingAddress.cs" company="APIMatic">
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
    /// BillingAddress.
    /// </summary>
    public class BillingAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress"/> class.
        /// </summary>
        public BillingAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress"/> class.
        /// </summary>
        /// <param name="address1">address1.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="address2">address2.</param>
        public BillingAddress(
            string address1,
            string city,
            Models.StateEnum state,
            string zip,
            string address2 = null)
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public string Address2 { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Two letter state code of the address.
        /// </summary>
        [JsonProperty("state")]
        public Models.StateEnum State { get; set; }

        /// <summary>
        /// 5 or 10 character postal code of the address.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingAddress : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingAddress other &&                ((this.Address1 == null && other.Address1 == null) || (this.Address1?.Equals(other.Address1) == true)) &&
                ((this.Address2 == null && other.Address2 == null) || (this.Address2?.Equals(other.Address2) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                this.State.Equals(other.State) &&
                ((this.Zip == null && other.Zip == null) || (this.Zip?.Equals(other.Zip) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address1 = {(this.Address1 == null ? "null" : this.Address1)}");
            toStringOutput.Add($"this.Address2 = {(this.Address2 == null ? "null" : this.Address2)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {this.State}");
            toStringOutput.Add($"this.Zip = {(this.Zip == null ? "null" : this.Zip)}");
        }
    }
}