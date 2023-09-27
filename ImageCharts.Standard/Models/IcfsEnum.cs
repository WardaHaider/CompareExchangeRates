// <copyright file="IcfsEnum.cs" company="APIMatic">
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
    /// IcfsEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IcfsEnum
    {
        /// <summary>
        /// Normal.
        /// </summary>
        [EnumMember(Value = "normal")]
        Normal,

        /// <summary>
        /// Italic.
        /// </summary>
        [EnumMember(Value = "italic")]
        Italic
    }
}