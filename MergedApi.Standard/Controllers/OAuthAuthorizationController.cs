// <copyright file="OAuthAuthorizationController.cs" company="APIMatic">
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
    /// OAuthAuthorizationController.
    /// </summary>
    public class OAuthAuthorizationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAuthorizationController"/> class.
        /// </summary>
        internal OAuthAuthorizationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="authorization">Required parameter: Authorization header in Basic auth format.</param>
        /// <param name="scope">Optional parameter: Requested scopes as a space-delimited list..</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <returns>Returns the Models.OAuthToken response from the API call.</returns>
        public Models.OAuthToken RequestToken(
                string authorization,
                string scope = null,
                Dictionary<string, object> fieldParameters = null)
            => CoreHelper.RunTask(RequestTokenAsync(authorization, scope, fieldParameters));

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="authorization">Required parameter: Authorization header in Basic auth format.</param>
        /// <param name="scope">Optional parameter: Requested scopes as a space-delimited list..</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OAuthToken response from the API call.</returns>
        public async Task<Models.OAuthToken> RequestTokenAsync(
                string authorization,
                string scope = null,
                Dictionary<string, object> fieldParameters = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OAuthToken>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/oauth2/token")
                  .Parameters(_parameters => _parameters
                      .AdditionalForms(_additionalForms => _additionalForms.Setup(fieldParameters))
                      .Form(_form => _form.Setup("grant_type", "client_credentials"))
                      .Header(_header => _header.Setup("Authorization", authorization))
                      .Form(_form => _form.Setup("scope", scope))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("OAuth 2 provider returned an error.", (_reason, _context) => new OAuthProviderException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("OAuth 2 provider says client authentication failed.", (_reason, _context) => new OAuthProviderException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}