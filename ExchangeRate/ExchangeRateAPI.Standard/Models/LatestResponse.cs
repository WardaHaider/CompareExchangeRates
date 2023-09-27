// <copyright file="LatestResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ExchangeRateAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using ExchangeRateAPI.Standard;
    using ExchangeRateAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// LatestResponse.
    /// </summary>
    public class LatestResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestResponse"/> class.
        /// </summary>
        public LatestResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatestResponse"/> class.
        /// </summary>
        /// <param name="mBase">base.</param>
        /// <param name="date">date.</param>
        /// <param name="rates">rates.</param>
        /// <param name="timeLastUpdated">time_last_updated.</param>
        public LatestResponse(
            string mBase = null,
            string date = null,
            Dictionary<string, double> rates = null,
            int? timeLastUpdated = null)
        {
            this.MBase = mBase;
            this.Date = date;
            this.Rates = rates;
            this.TimeLastUpdated = timeLastUpdated;
        }

        /// <summary>
        /// The currency code you supplied as base in your request
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public string MBase { get; set; }

        /// <summary>
        /// The date these exchange rates are for
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// Each supported currency code in terms of the base currency
        /// </summary>
        [JsonProperty("rates", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> Rates { get; set; }

        /// <summary>
        /// The epoch time this set of exchange rates was generated
        /// </summary>
        [JsonProperty("time_last_updated", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeLastUpdated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LatestResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is LatestResponse other &&                ((this.MBase == null && other.MBase == null) || (this.MBase?.Equals(other.MBase) == true)) &&
                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                ((this.Rates == null && other.Rates == null) || (this.Rates?.Equals(other.Rates) == true)) &&
                ((this.TimeLastUpdated == null && other.TimeLastUpdated == null) || (this.TimeLastUpdated?.Equals(other.TimeLastUpdated) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MBase = {(this.MBase == null ? "null" : this.MBase)}");
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date)}");
            toStringOutput.Add($"Rates = {(this.Rates == null ? "null" : this.Rates.ToString())}");
            toStringOutput.Add($"this.TimeLastUpdated = {(this.TimeLastUpdated == null ? "null" : this.TimeLastUpdated.ToString())}");
        }
    }
}