// <copyright file="MergedApiClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MergedApi.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using MergedApi.Standard.Authentication;
    using MergedApi.Standard.Controllers;
    using MergedApi.Standard.Http.Client;
    using MergedApi.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class MergedApiClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production22, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.insurtech.dev" },
                    { Server.Calculator, "https://examples.apimatic.io/apps/calculator" },
                }
            },
            {
                Environment.Development, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://staging.api.insurtech.dev" },
                    { Server.Calculator, "https://examples.apimatic.io/apps/calculator" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallBack httpCallBack;
        private readonly ClientCredentialsAuthManager clientCredentialsAuthManager;
        private readonly Lazy<AuthenticationController> authentication;
        private readonly Lazy<QuotingController> quoting;
        private readonly Lazy<PolicyController> policy;
        private readonly Lazy<InsuredRiskController> insuredRisk;
        private readonly Lazy<SimpleCalculatorController> simpleCalculator;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private MergedApiClient(
            Environment environment,
            string oAuthClientId,
            string oAuthClientSecret,
            Models.OAuthToken oAuthToken,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            clientCredentialsAuthManager = new ClientCredentialsAuthManager(oAuthClientId, oAuthClientSecret, oAuthToken);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", clientCredentialsAuthManager}
                })
                .ApiCallback(httpCallBack)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();
            clientCredentialsAuthManager.ApplyGlobalConfiguration(globalConfiguration);

            this.authentication = new Lazy<AuthenticationController>(
                () => new AuthenticationController(globalConfiguration));
            this.quoting = new Lazy<QuotingController>(
                () => new QuotingController(globalConfiguration));
            this.policy = new Lazy<PolicyController>(
                () => new PolicyController(globalConfiguration));
            this.insuredRisk = new Lazy<InsuredRiskController>(
                () => new InsuredRiskController(globalConfiguration));
            this.simpleCalculator = new Lazy<SimpleCalculatorController>(
                () => new SimpleCalculatorController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets AuthenticationController controller.
        /// </summary>
        public AuthenticationController AuthenticationController => this.authentication.Value;

        /// <summary>
        /// Gets QuotingController controller.
        /// </summary>
        public QuotingController QuotingController => this.quoting.Value;

        /// <summary>
        /// Gets PolicyController controller.
        /// </summary>
        public PolicyController PolicyController => this.policy.Value;

        /// <summary>
        /// Gets InsuredRiskController controller.
        /// </summary>
        public InsuredRiskController InsuredRiskController => this.insuredRisk.Value;

        /// <summary>
        /// Gets SimpleCalculatorController controller.
        /// </summary>
        public SimpleCalculatorController SimpleCalculatorController => this.simpleCalculator.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        internal HttpCallBack HttpCallBack => this.httpCallBack;

        /// <summary>
        /// Gets the credentials to use with ClientCredentialsAuth.
        /// </summary>
        public IClientCredentialsAuth ClientCredentialsAuth => this.clientCredentialsAuthManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the MergedApiClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .OAuthToken(clientCredentialsAuthManager.OAuthToken)
                .ClientCredentialsAuth(clientCredentialsAuthManager.OAuthClientId, clientCredentialsAuthManager.OAuthClientSecret)
                .HttpCallBack(httpCallBack)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> MergedApiClient.</returns>
        internal static MergedApiClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("MERGED_API_STANDARD_ENVIRONMENT");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("MERGED_API_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("MERGED_API_STANDARD_O_AUTH_CLIENT_SECRET");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.ClientCredentialsAuth(oAuthClientId, oAuthClientSecret);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = MergedApi.Standard.Environment.Production22;
            private string oAuthClientId = "";
            private string oAuthClientSecret = "";
            private Models.OAuthToken oAuthToken = null;
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for ClientCredentialsAuth.
            /// </summary>
            /// <param name="oAuthClientId">OAuthClientId.</param>
            /// <param name="oAuthClientSecret">OAuthClientSecret.</param>
            /// <returns>Builder.</returns>
            public Builder ClientCredentialsAuth(string oAuthClientId, string oAuthClientSecret)
            {
                this.oAuthClientId = oAuthClientId ?? throw new ArgumentNullException(nameof(oAuthClientId));
                this.oAuthClientSecret = oAuthClientSecret ?? throw new ArgumentNullException(nameof(oAuthClientSecret));
                return this;
            }

            /// <summary>
            /// Sets OAuthToken.
            /// </summary>
            /// <param name="oAuthToken">OAuthToken.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthToken(Models.OAuthToken oAuthToken)
            {
                this.oAuthToken = oAuthToken;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the MergedApiClient using the values provided for the builder.
            /// </summary>
            /// <returns>MergedApiClient.</returns>
            public MergedApiClient Build()
            {

                return new MergedApiClient(
                    environment,
                    oAuthClientId,
                    oAuthClientSecret,
                    oAuthToken,
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}
