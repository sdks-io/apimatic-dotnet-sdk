// <copyright file="BaseController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ApimaticAPI.Standard.Controllers
{
    using APIMatic.Core;
    using APIMatic.Core.Http.Configuration;
    using APIMatic.Core.Response;
    using ApimaticAPI.Standard.Exceptions;
    using ApimaticAPI.Standard.Http.Client;
    using ApimaticAPI.Standard.Http.Request;
    using ApimaticAPI.Standard.Http.Response;
    using ApimaticAPI.Standard.Utilities;
    using System;

    /// <summary>
    /// The base class for all controller classes.
    /// </summary>
    public class BaseController
    {
        private readonly GlobalConfiguration globalConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        internal BaseController(GlobalConfiguration config) => globalConfiguration = config;

        protected static ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException> CreateErrorCase(string reason, Func<string, HttpContext, ApiException> error, bool isErrorTemplate = false)
            => new ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>(reason, error, isErrorTemplate);

        protected ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T> CreateApiCall<T>(ArraySerialization arraySerialization = ArraySerialization.Indexed)
            => new ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T>(
                globalConfiguration,
                compatibilityFactory,
                serialization: arraySerialization
            );

        private static readonly CompatibilityFactory compatibilityFactory = new CompatibilityFactory();
    }
}