// <copyright file="AuthOauth2TokenResponse.cs" company="APIMatic">
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
    /// AuthOauth2TokenResponse.
    /// </summary>
    public class AuthOauth2TokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthOauth2TokenResponse"/> class.
        /// </summary>
        public AuthOauth2TokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthOauth2TokenResponse"/> class.
        /// </summary>
        /// <param name="tokenType">token_type.</param>
        /// <param name="accessToken">access_token.</param>
        /// <param name="expiresIn">expires_in.</param>
        public AuthOauth2TokenResponse(
            Models.TokenTypeEnum? tokenType = null,
            string accessToken = null,
            Models.ExpiresInEnum? expiresIn = null)
        {
            this.TokenType = tokenType;
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Type of token.
        /// </summary>
        [JsonProperty("token_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TokenTypeEnum? TokenType { get; set; }

        /// <summary>
        /// The token to be used in future API calls.
        /// </summary>
        [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// How long this token is valid for.
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExpiresInEnum? ExpiresIn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthOauth2TokenResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthOauth2TokenResponse other &&                ((this.TokenType == null && other.TokenType == null) || (this.TokenType?.Equals(other.TokenType) == true)) &&
                ((this.AccessToken == null && other.AccessToken == null) || (this.AccessToken?.Equals(other.AccessToken) == true)) &&
                ((this.ExpiresIn == null && other.ExpiresIn == null) || (this.ExpiresIn?.Equals(other.ExpiresIn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TokenType = {(this.TokenType == null ? "null" : this.TokenType.ToString())}");
            toStringOutput.Add($"this.AccessToken = {(this.AccessToken == null ? "null" : this.AccessToken)}");
            toStringOutput.Add($"this.ExpiresIn = {(this.ExpiresIn == null ? "null" : this.ExpiresIn.ToString())}");
        }
    }
}