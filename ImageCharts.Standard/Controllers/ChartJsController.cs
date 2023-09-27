// <copyright file="ChartJsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ImageCharts.Standard.Controllers
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
    using ImageCharts.Standard;
    using ImageCharts.Standard.Exceptions;
    using ImageCharts.Standard.Http.Client;
    using ImageCharts.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// ChartJsController.
    /// </summary>
    public class ChartJsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartJsController"/> class.
        /// </summary>
        internal ChartJsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Image-charts.
        /// </summary>
        /// <param name="c">Optional parameter: Javascript/JSON definition of the chart. Use a Chart.js configuration object..</param>
        /// <param name="chart">Optional parameter: Javascript/JSON definition of the chart. Use a Chart.js configuration object..</param>
        /// <param name="width">Optional parameter: Width of the chart.</param>
        /// <param name="height">Optional parameter: Height of the chart.</param>
        /// <param name="backgroundColor">Optional parameter: Background of the chart canvas. Accepts rgb (rgb(255,255,120)), colors (red), and url-encoded hex values (%23ff00ff). Abbreviated as "bkg".</param>
        /// <param name="bkg">Optional parameter: Background of the chart canvas. Accepts rgb (rgb(255,255,120)), colors (red), and url-encoded hex values (%23ff00ff). Abbreviated as "bkg".</param>
        /// <param name="encoding">Optional parameter: Encoding of your "chart" parameter. Accepted values are url and base64..</param>
        /// <param name="icac">Optional parameter: image-charts enterprise `account_id`.</param>
        /// <param name="ichm">Optional parameter: HMAC-SHA256 signature required to activate paid features.</param>
        /// <param name="icretina">Optional parameter: retina mode.</param>
        public void GetChartjs280(
                string c = null,
                string chart = null,
                int? width = 500,
                int? height = 300,
                string backgroundColor = null,
                string bkg = null,
                Models.EncodingEnum? encoding = Models.EncodingEnum.Url,
                string icac = null,
                string ichm = null,
                Models.IcretinaEnum? icretina = null)
            => CoreHelper.RunVoidTask(GetChartjs280Async(c, chart, width, height, backgroundColor, bkg, encoding, icac, ichm, icretina));

        /// <summary>
        /// Image-charts.
        /// </summary>
        /// <param name="c">Optional parameter: Javascript/JSON definition of the chart. Use a Chart.js configuration object..</param>
        /// <param name="chart">Optional parameter: Javascript/JSON definition of the chart. Use a Chart.js configuration object..</param>
        /// <param name="width">Optional parameter: Width of the chart.</param>
        /// <param name="height">Optional parameter: Height of the chart.</param>
        /// <param name="backgroundColor">Optional parameter: Background of the chart canvas. Accepts rgb (rgb(255,255,120)), colors (red), and url-encoded hex values (%23ff00ff). Abbreviated as "bkg".</param>
        /// <param name="bkg">Optional parameter: Background of the chart canvas. Accepts rgb (rgb(255,255,120)), colors (red), and url-encoded hex values (%23ff00ff). Abbreviated as "bkg".</param>
        /// <param name="encoding">Optional parameter: Encoding of your "chart" parameter. Accepted values are url and base64..</param>
        /// <param name="icac">Optional parameter: image-charts enterprise `account_id`.</param>
        /// <param name="ichm">Optional parameter: HMAC-SHA256 signature required to activate paid features.</param>
        /// <param name="icretina">Optional parameter: retina mode.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task GetChartjs280Async(
                string c = null,
                string chart = null,
                int? width = 500,
                int? height = 300,
                string backgroundColor = null,
                string bkg = null,
                Models.EncodingEnum? encoding = Models.EncodingEnum.Url,
                string icac = null,
                string ichm = null,
                Models.IcretinaEnum? icretina = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/chart.js/2.8.0")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("Content-Type", "application/x-www-form-urlencoded"))
                      .Query(_query => _query.Setup("c", c))
                      .Query(_query => _query.Setup("chart", chart))
                      .Query(_query => _query.Setup("width", (width != null) ? width : 500))
                      .Query(_query => _query.Setup("height", (height != null) ? height : 300))
                      .Query(_query => _query.Setup("backgroundColor", backgroundColor))
                      .Query(_query => _query.Setup("bkg", bkg))
                      .Query(_query => _query.Setup("encoding", (encoding.HasValue) ? ApiHelper.JsonSerialize(encoding.Value).Trim('\"') : "url"))
                      .Query(_query => _query.Setup("icac", icac))
                      .Query(_query => _query.Setup("ichm", ichm))
                      .Query(_query => _query.Setup("icretina", (icretina.HasValue) ? ApiHelper.JsonSerialize(icretina.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Successful", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}