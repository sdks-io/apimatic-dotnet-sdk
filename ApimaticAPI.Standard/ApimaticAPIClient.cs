// <copyright file="ApimaticAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ApimaticAPI.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using ApimaticAPI.Standard.Authentication;
    using ApimaticAPI.Standard.Controllers;
    using ApimaticAPI.Standard.Http.Client;
    using ApimaticAPI.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class ApimaticAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.apimatic.io" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMatic CLI";
        private readonly HttpCallBack httpCallBack;
        private readonly Lazy<ApisManagementController> apisManagement;
        private readonly Lazy<CodeGenerationImportedApisController> codeGenerationImportedApis;
        private readonly Lazy<CodeGenerationExternalApisController> codeGenerationExternalApis;
        private readonly Lazy<TransformationController> transformation;
        private readonly Lazy<DocsPortalManagementController> docsPortalManagement;
        private readonly Lazy<APIValidationImportedApisController> aPIValidationImportedApis;
        private readonly Lazy<APIValidationExternalApisController> aPIValidationExternalApis;

        private ApimaticAPIClient(
            Environment environment,
            CustomHeaderAuthenticationModel customHeaderAuthenticationModel,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            CustomHeaderAuthenticationModel = customHeaderAuthenticationModel;
            var customHeaderAuthenticationManager = new CustomHeaderAuthenticationManager(customHeaderAuthenticationModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"Authorization", customHeaderAuthenticationManager},
                })
                .ApiCallback(httpCallBack)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            CustomHeaderAuthenticationCredentials = customHeaderAuthenticationManager;

            this.apisManagement = new Lazy<ApisManagementController>(
                () => new ApisManagementController(globalConfiguration));
            this.codeGenerationImportedApis = new Lazy<CodeGenerationImportedApisController>(
                () => new CodeGenerationImportedApisController(globalConfiguration));
            this.codeGenerationExternalApis = new Lazy<CodeGenerationExternalApisController>(
                () => new CodeGenerationExternalApisController(globalConfiguration));
            this.transformation = new Lazy<TransformationController>(
                () => new TransformationController(globalConfiguration));
            this.docsPortalManagement = new Lazy<DocsPortalManagementController>(
                () => new DocsPortalManagementController(globalConfiguration));
            this.aPIValidationImportedApis = new Lazy<APIValidationImportedApisController>(
                () => new APIValidationImportedApisController(globalConfiguration));
            this.aPIValidationExternalApis = new Lazy<APIValidationExternalApisController>(
                () => new APIValidationExternalApisController(globalConfiguration));
        }

        /// <summary>
        /// Gets ApisManagementController controller.
        /// </summary>
        public ApisManagementController ApisManagementController => this.apisManagement.Value;

        /// <summary>
        /// Gets CodeGenerationImportedApisController controller.
        /// </summary>
        public CodeGenerationImportedApisController CodeGenerationImportedApisController => this.codeGenerationImportedApis.Value;

        /// <summary>
        /// Gets CodeGenerationExternalApisController controller.
        /// </summary>
        public CodeGenerationExternalApisController CodeGenerationExternalApisController => this.codeGenerationExternalApis.Value;

        /// <summary>
        /// Gets TransformationController controller.
        /// </summary>
        public TransformationController TransformationController => this.transformation.Value;

        /// <summary>
        /// Gets DocsPortalManagementController controller.
        /// </summary>
        public DocsPortalManagementController DocsPortalManagementController => this.docsPortalManagement.Value;

        /// <summary>
        /// Gets APIValidationImportedApisController controller.
        /// </summary>
        public APIValidationImportedApisController APIValidationImportedApisController => this.aPIValidationImportedApis.Value;

        /// <summary>
        /// Gets APIValidationExternalApisController controller.
        /// </summary>
        public APIValidationExternalApisController APIValidationExternalApisController => this.aPIValidationExternalApis.Value;

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
        /// Gets the credentials to use with CustomHeaderAuthentication.
        /// </summary>
        public ICustomHeaderAuthenticationCredentials CustomHeaderAuthenticationCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with CustomHeaderAuthentication.
        /// </summary>
        public CustomHeaderAuthenticationModel CustomHeaderAuthenticationModel { get; private set; }

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
        /// Creates an object of the ApimaticAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallBack(httpCallBack)
                .HttpClientConfig(config => config.Build());

            if (CustomHeaderAuthenticationModel != null)
            {
                builder.CustomHeaderAuthenticationCredentials(CustomHeaderAuthenticationModel.ToBuilder().Build());
            }

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
        /// <returns> ApimaticAPIClient.</returns>
        internal static ApimaticAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("APIMATIC_API_STANDARD_ENVIRONMENT");
            string authorization = System.Environment.GetEnvironmentVariable("APIMATIC_API_STANDARD_AUTHORIZATION");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (authorization != null)
            {
                builder.CustomHeaderAuthenticationCredentials(new CustomHeaderAuthenticationModel
                .Builder(authorization)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = ApimaticAPI.Standard.Environment.Production;
            private CustomHeaderAuthenticationModel customHeaderAuthenticationModel = new CustomHeaderAuthenticationModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for CustomHeaderAuthentication.
            /// </summary>
            /// <param name="authorization">Authorization.</param>
            /// <returns>Builder.</returns>
            [Obsolete("This method is deprecated. Use CustomHeaderAuthenticationCredentials(customHeaderAuthenticationModel) instead.")]
            public Builder CustomHeaderAuthenticationCredentials(string authorization)
            {
                customHeaderAuthenticationModel = customHeaderAuthenticationModel.ToBuilder()
                    .Authorization(authorization)
                    .Build();
                return this;
            }

            /// <summary>
            /// Sets credentials for CustomHeaderAuthentication.
            /// </summary>
            /// <param name="customHeaderAuthenticationModel">CustomHeaderAuthenticationModel.</param>
            /// <returns>Builder.</returns>
            public Builder CustomHeaderAuthenticationCredentials(CustomHeaderAuthenticationModel customHeaderAuthenticationModel)
            {
                if (customHeaderAuthenticationModel is null)
                {
                    throw new ArgumentNullException(nameof(customHeaderAuthenticationModel));
                }

                this.customHeaderAuthenticationModel = customHeaderAuthenticationModel;
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
            /// Creates an object of the ApimaticAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>ApimaticAPIClient.</returns>
            public ApimaticAPIClient Build()
            {

                if (customHeaderAuthenticationModel.Authorization == null)
                {
                    customHeaderAuthenticationModel = null;
                }
                return new ApimaticAPIClient(
                    environment,
                    customHeaderAuthenticationModel,
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}
