// <copyright file="Status2Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MergedApi.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using MergedApi.Standard;
    using MergedApi.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// Status2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status2Enum
    {
        /// <summary>
        /// Draft.
        /// </summary>
        [EnumMember(Value = "draft")]
        Draft,

        /// <summary>
        /// Bindable.
        /// </summary>
        [EnumMember(Value = "bindable")]
        Bindable,

        /// <summary>
        /// Convertable.
        /// </summary>
        [EnumMember(Value = "convertable")]
        Convertable,

        /// <summary>
        /// Converted.
        /// </summary>
        [EnumMember(Value = "converted")]
        Converted,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired
    }
}