// <copyright file="ApisManagementController.cs" company="APIMatic">
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
    /// ApisManagementController.
    /// </summary>
    public class ApisManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApisManagementController"/> class.
        /// </summary>
        internal ApisManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Import an API into the APIMatic Dashboard by uploading the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public Models.ApiEntity ImportAPIViaFile(
                FileStreamInfo file)
            => CoreHelper.RunTask(ImportAPIViaFileAsync(file));

        /// <summary>
        /// Import an API into the APIMatic Dashboard by uploading the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public async Task<Models.ApiEntity> ImportAPIViaFileAsync(
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiEntity>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api-entities/import-via-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("412", CreateErrorCase("Precondition Failed", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Import an API into the APIMatic Dashboard by providing the URL of the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public Models.ApiEntity ImportAPIViaURL(
                Models.ImportApiViaUrlRequest body)
            => CoreHelper.RunTask(ImportAPIViaURLAsync(body));

        /// <summary>
        /// Import an API into the APIMatic Dashboard by providing the URL of the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public async Task<Models.ApiEntity> ImportAPIViaURLAsync(
                Models.ImportApiViaUrlRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiEntity>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api-entities/import-via-url")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.apimatic.apiEntityUrlImportDto.v1+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("412", CreateErrorCase("Precondition Failed", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Import a new version for an API, against an existing API Group, by uploading the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: The ID of the API Group for which to import a new API version..</param>
        /// <param name="versionOverride"><![CDATA[Required parameter: The version number with which the new API version will be imported. This version number will override the version specified in the API specification file.<br>APIMatic recommends versioning the API with the [versioning scheme](https://docs.apimatic.io/define-apis/basic-settings/#version) documented in the docs..]]></param>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public Models.ApiEntity ImportNewAPIVersionViaFile(
                string apiGroupId,
                string versionOverride,
                FileStreamInfo file)
            => CoreHelper.RunTask(ImportNewAPIVersionViaFileAsync(apiGroupId, versionOverride, file));

        /// <summary>
        /// Import a new version for an API, against an existing API Group, by uploading the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: The ID of the API Group for which to import a new API version..</param>
        /// <param name="versionOverride"><![CDATA[Required parameter: The version number with which the new API version will be imported. This version number will override the version specified in the API specification file.<br>APIMatic recommends versioning the API with the [versioning scheme](https://docs.apimatic.io/define-apis/basic-settings/#version) documented in the docs..]]></param>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public async Task<Models.ApiEntity> ImportNewAPIVersionViaFileAsync(
                string apiGroupId,
                string versionOverride,
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiEntity>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api-groups/{api_group_id}/api-entities/import-via-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_group_id", apiGroupId))
                      .Form(_form => _form.Setup("version_override", versionOverride))
                      .Form(_form => _form.Setup("file", file))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Import a new version for an API, against an existing API Group, by providing the URL of the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: The ID of the API Group for which to import a new API version..</param>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public Models.ApiEntity ImportNewAPIVersionViaURL(
                string apiGroupId,
                Models.ImportApiVersionViaUrlRequest body)
            => CoreHelper.RunTask(ImportNewAPIVersionViaURLAsync(apiGroupId, body));

        /// <summary>
        /// Import a new version for an API, against an existing API Group, by providing the URL of the API specification file.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: The ID of the API Group for which to import a new API version..</param>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public async Task<Models.ApiEntity> ImportNewAPIVersionViaURLAsync(
                string apiGroupId,
                Models.ImportApiVersionViaUrlRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiEntity>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api-groups/{api_group_id}/api-entities/import-via-url")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("api_group_id", apiGroupId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.apimatic.apiGroupApiEntityUrlImportDto.v1+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Replace an API version of an API Group, by uploading the API specification file that will replace the current version.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to replace..</param>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        public void InplaceAPIImportViaFile(
                string apiEntityId,
                FileStreamInfo file)
            => CoreHelper.RunVoidTask(InplaceAPIImportViaFileAsync(apiEntityId, file));

        /// <summary>
        /// Replace an API version of an API Group, by uploading the API specification file that will replace the current version.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the uploaded file will be a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to replace..</param>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task InplaceAPIImportViaFileAsync(
                string apiEntityId,
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api-entities/{api_entity_id}/import-via-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))
                      .Form(_form => _form.Setup("file", file))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Replace an API version of an API Group, by providing the URL of the API specification file that will replace the current version.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to replace..</param>
        /// <param name="body">Required parameter: Request Body.</param>
        public void InplaceAPIImportViaURL(
                string apiEntityId,
                Models.InplaceImportApiViaUrlRequest body)
            => CoreHelper.RunVoidTask(InplaceAPIImportViaURLAsync(apiEntityId, body));

        /// <summary>
        /// Replace an API version of an API Group, by providing the URL of the API specification file that will replace the current version.
        /// You can also specify [API Metadata](https://docs.apimatic.io/manage-apis/apimatic-metadata) while importing the API version using this endpoint. When specifying Metadata, the URL provided will be that of a zip file containing the API specification file and the `APIMATIC-META` json file.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to replace..</param>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task InplaceAPIImportViaURLAsync(
                string apiEntityId,
                Models.InplaceImportApiViaUrlRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api-entities/{api_entity_id}/import-via-url")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.apimatic.apiEntityUrlImportDto.v1+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch an API Entity.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to fetch..</param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public Models.ApiEntity FetchAPIEntity(
                string apiEntityId)
            => CoreHelper.RunTask(FetchAPIEntityAsync(apiEntityId));

        /// <summary>
        /// Fetch an API Entity.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to fetch..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApiEntity response from the API call.</returns>
        public async Task<Models.ApiEntity> FetchAPIEntityAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApiEntity>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download the API Specification file for a an API Version in any of the API Specification formats supported by APIMatic.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to download..</param>
        /// <param name="format"><![CDATA[Required parameter: The format in which to download the API.<br>The format can be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream DownloadAPISpecification(
                string apiEntityId,
                Models.ExportFormats format)
            => CoreHelper.RunTask(DownloadAPISpecificationAsync(apiEntityId, format));

        /// <summary>
        /// Download the API Specification file for a an API Version in any of the API Specification formats supported by APIMatic.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to download..</param>
        /// <param name="format"><![CDATA[Required parameter: The format in which to download the API.<br>The format can be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> DownloadAPISpecificationAsync(
                string apiEntityId,
                Models.ExportFormats format,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}/api-description")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))
                      .Query(_query => _query.Setup("format", ApiHelper.JsonSerialize(format).Trim('\"')))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}