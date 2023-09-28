// <copyright file="StatusEnum.cs" company="APIMatic">
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
    /// StatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Issued.
        /// </summary>
        [EnumMember(Value = "issued")]
        Issued,

        /// <summary>
        /// Inforce.
        /// </summary>
        [EnumMember(Value = "in-force")]
        Inforce,

        /// <summary>
        /// Reinstated.
        /// </summary>
        [EnumMember(Value = "reinstated")]
        Reinstated,

        /// <summary>
        /// Renewed.
        /// </summary>
        [EnumMember(Value = "renewed")]
        Renewed,

        /// <summary>
        /// Cancelpending.
        /// </summary>
        [EnumMember(Value = "cancel-pending")]
        Cancelpending,

        /// <summary>
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// Void.
        /// </summary>
        [EnumMember(Value = "void")]
        Void
    }
}