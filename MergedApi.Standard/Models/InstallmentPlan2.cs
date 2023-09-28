// <copyright file="InstallmentPlan2.cs" company="APIMatic">
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
    /// InstallmentPlan2.
    /// </summary>
    public class InstallmentPlan2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlan2"/> class.
        /// </summary>
        public InstallmentPlan2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlan2"/> class.
        /// </summary>
        /// <param name="billingPeriod">billing_period.</param>
        /// <param name="amountDue">amount_due.</param>
        /// <param name="dueDate">due_date.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="fees">fees.</param>
        public InstallmentPlan2(
            DateTime billingPeriod,
            string amountDue,
            DateTime dueDate,
            string taxes,
            string fees)
        {
            this.BillingPeriod = billingPeriod;
            this.AmountDue = amountDue;
            this.DueDate = dueDate;
            this.Taxes = taxes;
            this.Fees = fees;
        }

        /// <summary>
        /// The billing period for this installment plan entry.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("billing_period")]
        public DateTime BillingPeriod { get; set; }

        /// <summary>
        /// Boost generated amount due for this installment plan entry.
        /// </summary>
        [JsonProperty("amount_due")]
        public string AmountDue { get; set; }

        /// <summary>
        /// The date on which payment is due for this billing period.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date")]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Boost generated taxes due for this installment plan entry.
        /// </summary>
        [JsonProperty("taxes")]
        public string Taxes { get; set; }

        /// <summary>
        /// Boost generated fees due for this installment plan entry.
        /// </summary>
        [JsonProperty("fees")]
        public string Fees { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstallmentPlan2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstallmentPlan2 other &&                this.BillingPeriod.Equals(other.BillingPeriod) &&
                ((this.AmountDue == null && other.AmountDue == null) || (this.AmountDue?.Equals(other.AmountDue) == true)) &&
                this.DueDate.Equals(other.DueDate) &&
                ((this.Taxes == null && other.Taxes == null) || (this.Taxes?.Equals(other.Taxes) == true)) &&
                ((this.Fees == null && other.Fees == null) || (this.Fees?.Equals(other.Fees) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingPeriod = {this.BillingPeriod}");
            toStringOutput.Add($"this.AmountDue = {(this.AmountDue == null ? "null" : this.AmountDue)}");
            toStringOutput.Add($"this.DueDate = {this.DueDate}");
            toStringOutput.Add($"this.Taxes = {(this.Taxes == null ? "null" : this.Taxes)}");
            toStringOutput.Add($"this.Fees = {(this.Fees == null ? "null" : this.Fees)}");
        }
    }
}