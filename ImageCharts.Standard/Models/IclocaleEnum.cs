// <copyright file="IclocaleEnum.cs" company="APIMatic">
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
    /// IclocaleEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IclocaleEnum
    {
        /// <summary>
        /// Fr.
        /// </summary>
        [EnumMember(Value = "fr")]
        Fr,

        /// <summary>
        /// De.
        /// </summary>
        [EnumMember(Value = "de")]
        De,

        /// <summary>
        /// En.
        /// </summary>
        [EnumMember(Value = "en")]
        En
    }
}