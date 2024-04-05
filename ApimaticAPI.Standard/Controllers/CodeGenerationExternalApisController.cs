// <copyright file="CodeGenerationExternalApisController.cs" company="APIMatic">
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
    /// CodeGenerationExternalApisController.
    /// </summary>
    public class CodeGenerationExternalApisController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGenerationExternalApisController"/> class.
        /// </summary>
        internal CodeGenerationExternalApisController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Generate an SDK for an API by by uploading the API specification file. .
        /// This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.
        /// This endpoint does not import an API into APIMatic.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="template">Required parameter: The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in..</param>
        /// <returns>Returns the Models.UserCodeGeneration response from the API call.</returns>
        public Models.UserCodeGeneration GenerateSDKViaFile(
                FileStreamInfo file,
                Models.Platforms template)
            => CoreHelper.RunTask(GenerateSDKViaFileAsync(file, template));

        /// <summary>
        /// Generate an SDK for an API by by uploading the API specification file. .
        /// This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.
        /// This endpoint does not import an API into APIMatic.
        /// </summary>
        /// <param name="file"><![CDATA[Required parameter: The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats)..]]></param>
        /// <param name="template">Required parameter: The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserCodeGeneration response from the API call.</returns>
        public async Task<Models.UserCodeGeneration> GenerateSDKViaFileAsync(
                FileStreamInfo file,
                Models.Platforms template,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserCodeGeneration>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/code-generations/generate-via-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))
                      .Form(_form => _form.Setup("template", ApiHelper.JsonSerialize(template).Trim('\"')))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Generate an SDK for an API by providing the URL of the API specification file. .
        /// This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.
        /// This endpoint does not import an API into APIMatic.
        /// </summary>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <returns>Returns the Models.UserCodeGeneration response from the API call.</returns>
        public Models.UserCodeGeneration GenerateSDKViaURL(
                Models.GenerateSdkViaUrlRequest body)
            => CoreHelper.RunTask(GenerateSDKViaURLAsync(body));

        /// <summary>
        /// Generate an SDK for an API by providing the URL of the API specification file. .
        /// This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.
        /// This endpoint does not import an API into APIMatic.
        /// </summary>
        /// <param name="body">Required parameter: Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserCodeGeneration response from the API call.</returns>
        public async Task<Models.UserCodeGeneration> GenerateSDKViaURLAsync(
                Models.GenerateSdkViaUrlRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserCodeGeneration>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/code-generations/generate-via-url")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.apimatic.userCodeGenerationDto.v1+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download the SDK generated via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of code generation received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls..</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream DownloadGeneratedSDK(
                string codegenId)
            => CoreHelper.RunTask(DownloadGeneratedSDKAsync(codegenId));

        /// <summary>
        /// Download the SDK generated via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of code generation received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> DownloadGeneratedSDKAsync(
                string codegenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/code-generations/{codegen_id}/generated-sdk")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("codegen_id", codegenId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a list of all SDK generations performed with external APIs via the Generate SDK endpoints.
        /// </summary>
        /// <returns>Returns the List of Models.UserCodeGeneration response from the API call.</returns>
        public List<Models.UserCodeGeneration> ListAllCodeGenerationsExternal()
            => CoreHelper.RunTask(ListAllCodeGenerationsExternalAsync());

        /// <summary>
        /// Get a list of all SDK generations performed with external APIs via the Generate SDK endpoints.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.UserCodeGeneration response from the API call.</returns>
        public async Task<List<Models.UserCodeGeneration>> ListAllCodeGenerationsExternalAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.UserCodeGeneration>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/code-generations")
                  .WithAuth("Authorization"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download the API Specification file used as input for a specific SDK generation performed via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of the code generation to download the API specification for. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls.</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream DownloadInputFileCodegen(
                string codegenId)
            => CoreHelper.RunTask(DownloadInputFileCodegenAsync(codegenId));

        /// <summary>
        /// Download the API Specification file used as input for a specific SDK generation performed via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of the code generation to download the API specification for. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> DownloadInputFileCodegenAsync(
                string codegenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/code-generations/{codegen_id}/input-file")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("codegen_id", codegenId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get details on an SDK generation performed for an external API via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of the code generation to fetch. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls..</param>
        /// <returns>Returns the Models.UserCodeGeneration response from the API call.</returns>
        public Models.UserCodeGeneration GetACodeGenerationCodegen(
                string codegenId)
            => CoreHelper.RunTask(GetACodeGenerationCodegenAsync(codegenId));

        /// <summary>
        /// Get details on an SDK generation performed for an external API via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of the code generation to fetch. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserCodeGeneration response from the API call.</returns>
        public async Task<Models.UserCodeGeneration> GetACodeGenerationCodegenAsync(
                string codegenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserCodeGeneration>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/code-generations/{codegen_id}")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("codegen_id", codegenId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an SDK generation performed for an API via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of the code generation to delete. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls..</param>
        public void DeleteCodeGeneration1(
                string codegenId)
            => CoreHelper.RunVoidTask(DeleteCodeGeneration1Async(codegenId));

        /// <summary>
        /// Delete an SDK generation performed for an API via the Generate SDK endpoints.
        /// </summary>
        /// <param name="codegenId">Required parameter: The ID of the code generation to delete. The code generation ID is received in the response of the [Generate SDK Via File](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-file) or [Generate SDK Via URL ](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-external-apis/generate-sdk-via-url) calls..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCodeGeneration1Async(
                string codegenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/code-generations/{codegen_id}")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("codegen_id", codegenId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}