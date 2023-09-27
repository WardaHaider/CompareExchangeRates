// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ExchangeRateAPI.Standard.Controllers
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
    using ExchangeRateAPI.Standard;
    using ExchangeRateAPI.Standard.Exceptions;
    using ExchangeRateAPI.Standard.Http.Client;
    using ExchangeRateAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        internal APIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns latest exchange rates in parameter-supplied base currency.
        /// </summary>
        /// <param name="baseCurrency">Required parameter: **Base Currency**. *Example: USD*. You an use any of the ISO 4217 currency codes we support. See https://www.exchangerate-api.com/docs/supported-currencies.</param>
        /// <returns>Returns the Models.LatestResponse response from the API call.</returns>
        public Models.LatestResponse LatestExchangeRates(
                string baseCurrency)
            => CoreHelper.RunTask(LatestExchangeRatesAsync(baseCurrency));

        /// <summary>
        /// Returns latest exchange rates in parameter-supplied base currency.
        /// </summary>
        /// <param name="baseCurrency">Required parameter: **Base Currency**. *Example: USD*. You an use any of the ISO 4217 currency codes we support. See https://www.exchangerate-api.com/docs/supported-currencies.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LatestResponse response from the API call.</returns>
        public async Task<Models.LatestResponse> LatestExchangeRatesAsync(
                string baseCurrency,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LatestResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/latest/{base_currency}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("base_currency", baseCurrency))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Currency code not supported", (_reason, _context) => new Latest404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}