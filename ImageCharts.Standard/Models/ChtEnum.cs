// <copyright file="ChtEnum.cs" company="APIMatic">
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
    /// ChtEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChtEnum
    {
        /// <summary>
        /// Bvs.
        /// </summary>
        [EnumMember(Value = "bvs")]
        Bvs,

        /// <summary>
        /// Bvg.
        /// </summary>
        [EnumMember(Value = "bvg")]
        Bvg,

        /// <summary>
        /// Bhs.
        /// </summary>
        [EnumMember(Value = "bhs")]
        Bhs,

        /// <summary>
        /// Bhg.
        /// </summary>
        [EnumMember(Value = "bhg")]
        Bhg,

        /// <summary>
        /// Bvo.
        /// </summary>
        [EnumMember(Value = "bvo")]
        Bvo,

        /// <summary>
        /// P.
        /// </summary>
        [EnumMember(Value = "p")]
        P,

        /// <summary>
        /// P3.
        /// </summary>
        [EnumMember(Value = "p3")]
        P3,

        /// <summary>
        /// Pc.
        /// </summary>
        [EnumMember(Value = "pc")]
        Pc,

        /// <summary>
        /// Pd.
        /// </summary>
        [EnumMember(Value = "pd")]
        Pd,

        /// <summary>
        /// Ls.
        /// </summary>
        [EnumMember(Value = "ls")]
        Ls,

        /// <summary>
        /// Lc.
        /// </summary>
        [EnumMember(Value = "lc")]
        Lc,

        /// <summary>
        /// Lxy.
        /// </summary>
        [EnumMember(Value = "lxy")]
        Lxy,

        /// <summary>
        /// EnumLsnda.
        /// </summary>
        [EnumMember(Value = "ls:nda")]
        EnumLsnda,

        /// <summary>
        /// EnumLcnda.
        /// </summary>
        [EnumMember(Value = "lc:nda")]
        EnumLcnda,

        /// <summary>
        /// EnumLxynda.
        /// </summary>
        [EnumMember(Value = "lxy:nda")]
        EnumLxynda,

        /// <summary>
        /// Pa.
        /// </summary>
        [EnumMember(Value = "pa")]
        Pa,

        /// <summary>
        /// Bb.
        /// </summary>
        [EnumMember(Value = "bb")]
        Bb,

        /// <summary>
        /// Gv.
        /// </summary>
        [EnumMember(Value = "gv")]
        Gv,

        /// <summary>
        /// EnumGvdot.
        /// </summary>
        [EnumMember(Value = "gv:dot")]
        EnumGvdot,

        /// <summary>
        /// EnumGvneato.
        /// </summary>
        [EnumMember(Value = "gv:neato")]
        EnumGvneato,

        /// <summary>
        /// EnumGvcirco.
        /// </summary>
        [EnumMember(Value = "gv:circo")]
        EnumGvcirco,

        /// <summary>
        /// EnumGvfdp.
        /// </summary>
        [EnumMember(Value = "gv:fdp")]
        EnumGvfdp,

        /// <summary>
        /// EnumGvosage.
        /// </summary>
        [EnumMember(Value = "gv:osage")]
        EnumGvosage,

        /// <summary>
        /// EnumGvtwopi.
        /// </summary>
        [EnumMember(Value = "gv:twopi")]
        EnumGvtwopi,

        /// <summary>
        /// Qr.
        /// </summary>
        [EnumMember(Value = "qr")]
        Qr,

        /// <summary>
        /// R.
        /// </summary>
        [EnumMember(Value = "r")]
        R
    }
}