// <copyright file="IcretinaEnum.cs" company="APIMatic">
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
    /// IcretinaEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IcretinaEnum
    {
        /// <summary>
        /// Enum0.
        /// </summary>
        [EnumMember(Value = "0")]
        Enum0,

        /// <summary>
        /// Enum1.
        /// </summary>
        [EnumMember(Value = "1")]
        Enum1
    }
}