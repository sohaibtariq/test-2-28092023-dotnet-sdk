// <copyright file="Attributes2.cs" company="APIMatic">
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
    /// Attributes2.
    /// </summary>
    public class Attributes2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes2"/> class.
        /// </summary>
        public Attributes2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes2"/> class.
        /// </summary>
        /// <param name="quoteNumber">quote_number.</param>
        /// <param name="installmentPlan">installment_plan.</param>
        /// <param name="stripeToken">stripe_token.</param>
        /// <param name="externalId">external_id.</param>
        public Attributes2(
            string quoteNumber,
            string installmentPlan,
            string stripeToken,
            string externalId = null)
        {
            this.QuoteNumber = quoteNumber;
            this.InstallmentPlan = installmentPlan;
            this.StripeToken = stripeToken;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Quote number received from quote creation.
        /// </summary>
        [JsonProperty("quote_number")]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// Value from the set which controls invoicing and billing. This is dependent
        /// on your product's configuration.
        /// </summary>
        [JsonProperty("installment_plan")]
        public string InstallmentPlan { get; set; }

        /// <summary>
        /// Stripe credit card token that will be used for charge authorization.
        /// </summary>
        [JsonProperty("stripe_token")]
        public string StripeToken { get; set; }

        /// <summary>
        /// Any value you wish to associate with this resource such as an ID from your system.
        /// </summary>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes2 other &&                ((this.QuoteNumber == null && other.QuoteNumber == null) || (this.QuoteNumber?.Equals(other.QuoteNumber) == true)) &&
                ((this.InstallmentPlan == null && other.InstallmentPlan == null) || (this.InstallmentPlan?.Equals(other.InstallmentPlan) == true)) &&
                ((this.StripeToken == null && other.StripeToken == null) || (this.StripeToken?.Equals(other.StripeToken) == true)) &&
                ((this.ExternalId == null && other.ExternalId == null) || (this.ExternalId?.Equals(other.ExternalId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.QuoteNumber = {(this.QuoteNumber == null ? "null" : this.QuoteNumber)}");
            toStringOutput.Add($"this.InstallmentPlan = {(this.InstallmentPlan == null ? "null" : this.InstallmentPlan)}");
            toStringOutput.Add($"this.StripeToken = {(this.StripeToken == null ? "null" : this.StripeToken)}");
            toStringOutput.Add($"this.ExternalId = {(this.ExternalId == null ? "null" : this.ExternalId)}");
        }
    }
}