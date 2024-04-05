// <copyright file="APIValidationImportedApisController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ApimaticAPI.Standard.Controllers
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
    using ApimaticAPI.Standard;
    using ApimaticAPI.Standard.Exceptions;
    using ApimaticAPI.Standard.Http.Client;
    using ApimaticAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// APIValidationImportedApisController.
    /// </summary>
    public class APIValidationImportedApisController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIValidationImportedApisController"/> class.
        /// </summary>
        internal APIValidationImportedApisController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Validate an API using the [APIMatic Validator](https://docs.apimatic.io/generate-sdks/overview-sdks#step-2-api-validation).
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to perform validation for..</param>
        /// <returns>Returns the Models.ApiValidationSummary response from the API call.</returns>
        public Models.ApiValidationSummary ValidateAPI(
                string apiEntityId)
            => CoreHelper.RunTask(ValidateAPIAsync(apiEntityId));

        /// <summary>
        /// Validate an API using the [APIMatic Validator](https://docs.apimatic.io/generate-sdks/overview-sdks#step-2-api-validation).
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to perform validation for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiValidationSummary response from the API call.</returns>
        public async Task<Models.ApiValidationSummary> ValidateAPIAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiValidationSummary>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}/api-validation-summary")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("API not found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Validate an API for documentation generation. This process validates the API for missing examples or missing descriptions.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to perform validation for..</param>
        /// <returns>Returns the Models.DocsValidationSummary response from the API call.</returns>
        public Models.DocsValidationSummary ValidateAPIForDocs(
                string apiEntityId)
            => CoreHelper.RunTask(ValidateAPIForDocsAsync(apiEntityId));

        /// <summary>
        /// Validate an API for documentation generation. This process validates the API for missing examples or missing descriptions.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to perform validation for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DocsValidationSummary response from the API call.</returns>
        public async Task<Models.DocsValidationSummary> ValidateAPIForDocsAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DocsValidationSummary>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}/docs-validation-summary")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("API not found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}