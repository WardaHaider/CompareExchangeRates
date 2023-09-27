// <copyright file="EncodingEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ImageCharts.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using ImageCharts.Standard;
    using ImageCharts.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// EncodingEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncodingEnum
    {
        /// <summary>
        /// Url.
        /// </summary>
        [EnumMember(Value = "url")]
        Url,

        /// <summary>
        /// Base64.
        /// </summary>
        [EnumMember(Value = "base64")]
        Base64
    }
}