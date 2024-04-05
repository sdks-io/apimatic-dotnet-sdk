// <copyright file="DocsPortalManagementController.cs" company="APIMatic">
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
    /// DocsPortalManagementController.
    /// </summary>
    public class DocsPortalManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsPortalManagementController"/> class.
        /// </summary>
        internal DocsPortalManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Publish artifacts for a Hosted Portal.
        /// This endpoint regenerates all the artifacts for a hosted portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// Call this endpoint to update your Hosted Portal after you update an API Entity via any of the Import API Endpoints.
        /// __**Note: If you have an embedded portal against the same API Entity, artifacts for that portal will get updated as well.**__.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to update the portal artifacts for..</param>
        public void PublishHostedPortal(
                string apiEntityId)
            => CoreHelper.RunVoidTask(PublishHostedPortalAsync(apiEntityId));

        /// <summary>
        /// Publish artifacts for a Hosted Portal.
        /// This endpoint regenerates all the artifacts for a hosted portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// Call this endpoint to update your Hosted Portal after you update an API Entity via any of the Import API Endpoints.
        /// __**Note: If you have an embedded portal against the same API Entity, artifacts for that portal will get updated as well.**__.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to update the portal artifacts for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task PublishHostedPortalAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api-entities/{api_entity_id}/hosted-portal")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Publish artifacts for an Embedded Portal and get the Portal Embed script.
        /// This endpoint regenerates all the artifacts for an embedded portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// Call this endpoint to update your Embedded Portal after you update an API Entity via any of the Import API Endpoints. This endpoint returns the Portal Embed script in the response.
        /// __**Note: If you have a hosted portal against the same API Entity, artifacts for that portal will get updated as well.**__.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to update the portal artifacts for..</param>
        public void PublishEmbeddedPortal(
                string apiEntityId)
            => CoreHelper.RunVoidTask(PublishEmbeddedPortalAsync(apiEntityId));

        /// <summary>
        /// Publish artifacts for an Embedded Portal and get the Portal Embed script.
        /// This endpoint regenerates all the artifacts for an embedded portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// Call this endpoint to update your Embedded Portal after you update an API Entity via any of the Import API Endpoints. This endpoint returns the Portal Embed script in the response.
        /// __**Note: If you have a hosted portal against the same API Entity, artifacts for that portal will get updated as well.**__.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to update the portal artifacts for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task PublishEmbeddedPortalAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api-entities/{api_entity_id}/embedded-portal")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Generate an On-premise Documentation Portal for an API Entity. This endpoint generates all artifacts for the Portal and packages them together into a zip file along with the required HTML, CSS and JS files. The generated artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// The endpoint returns a zip file that contains a static Site and can be hosted on any Web Server.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to generate the Portal for..</param>
        public void GenerateOnPremPortalViaAPIEntity(
                string apiEntityId)
            => CoreHelper.RunVoidTask(GenerateOnPremPortalViaAPIEntityAsync(apiEntityId));

        /// <summary>
        /// Generate an On-premise Documentation Portal for an API Entity. This endpoint generates all artifacts for the Portal and packages them together into a zip file along with the required HTML, CSS and JS files. The generated artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// The endpoint returns a zip file that contains a static Site and can be hosted on any Web Server.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to generate the Portal for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task GenerateOnPremPortalViaAPIEntityAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api-entities/{api_entity_id}/on-prem-portal")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Generate an On-premise Documentation Portal by uploading a Portal Build Input. This endpoint generates all artifacts for the Portal and packages them together into a zip file along with the required HTML, CSS and JS files. The generated artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// The endpoint returns a zip file that contains a static Site and can be hosted on any Web Server.
        /// </summary>
        /// <param name="file">Required parameter: The input file to the Portal Generator. Must contain the build file..</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream GenerateOnPremPortalViaBuildInput(
                FileStreamInfo file)
            => CoreHelper.RunTask(GenerateOnPremPortalViaBuildInputAsync(file));

        /// <summary>
        /// Generate an On-premise Documentation Portal by uploading a Portal Build Input. This endpoint generates all artifacts for the Portal and packages them together into a zip file along with the required HTML, CSS and JS files. The generated artifacts include:.
        /// 1. SDKs.
        /// 2. Docs.
        /// 3. API Specification files.
        /// The endpoint returns a zip file that contains a static Site and can be hosted on any Web Server.
        /// </summary>
        /// <param name="file">Required parameter: The input file to the Portal Generator. Must contain the build file..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> GenerateOnPremPortalViaBuildInputAsync(
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/portal")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("402", CreateErrorCase("Subscription Issue", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Generate Build Input for a Portal created using the UI workflow.  The Build Input will correspond to the draft version of the Portal i.e. unpublished changes will also be included.
        /// This can be used to create a backup of your Portal or to migrate from the UI workflow to the docs as code workflow.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: Example: .</param>
        /// <param name="apiEntities">Optional parameter: Example: .</param>
        /// <returns>Returns the string response from the API call.</returns>
        public string GenerateBuildInputForUnpublishedPortal(
                string apiGroupId,
                List<string> apiEntities = null)
            => CoreHelper.RunTask(GenerateBuildInputForUnpublishedPortalAsync(apiGroupId, apiEntities));

        /// <summary>
        /// Generate Build Input for a Portal created using the UI workflow.  The Build Input will correspond to the draft version of the Portal i.e. unpublished changes will also be included.
        /// This can be used to create a backup of your Portal or to migrate from the UI workflow to the docs as code workflow.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: Example: .</param>
        /// <param name="apiEntities">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> GenerateBuildInputForUnpublishedPortalAsync(
                string apiGroupId,
                List<string> apiEntities = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/portal/build/{apiGroupId}/draft")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("apiGroupId", apiGroupId))
                      .Query(_query => _query.Setup("apiEntities", apiEntities))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Generate Build Input for a Portal created using the UI workflow.  The Build Input will correspond to the published version of the Portal i.e. unpublished changes will not be inlcuded.
        /// This can be used to create a backup of your Portal or to migrate from the UI workflow to the docs as code workflow.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: Example: .</param>
        /// <param name="apiEntities">Optional parameter: Example: .</param>
        /// <returns>Returns the string response from the API call.</returns>
        public string GenerateBuildInputForPublishedPortal(
                string apiGroupId,
                List<string> apiEntities = null)
            => CoreHelper.RunTask(GenerateBuildInputForPublishedPortalAsync(apiGroupId, apiEntities));

        /// <summary>
        /// Generate Build Input for a Portal created using the UI workflow.  The Build Input will correspond to the published version of the Portal i.e. unpublished changes will not be inlcuded.
        /// This can be used to create a backup of your Portal or to migrate from the UI workflow to the docs as code workflow.
        /// </summary>
        /// <param name="apiGroupId">Required parameter: Example: .</param>
        /// <param name="apiEntities">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> GenerateBuildInputForPublishedPortalAsync(
                string apiGroupId,
                List<string> apiEntities = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/portal/build/{apiGroupId}/published")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("apiGroupId", apiGroupId))
                      .Query(_query => _query.Setup("apiEntities", apiEntities))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Unpublish a Hosted or Embedded Portal published for an API Entity. Calling this endpoint deletes all the published artifacts for a Portal from APIMatic's cloud storage. .
        /// In case of a Hosted Portal, to completely remove the Portal, this endpoint needs to be called against all API versions that the Portal hosts. .
        /// In case of an Embedded Portal, to completely remove the Portal, the user needs to manually remove the Portal Embed script from the embedding site.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to unpublish the Portal artifacts for..</param>
        public void UnpublishPortal(
                string apiEntityId)
            => CoreHelper.RunVoidTask(UnpublishPortalAsync(apiEntityId));

        /// <summary>
        /// Unpublish a Hosted or Embedded Portal published for an API Entity. Calling this endpoint deletes all the published artifacts for a Portal from APIMatic's cloud storage. .
        /// In case of a Hosted Portal, to completely remove the Portal, this endpoint needs to be called against all API versions that the Portal hosts. .
        /// In case of an Embedded Portal, to completely remove the Portal, the user needs to manually remove the Portal Embed script from the embedding site.
        /// </summary>
        /// <param name="apiEntityId">Required parameter: The ID of the API Entity to unpublish the Portal artifacts for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UnpublishPortalAsync(
                string apiEntityId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/api-entities/{api_entity_id}/portal")
                  .WithAuth("Authorization")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("api_entity_id", apiEntityId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}