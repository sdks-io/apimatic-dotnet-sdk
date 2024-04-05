// <copyright file="TransformationController.cs" company="APIMatic">
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
    using ApimaticAPI.Standard.Http.Client;
    using ApimaticAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// TransformationController.
    /// </summary>
    public class TransformationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransformationController"/> class.
        /// </summary>
        internal TransformationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Transform an API into any of the supported API specification formats by uploading the API specification file. This endpoint transforms and then uploads the transformed API specification to APIMatic's cloud storage. An ID for the transformation performed is returned as part of the response.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="exportFormat">Required parameter: The structure contains API specification formats that Transformer can convert to..</param>
        /// <returns>Returns the Models.Transformation response from the API call.</returns>
        public Models.Transformation TransformViaFile(
                FileStreamInfo file,
                Models.ExportFormats exportFormat)
            => CoreHelper.RunTask(TransformViaFileAsync(file, exportFormat));

        /// <summary>
        /// Transform an API into any of the supported API specification formats by uploading the API specification file. This endpoint transforms and then uploads the transformed API specification to APIMatic's cloud storage. An ID for the transformation performed is returned as part of the response.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="exportFormat">Required parameter: The structure contains API specification formats that Transformer can convert to..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Transformation response from the API call.</returns>
        public async Task<Models.Transformation> TransformViaFileAsync(
                FileStreamInfo file,
                Models.ExportFormats exportFormat,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Transformation>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transformations/transform-via-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))
                      .Form(_form => _form.Setup("export_format", ApiHelper.JsonSerialize(exportFormat).Trim('\"')))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Transform an API into any of the supported API specification formats by providing the URL of the API specification file.
        /// This endpoint transforms and then uploads the transformed API specification to APIMatic's cloud storage. An ID for the transformation performed is returned as part of the response.
        /// </summary>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <returns>Returns the Models.Transformation response from the API call.</returns>
        public Models.Transformation TransformViaURL(
                Models.TransformViaUrlRequest body)
            => CoreHelper.RunTask(TransformViaURLAsync(body));

        /// <summary>
        /// Transform an API into any of the supported API specification formats by providing the URL of the API specification file.
        /// This endpoint transforms and then uploads the transformed API specification to APIMatic's cloud storage. An ID for the transformation performed is returned as part of the response.
        /// </summary>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Transformation response from the API call.</returns>
        public async Task<Models.Transformation> TransformViaURLAsync(
                Models.TransformViaUrlRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Transformation>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transformations/transform-via-url")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.apimatic.urlTransformDto.v1+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download the transformed API specification file transformed via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of transformation received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL  ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream DownloadTransformedFile(
                string transformationId)
            => CoreHelper.RunTask(DownloadTransformedFileAsync(transformationId));

        /// <summary>
        /// Download the transformed API specification file transformed via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of transformation received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL  ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> DownloadTransformedFileAsync(
                string transformationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transformations/{transformation_id}/converted-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transformation_id", transformationId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download the API Specification file used as input for a particular Transformation performed via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of the transformation to download the API specification for. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream DownloadInputFileTransformation(
                string transformationId)
            => CoreHelper.RunTask(DownloadInputFileTransformationAsync(transformationId));

        /// <summary>
        /// Download the API Specification file used as input for a particular Transformation performed via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of the transformation to download the API specification for. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> DownloadInputFileTransformationAsync(
                string transformationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transformations/{transformation_id}/input-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transformation_id", transformationId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a list of all API transformations performed.
        /// </summary>
        /// <returns>Returns the List of Models.Transformation response from the API call.</returns>
        public List<Models.Transformation> ListAllTransformations()
            => CoreHelper.RunTask(ListAllTransformationsAsync());

        /// <summary>
        /// Get a list of all API transformations performed.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Transformation response from the API call.</returns>
        public async Task<List<Models.Transformation>> ListAllTransformationsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Transformation>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transformations")
                  .WithAuth("Authorization"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get details on a particular Transformation performed via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of the transformation to fetch. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL  ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        /// <returns>Returns the Models.Transformation response from the API call.</returns>
        public Models.Transformation GetATransformation(
                string transformationId)
            => CoreHelper.RunTask(GetATransformationAsync(transformationId));

        /// <summary>
        /// Get details on a particular Transformation performed via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of the transformation to fetch. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL  ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Transformation response from the API call.</returns>
        public async Task<Models.Transformation> GetATransformationAsync(
                string transformationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Transformation>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transformations/{transformation_id}")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transformation_id", transformationId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a particular Transformation performed for an API via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of the transformation to delete. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        public void DeleteTransformation(
                string transformationId)
            => CoreHelper.RunVoidTask(DeleteTransformationAsync(transformationId));

        /// <summary>
        /// Delete a particular Transformation performed for an API via the Transformation endpoints.
        /// </summary>
        /// <param name="transformationId">Required parameter: The ID of the transformation to delete. The transformation ID is received in the response of the [Transform Via File ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-file) or [Transform Via URL](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/transformation/transform-via-url) calls..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteTransformationAsync(
                string transformationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/transformations/{transformation_id}")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transformation_id", transformationId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}