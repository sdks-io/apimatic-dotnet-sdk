// <copyright file="APIValidationExternalApisController.cs" company="APIMatic">
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
    /// APIValidationExternalApisController.
    /// </summary>
    public class APIValidationExternalApisController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIValidationExternalApisController"/> class.
        /// </summary>
        internal APIValidationExternalApisController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Validate an API by uploading the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while validating the API using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <returns>Returns the Models.ApiValidationSummary response from the API call.</returns>
        public Models.ApiValidationSummary ValidateAPIViaFile(
                FileStreamInfo file)
            => CoreHelper.RunTask(ValidateAPIViaFileAsync(file));

        /// <summary>
        /// Validate an API by uploading the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while validating the API using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiValidationSummary response from the API call.</returns>
        public async Task<Models.ApiValidationSummary> ValidateAPIViaFileAsync(
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiValidationSummary>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/validation/validate-via-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthenticated", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Validate an API by providing the URL of the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while validating the API using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="descriptionUrl"><![CDATA[Required parameter: The URL for the API specification file.<br><br>**Note:** This URL should be publicly accessible..]]></param>
        /// <returns>Returns the Models.ApiValidationSummary response from the API call.</returns>
        public Models.ApiValidationSummary ValidateAPIViaURL(
                string descriptionUrl)
            => CoreHelper.RunTask(ValidateAPIViaURLAsync(descriptionUrl));

        /// <summary>
        /// Validate an API by providing the URL of the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while validating the API using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="descriptionUrl"><![CDATA[Required parameter: The URL for the API specification file.<br><br>**Note:** This URL should be publicly accessible..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiValidationSummary response from the API call.</returns>
        public async Task<Models.ApiValidationSummary> ValidateAPIViaURLAsync(
                string descriptionUrl,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiValidationSummary>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/validation/validate-via-url")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("descriptionUrl", descriptionUrl))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthenticated", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}