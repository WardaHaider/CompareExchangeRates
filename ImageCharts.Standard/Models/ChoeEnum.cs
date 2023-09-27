// <copyright file="ChoeEnum.cs" company="APIMatic">
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
    /// ChoeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChoeEnum
    {
        /// <summary>
        /// UTF8.
        /// </summary>
        [EnumMember(Value = "UTF-8")]
        UTF8
    }
}