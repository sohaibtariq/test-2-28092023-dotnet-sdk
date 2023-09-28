// <copyright file="PolicyController.cs" company="APIMatic">
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
    /// PolicyController.
    /// </summary>
    public class PolicyController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyController"/> class.
        /// </summary>
        internal PolicyController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List previously created policies.
        /// </summary>
        /// <param name="boostUser">Required parameter: UUID that identifies the user..</param>
        /// <param name="accept">Optional parameter: Header to indicate that desired response type is JSON:API..</param>
        /// <returns>Returns the Models.PoliciesResponse1 response from the API call.</returns>
        public Models.PoliciesResponse1 ListPolicies(
                Guid boostUser,
                Models.ContentType1Enum? accept = null)
            => CoreHelper.RunTask(ListPoliciesAsync(boostUser, accept));

        /// <summary>
        /// List previously created policies.
        /// </summary>
        /// <param name="boostUser">Required parameter: UUID that identifies the user..</param>
        /// <param name="accept">Optional parameter: Header to indicate that desired response type is JSON:API..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PoliciesResponse1 response from the API call.</returns>
        public async Task<Models.PoliciesResponse1> ListPoliciesAsync(
                Guid boostUser,
                Models.ContentType1Enum? accept = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PoliciesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/policies")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Boost-User", boostUser))
                      .Header(_header => _header.Setup("Accept", (accept.HasValue) ? ApiHelper.JsonSerialize(accept.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Issues a new policy with the given the input data. Policy goes in force on the specified effective_date.
        /// </summary>
        /// <param name="boostUser">Required parameter: UUID that identifies the user..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PoliciesResponse response from the API call.</returns>
        public Models.PoliciesResponse PostPolicy(
                Guid boostUser,
                Models.PoliciesRequest body)
            => CoreHelper.RunTask(PostPolicyAsync(boostUser, body));

        /// <summary>
        /// Issues a new policy with the given the input data. Policy goes in force on the specified effective_date.
        /// </summary>
        /// <param name="boostUser">Required parameter: UUID that identifies the user..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PoliciesResponse response from the API call.</returns>
        public async Task<Models.PoliciesResponse> PostPolicyAsync(
                Guid boostUser,
                Models.PoliciesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PoliciesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/policies")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Boost-User", boostUser))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is invalid.", (_reason, _context) => new Policies400Error1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized. The bearer authentication failed.", (_reason, _context) => new Policies401Error1Exception(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden. The operation is not allowed.", (_reason, _context) => new Policies403Error1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new Policies500Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}