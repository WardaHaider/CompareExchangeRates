// <copyright file="ChartController.cs" company="APIMatic">
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
    using ImageCharts.Standard.Http.Client;
    using ImageCharts.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// ChartController.
    /// </summary>
    public class ChartController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartController"/> class.
        /// </summary>
        internal ChartController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Image-charts.
        /// </summary>
        /// <param name="cht">Required parameter: Chart type.</param>
        /// <param name="chl">Required parameter: bar, pie slice, doughnut slice and polar slice chart labels.</param>
        /// <param name="chd">Required parameter: chart data.</param>
        /// <param name="chs">Required parameter: Chart Size (Width x height).</param>
        /// <param name="chds">Optional parameter: data format with custom scaling.</param>
        /// <param name="choe">Optional parameter: QRCode data encoding.</param>
        /// <param name="chld">Optional parameter: QRCode error correction level and optional margin.</param>
        /// <param name="chxr">Optional parameter: Axis data-range.</param>
        /// <param name="chxp">Optional parameter: axis label positions.</param>
        /// <param name="chof">Optional parameter: Image output format.</param>
        /// <param name="chdl">Optional parameter: Text for each series, to display in the legend.</param>
        /// <param name="chdls">Optional parameter: Chart legend text and style.</param>
        /// <param name="chg">Optional parameter: Solid or dotted grid lines.</param>
        /// <param name="chco">Optional parameter: series colors.</param>
        /// <param name="chtt">Optional parameter: chart title.</param>
        /// <param name="chts">Optional parameter: chart title colors and font size.</param>
        /// <param name="chxt">Optional parameter: Display values on your axis lines or change which axes are shown.</param>
        /// <param name="chxl">Optional parameter: Custom string axis labels on any axis.</param>
        /// <param name="chxs">Optional parameter: Font size, color for axis labels, both custom labels and default label values.</param>
        /// <param name="chm">Optional parameter: compound charts and line fills.</param>
        /// <param name="chls">Optional parameter: line thickness and solid/dashed style.</param>
        /// <param name="chlps">Optional parameter: Position and style of labels on data.</param>
        /// <param name="chma">Optional parameter: chart margins.</param>
        /// <param name="chdlp">Optional parameter: Position of the legend and order of the legend entries.</param>
        /// <param name="chf">Optional parameter: Background Fills.</param>
        /// <param name="chbh">Optional parameter: Bar Width and Spacing. (not supported)  You can optionally specify custom values for bar widths and spacing between bars and groups. You can only specify one set of width values for all bars. If you don't specify chbh, all bars will be 23 pixels wide, which means that the end bars can be clipped if the total bar + space width is wider than the chart width..</param>
        /// <param name="chbr">Optional parameter: Bar corner radius. Display bars with rounded corner..</param>
        /// <param name="chan">Optional parameter: gif configuration.</param>
        /// <param name="chli">Optional parameter: doughnut chart inside label.</param>
        /// <param name="icac">Optional parameter: image-charts enterprise `account_id`.</param>
        /// <param name="ichm">Optional parameter: HMAC-SHA256 signature required to activate paid features.</param>
        /// <param name="icff">Optional parameter: Default font family for all text from Google Fonts. Use same syntax as Google Font CSS API.</param>
        /// <param name="icfs">Optional parameter: Default font style for all text.</param>
        /// <param name="iclocale">Optional parameter: localization (ISO 639-1).</param>
        /// <param name="icwt">Optional parameter: (Private) Force to display the watermark EVEN IF the chart was signed with an enterprise account.</param>
        /// <param name="icretina">Optional parameter: retina mode.</param>
        /// <param name="icqrb">Optional parameter: Background color for QR Codes.</param>
        /// <param name="icqrf">Optional parameter: Foreground color for QR Codes.</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic GetChart(
                Models.ChtEnum cht,
                string chl,
                string chd,
                string chs,
                string chds = null,
                Models.ChoeEnum? choe = null,
                string chld = null,
                string chxr = null,
                string chxp = null,
                string chof = ".png",
                string chdl = null,
                string chdls = "000000",
                string chg = null,
                string chco = "F56991,FF9F80,FFC48C,D1F2A5,EFFAB4",
                string chtt = null,
                string chts = null,
                string chxt = null,
                string chxl = null,
                string chxs = null,
                string chm = null,
                string chls = null,
                string chlps = null,
                string chma = null,
                string chdlp = "r",
                string chf = "bg,s,FFFFFF",
                string chbh = "10",
                string chbr = "0",
                string chan = null,
                string chli = null,
                string icac = null,
                string ichm = null,
                Models.IcffEnum? icff = null,
                Models.IcfsEnum? icfs = null,
                Models.IclocaleEnum? iclocale = null,
                bool? icwt = false,
                Models.IcretinaEnum? icretina = null,
                string icqrb = "FFFFFF",
                string icqrf = "000000")
            => CoreHelper.RunTask(GetChartAsync(cht, chl, chd, chs, chds, choe, chld, chxr, chxp, chof, chdl, chdls, chg, chco, chtt, chts, chxt, chxl, chxs, chm, chls, chlps, chma, chdlp, chf, chbh, chbr, chan, chli, icac, ichm, icff, icfs, iclocale, icwt, icretina, icqrb, icqrf));

        /// <summary>
        /// Image-charts.
        /// </summary>
        /// <param name="cht">Required parameter: Chart type.</param>
        /// <param name="chl">Required parameter: bar, pie slice, doughnut slice and polar slice chart labels.</param>
        /// <param name="chd">Required parameter: chart data.</param>
        /// <param name="chs">Required parameter: Chart Size (Width x height).</param>
        /// <param name="chds">Optional parameter: data format with custom scaling.</param>
        /// <param name="choe">Optional parameter: QRCode data encoding.</param>
        /// <param name="chld">Optional parameter: QRCode error correction level and optional margin.</param>
        /// <param name="chxr">Optional parameter: Axis data-range.</param>
        /// <param name="chxp">Optional parameter: axis label positions.</param>
        /// <param name="chof">Optional parameter: Image output format.</param>
        /// <param name="chdl">Optional parameter: Text for each series, to display in the legend.</param>
        /// <param name="chdls">Optional parameter: Chart legend text and style.</param>
        /// <param name="chg">Optional parameter: Solid or dotted grid lines.</param>
        /// <param name="chco">Optional parameter: series colors.</param>
        /// <param name="chtt">Optional parameter: chart title.</param>
        /// <param name="chts">Optional parameter: chart title colors and font size.</param>
        /// <param name="chxt">Optional parameter: Display values on your axis lines or change which axes are shown.</param>
        /// <param name="chxl">Optional parameter: Custom string axis labels on any axis.</param>
        /// <param name="chxs">Optional parameter: Font size, color for axis labels, both custom labels and default label values.</param>
        /// <param name="chm">Optional parameter: compound charts and line fills.</param>
        /// <param name="chls">Optional parameter: line thickness and solid/dashed style.</param>
        /// <param name="chlps">Optional parameter: Position and style of labels on data.</param>
        /// <param name="chma">Optional parameter: chart margins.</param>
        /// <param name="chdlp">Optional parameter: Position of the legend and order of the legend entries.</param>
        /// <param name="chf">Optional parameter: Background Fills.</param>
        /// <param name="chbh">Optional parameter: Bar Width and Spacing. (not supported)  You can optionally specify custom values for bar widths and spacing between bars and groups. You can only specify one set of width values for all bars. If you don't specify chbh, all bars will be 23 pixels wide, which means that the end bars can be clipped if the total bar + space width is wider than the chart width..</param>
        /// <param name="chbr">Optional parameter: Bar corner radius. Display bars with rounded corner..</param>
        /// <param name="chan">Optional parameter: gif configuration.</param>
        /// <param name="chli">Optional parameter: doughnut chart inside label.</param>
        /// <param name="icac">Optional parameter: image-charts enterprise `account_id`.</param>
        /// <param name="ichm">Optional parameter: HMAC-SHA256 signature required to activate paid features.</param>
        /// <param name="icff">Optional parameter: Default font family for all text from Google Fonts. Use same syntax as Google Font CSS API.</param>
        /// <param name="icfs">Optional parameter: Default font style for all text.</param>
        /// <param name="iclocale">Optional parameter: localization (ISO 639-1).</param>
        /// <param name="icwt">Optional parameter: (Private) Force to display the watermark EVEN IF the chart was signed with an enterprise account.</param>
        /// <param name="icretina">Optional parameter: retina mode.</param>
        /// <param name="icqrb">Optional parameter: Background color for QR Codes.</param>
        /// <param name="icqrf">Optional parameter: Foreground color for QR Codes.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> GetChartAsync(
                Models.ChtEnum cht,
                string chl,
                string chd,
                string chs,
                string chds = null,
                Models.ChoeEnum? choe = null,
                string chld = null,
                string chxr = null,
                string chxp = null,
                string chof = ".png",
                string chdl = null,
                string chdls = "000000",
                string chg = null,
                string chco = "F56991,FF9F80,FFC48C,D1F2A5,EFFAB4",
                string chtt = null,
                string chts = null,
                string chxt = null,
                string chxl = null,
                string chxs = null,
                string chm = null,
                string chls = null,
                string chlps = null,
                string chma = null,
                string chdlp = "r",
                string chf = "bg,s,FFFFFF",
                string chbh = "10",
                string chbr = "0",
                string chan = null,
                string chli = null,
                string icac = null,
                string ichm = null,
                Models.IcffEnum? icff = null,
                Models.IcfsEnum? icfs = null,
                Models.IclocaleEnum? iclocale = null,
                bool? icwt = false,
                Models.IcretinaEnum? icretina = null,
                string icqrb = "FFFFFF",
                string icqrf = "000000",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<dynamic>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/chart")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("cht", ApiHelper.JsonSerialize(cht).Trim('\"')))
                      .Query(_query => _query.Setup("chl", chl))
                      .Header(_header => _header.Setup("Content-Type", "application/x-www-form-urlencoded"))
                      .Query(_query => _query.Setup("chd", chd))
                      .Query(_query => _query.Setup("chs", chs))
                      .Query(_query => _query.Setup("chds", chds))
                      .Query(_query => _query.Setup("choe", (choe.HasValue) ? ApiHelper.JsonSerialize(choe.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("chld", chld))
                      .Query(_query => _query.Setup("chxr", chxr))
                      .Query(_query => _query.Setup("chxp", chxp))
                      .Query(_query => _query.Setup("chof", (chof != null) ? chof : ".png"))
                      .Query(_query => _query.Setup("chdl", chdl))
                      .Query(_query => _query.Setup("chdls", (chdls != null) ? chdls : "000000"))
                      .Query(_query => _query.Setup("chg", chg))
                      .Query(_query => _query.Setup("chco", (chco != null) ? chco : "F56991,FF9F80,FFC48C,D1F2A5,EFFAB4"))
                      .Query(_query => _query.Setup("chtt", chtt))
                      .Query(_query => _query.Setup("chts", chts))
                      .Query(_query => _query.Setup("chxt", chxt))
                      .Query(_query => _query.Setup("chxl", chxl))
                      .Query(_query => _query.Setup("chxs", chxs))
                      .Query(_query => _query.Setup("chm", chm))
                      .Query(_query => _query.Setup("chls", chls))
                      .Query(_query => _query.Setup("chlps", chlps))
                      .Query(_query => _query.Setup("chma", chma))
                      .Query(_query => _query.Setup("chdlp", (chdlp != null) ? chdlp : "r"))
                      .Query(_query => _query.Setup("chf", (chf != null) ? chf : "bg,s,FFFFFF"))
                      .Query(_query => _query.Setup("chbh", (chbh != null) ? chbh : "10"))
                      .Query(_query => _query.Setup("chbr", (chbr != null) ? chbr : "0"))
                      .Query(_query => _query.Setup("chan", chan))
                      .Query(_query => _query.Setup("chli", chli))
                      .Query(_query => _query.Setup("icac", icac))
                      .Query(_query => _query.Setup("ichm", ichm))
                      .Query(_query => _query.Setup("icff", (icff.HasValue) ? ApiHelper.JsonSerialize(icff.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("icfs", (icfs.HasValue) ? ApiHelper.JsonSerialize(icfs.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("iclocale", (iclocale.HasValue) ? ApiHelper.JsonSerialize(iclocale.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("icwt", (icwt != null) ? icwt : false))
                      .Query(_query => _query.Setup("icretina", (icretina.HasValue) ? ApiHelper.JsonSerialize(icretina.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("icqrb", (icqrb != null) ? icqrb : "FFFFFF"))
                      .Query(_query => _query.Setup("icqrf", (icqrf != null) ? icqrf : "000000"))))
              .ExecuteAsync(cancellationToken);
    }
}