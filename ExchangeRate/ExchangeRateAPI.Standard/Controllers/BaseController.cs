// <copyright file="BaseController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ExchangeRateAPI.Standard.Controllers
{
    using APIMatic.Core;
    using APIMatic.Core.Response;
    using ExchangeRateAPI.Standard.Exceptions;
    using ExchangeRateAPI.Standard.Http.Client;
    using ExchangeRateAPI.Standard.Http.Request;
    using ExchangeRateAPI.Standard.Http.Response;
    using ExchangeRateAPI.Standard.Utilities;
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

        protected ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T> CreateApiCall<T>()
            => new ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T>(
                globalConfiguration,
                compatibilityFactory
            );

        private static readonly CompatibilityFactory compatibilityFactory = new CompatibilityFactory();
    }
}