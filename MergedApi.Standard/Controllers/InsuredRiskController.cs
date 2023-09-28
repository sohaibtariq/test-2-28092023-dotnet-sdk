// <copyright file="InsuredRiskController.cs" company="APIMatic">
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
    /// InsuredRiskController.
    /// </summary>
    public class InsuredRiskController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsuredRiskController"/> class.
        /// </summary>
        internal InsuredRiskController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a new insured risk to then utilize when creating a policy.
        /// </summary>
        /// <param name="boostUser">Required parameter: UUID that identifies the user..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.InsuredRisksResponse response from the API call.</returns>
        public Models.InsuredRisksResponse PostInsuredRisk(
                Guid boostUser,
                Models.InsuredRisksRequest body)
            => CoreHelper.RunTask(PostInsuredRiskAsync(boostUser, body));

        /// <summary>
        /// Creates a new insured risk to then utilize when creating a policy.
        /// </summary>
        /// <param name="boostUser">Required parameter: UUID that identifies the user..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InsuredRisksResponse response from the API call.</returns>
        public async Task<Models.InsuredRisksResponse> PostInsuredRiskAsync(
                Guid boostUser,
                Models.InsuredRisksRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InsuredRisksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/insured-risks")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Boost-User", boostUser))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Request is invalid.", (_reason, _context) => new InsuredRisks400Error1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized. The bearer authentication failed.", (_reason, _context) => new InsuredRisks401Error1Exception(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden. The operation is not allowed.", (_reason, _context) => new InsuredRisks403Error1Exception(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported Media Type. Only JSONAPI is supported.", (_reason, _context) => new InsuredRisks415Error1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error.", (_reason, _context) => new InsuredRisks500Error1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}