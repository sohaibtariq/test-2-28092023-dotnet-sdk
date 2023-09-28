// <copyright file="QuotingController.cs" company="APIMatic">
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
    /// QuotingController.
    /// </summary>
    public class QuotingController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotingController"/> class.
        /// </summary>
        internal QuotingController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Issues a new quote.
        /// </summary>
        /// <param name="boostUser">Required parameter: Boost provided agent UUID that identifies the user..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.QuotesResponse response from the API call.</returns>
        public Models.QuotesResponse PostQuote(
                Guid boostUser,
                Models.QuotesRequest body)
            => CoreHelper.RunTask(PostQuoteAsync(boostUser, body));

        /// <summary>
        /// Issues a new quote.
        /// </summary>
        /// <param name="boostUser">Required parameter: Boost provided agent UUID that identifies the user..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QuotesResponse response from the API call.</returns>
        public async Task<Models.QuotesResponse> PostQuoteAsync(
                Guid boostUser,
                Models.QuotesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QuotesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/quotes")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Boost-User", boostUser))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is invalid.", (_reason, _context) => new Quotes400Error1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized. The bearer authentication failed.", (_reason, _context) => new Quotes401Error1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new Quotes500Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}