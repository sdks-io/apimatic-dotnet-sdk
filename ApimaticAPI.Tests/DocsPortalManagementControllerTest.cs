// <copyright file="DocsPortalManagementControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ApimaticAPI.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities;
    using ApimaticAPI.Standard;
    using ApimaticAPI.Standard.Controllers;
    using ApimaticAPI.Standard.Exceptions;
    using ApimaticAPI.Standard.Http.Client;
    using ApimaticAPI.Standard.Http.Response;
    using ApimaticAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// DocsPortalManagementControllerTest.
    /// </summary>
    [TestFixture]
    public class DocsPortalManagementControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private DocsPortalManagementController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.DocsPortalManagementController;
        }

        /// <summary>
        /// Publish artifacts for a Hosted Portal.
        ///
        ///This endpoint regenerates all the artifacts for a hosted portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:
        ///
        ///1. SDKs
        ///2. Docs
        ///3. API Specification files
        ///
        ///Call this endpoint to update your Hosted Portal after you update an API Entity via any of the Import API Endpoints.
        ///
        ///__**Note: If you have an embedded portal against the same API Entity, artifacts for that portal will get updated as well.**__.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPublishHostedPortal()
        {
            // Parameters for the API call
            string apiEntityId = "5f87f8ab9615d38a2eb990ca";

            // Perform API call
            try
            {
                await this.controller.PublishHostedPortalAsync(apiEntityId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Publish artifacts for an Embedded Portal and get the Portal Embed script.
        ///
        ///This endpoint regenerates all the artifacts for an embedded portal and uploads them to APIMatic's cloud storage, from where the Portal fetches them. These artifacts include:
        ///
        ///1. SDKs
        ///2. Docs
        ///3. API Specification files
        ///
        ///Call this endpoint to update your Embedded Portal after you update an API Entity via any of the Import API Endpoints. This endpoint returns the Portal Embed script in the response.
        ///
        ///__**Note: If you have a hosted portal against the same API Entity, artifacts for that portal will get updated as well.**__.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPublishEmbeddedPortal()
        {
            // Parameters for the API call
            string apiEntityId = "5f87f8ab9615d38a2eb990ca";

            // Perform API call
            try
            {
                await this.controller.PublishEmbeddedPortalAsync(apiEntityId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Generate an On-premise Documentation Portal for an API Entity. This endpoint generates all artifacts for the Portal and packages them together into a zip file along with the required HTML, CSS and JS files. The generated artifacts include:
        ///
        ///1. SDKs
        ///2. Docs
        ///3. API Specification files
        ///
        ///The endpoint returns a zip file that contains a static Site and can be hosted on any Web Server..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGenerateOnPremPortalViaAPIEntity()
        {
            // Parameters for the API call
            string apiEntityId = "5f87f8ab9615d38a2eb990ca";

            // Perform API call
            try
            {
                await this.controller.GenerateOnPremPortalViaAPIEntityAsync(apiEntityId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// Unpublish a Hosted or Embedded Portal published for an API Entity. Calling this endpoint deletes all the published artifacts for a Portal from APIMatic's cloud storage. 
        ///
        ///In case of a Hosted Portal, to completely remove the Portal, this endpoint needs to be called against all API versions that the Portal hosts. 
        ///
        ///In case of an Embedded Portal, to completely remove the Portal, the user needs to manually remove the Portal Embed script from the embedding site..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUnpublishPortal()
        {
            // Parameters for the API call
            string apiEntityId = "5f87f8ab9615d38a2eb990ca";

            // Perform API call
            try
            {
                await this.controller.UnpublishPortalAsync(apiEntityId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}