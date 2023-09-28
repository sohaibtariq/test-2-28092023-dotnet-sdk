// <copyright file="AuthenticationController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MergedApi.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using MergedApi.Standard;
    using MergedApi.Standard.Authentication;
    using MergedApi.Standard.Exceptions;
    using MergedApi.Standard.Http.Client;
    using MergedApi.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// AuthenticationController.
    /// </summary>
    public class AuthenticationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController"/> class.
        /// </summary>
        internal AuthenticationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Generates an access token which must be used on all subsequent API calls.
        /// </summary>
        /// <param name="clientId">Required parameter: Your Client ID.</param>
        /// <param name="clientSecret">Required parameter: Your Client Secret.</param>
        /// <returns>Returns the Models.AuthOauth2TokenResponse response from the API call.</returns>
        public Models.AuthOauth2TokenResponse GetOAuthToken(
                string clientId,
                string clientSecret)
            => CoreHelper.RunTask(GetOAuthTokenAsync(clientId, clientSecret));

        /// <summary>
        /// Generates an access token which must be used on all subsequent API calls.
        /// </summary>
        /// <param name="clientId">Required parameter: Your Client ID.</param>
        /// <param name="clientSecret">Required parameter: Your Client Secret.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthOauth2TokenResponse response from the API call.</returns>
        public async Task<Models.AuthOauth2TokenResponse> GetOAuthTokenAsync(
                string clientId,
                string clientSecret,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthOauth2TokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/oauth2/token")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", "application/x-www-form-urlencoded"))
                      .Form(_form => _form.Setup("client_id", clientId))
                      .Form(_form => _form.Setup("client_secret", clientSecret))
                      .Form(_form => _form.Setup("grant_type", "client_credentials"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is invalid", (_reason, _context) => new AuthOauth2Token400Error1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}