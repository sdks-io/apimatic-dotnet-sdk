// <copyright file="CodeGenerationImportedApisController.cs" company="APIMatic">
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
    /// CodeGenerationImportedApisController.
    /// </summary>
    public class CodeGenerationImportedApisController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGenerationImportedApisController"/> class.
        /// </summary>
        internal CodeGenerationImportedApisController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Generate an SDK for an API Version. .
        /// This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to generate the SDK for..</param>
        /// <param name="template">Required parameter: The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in..</param>
        /// <returns>Returns the Models.APIEntityCodeGeneration response from the API call.</returns>
        public Models.APIEntityCodeGeneration GenerateSDK(
                string apiEntityId,
                Models.Platforms template)
            => CoreHelper.RunTask(GenerateSDKAsync(apiEntityId, template));

        /// <summary>
        /// Generate an SDK for an API Version. .
        /// This endpoint generates and then uploads the generated SDK to APIMatic's cloud storage. An ID for the generation performed is returned as part of the response.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to generate the SDK for..</param>
        /// <param name="template">Required parameter: The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.APIEntityCodeGeneration response from the API call.</returns>
        public async Task<Models.APIEntityCodeGeneration> GenerateSDKAsync(
                string apiEntityId,
                Models.Platforms template,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.APIEntityCodeGeneration>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api-entities/{api_entity_id}/code-generations/generate")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))
                      .Header(_header => _header.Setup("Content-Type", "application/x-www-form-urlencoded"))
                      .Form(_form => _form.Setup("template", ApiHelper.JsonSerialize(template).Trim('\"')))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download the SDK generated via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity for which the SDK was generated..</param>
        /// <param name="codegenId">Required parameter: The ID of code generation received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk)..</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream DownloadSDK(
                string apiEntityId,
                string codegenId)
            => CoreHelper.RunTask(DownloadSDKAsync(apiEntityId, codegenId));

        /// <summary>
        /// Download the SDK generated via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity for which the SDK was generated..</param>
        /// <param name="codegenId">Required parameter: The ID of code generation received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> DownloadSDKAsync(
                string apiEntityId,
                string codegenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}/code-generations/{codegen_id}/generated-sdk")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))
                      .Template(_template => _template.Setup("codegen_id", codegenId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a list of all SDK generations done against an API Version via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity for which to list code generations..</param>
        /// <returns>Returns the List of Models.APIEntityCodeGeneration response from the API call.</returns>
        public List<Models.APIEntityCodeGeneration> ListAllCodeGenerationsImported(
                string apiEntityId)
            => CoreHelper.RunTask(ListAllCodeGenerationsImportedAsync(apiEntityId));

        /// <summary>
        /// Get a list of all SDK generations done against an API Version via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity for which to list code generations..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.APIEntityCodeGeneration response from the API call.</returns>
        public async Task<List<Models.APIEntityCodeGeneration>> ListAllCodeGenerationsImportedAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.APIEntityCodeGeneration>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}/code-generations")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get details on an SDK generation performed via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to fetch the code generation for..</param>
        /// <param name="codegenId">Required parameter: The ID of the code generation to fetch. The code generation ID is received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk)..</param>
        /// <returns>Returns the Models.APIEntityCodeGeneration response from the API call.</returns>
        public Models.APIEntityCodeGeneration GetACodeGenerationImported(
                string apiEntityId,
                string codegenId)
            => CoreHelper.RunTask(GetACodeGenerationImportedAsync(apiEntityId, codegenId));

        /// <summary>
        /// Get details on an SDK generation performed via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to fetch the code generation for..</param>
        /// <param name="codegenId">Required parameter: The ID of the code generation to fetch. The code generation ID is received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.APIEntityCodeGeneration response from the API call.</returns>
        public async Task<Models.APIEntityCodeGeneration> GetACodeGenerationImportedAsync(
                string apiEntityId,
                string codegenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.APIEntityCodeGeneration>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}/code-generations/{codegen_id}")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))
                      .Template(_template => _template.Setup("codegen_id", codegenId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an SDK generation performed for an API Version via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to delete the code generation for..</param>
        /// <param name="codegenId">Required parameter: The ID of the code generation to delete. The code generation ID is received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk)..</param>
        public void DeleteCodeGeneration(
                string apiEntityId,
                string codegenId)
            => CoreHelper.RunVoidTask(DeleteCodeGenerationAsync(apiEntityId, codegenId));

        /// <summary>
        /// Delete an SDK generation performed for an API Version via the Generate SDK endpoint.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to delete the code generation for..</param>
        /// <param name="codegenId">Required parameter: The ID of the code generation to delete. The code generation ID is received in the response of the [SDK generation call](https://www.apimatic.io/api-docs-preview/dashboard/60eea3b7a73395c3052d961b/v/3_0#/http/api-endpoints/code-generation-imported-apis/generate-sdk)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCodeGenerationAsync(
                string apiEntityId,
                string codegenId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/api-entities/{api_entity_id}/code-generations/{codegen_id}")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))
                      .Template(_template => _template.Setup("codegen_id", codegenId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}