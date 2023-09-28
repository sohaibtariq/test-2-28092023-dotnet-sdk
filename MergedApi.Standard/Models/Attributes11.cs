// <copyright file="Attributes11.cs" company="APIMatic">
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
    /// Attributes11.
    /// </summary>
    public class Attributes11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes11"/> class.
        /// </summary>
        public Attributes11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes11"/> class.
        /// </summary>
        /// <param name="entityType">entity_type.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">phone.</param>
        /// <param name="mailingAddress">mailing_address.</param>
        /// <param name="externalReference">external_reference.</param>
        /// <param name="businessName">business_name.</param>
        /// <param name="website">website.</param>
        /// <param name="billingAddress">billing_address.</param>
        public Attributes11(
            Models.EntityTypeEnum entityType,
            string firstName,
            string lastName,
            string email,
            string phone,
            Models.MailingAddress mailingAddress,
            string externalReference = null,
            string businessName = null,
            string website = null,
            Models.BillingAddress billingAddress = null)
        {
            this.ExternalReference = externalReference;
            this.EntityType = entityType;
            this.BusinessName = businessName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Website = website;
            this.MailingAddress = mailingAddress;
            this.BillingAddress = billingAddress;
        }

        /// <summary>
        /// A reference that can be used to identify this customer in your system.
        /// </summary>
        [JsonProperty("external_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// The kind of customer this is.
        /// </summary>
        [JsonProperty("entity_type")]
        public Models.EntityTypeEnum EntityType { get; set; }

        /// <summary>
        /// The legal name of the business.
        /// </summary>
        [JsonProperty("business_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessName { get; set; }

        /// <summary>
        /// The first name of the contact.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the contact.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the contact.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The primary phone number of the contact.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The website of the contact.
        /// </summary>
        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        /// <summary>
        /// The mailing address of this customer.
        /// </summary>
        [JsonProperty("mailing_address")]
        public Models.MailingAddress MailingAddress { get; set; }

        /// <summary>
        /// The billing address of this customer.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAddress BillingAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes11 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes11 other &&                ((this.ExternalReference == null && other.ExternalReference == null) || (this.ExternalReference?.Equals(other.ExternalReference) == true)) &&
                this.EntityType.Equals(other.EntityType) &&
                ((this.BusinessName == null && other.BusinessName == null) || (this.BusinessName?.Equals(other.BusinessName) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.Website == null && other.Website == null) || (this.Website?.Equals(other.Website) == true)) &&
                ((this.MailingAddress == null && other.MailingAddress == null) || (this.MailingAddress?.Equals(other.MailingAddress) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExternalReference = {(this.ExternalReference == null ? "null" : this.ExternalReference)}");
            toStringOutput.Add($"this.EntityType = {this.EntityType}");
            toStringOutput.Add($"this.BusinessName = {(this.BusinessName == null ? "null" : this.BusinessName)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.Website = {(this.Website == null ? "null" : this.Website)}");
            toStringOutput.Add($"this.MailingAddress = {(this.MailingAddress == null ? "null" : this.MailingAddress.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
        }
    }
}