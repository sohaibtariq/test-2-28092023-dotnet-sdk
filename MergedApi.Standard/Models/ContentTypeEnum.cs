// <copyright file="ContentTypeEnum.cs" company="APIMatic">
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
    /// ContentTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentTypeEnum
    {
        /// <summary>
        /// EnumApplicationxwwwformurlencoded.
        /// </summary>
        [EnumMember(Value = "application/x-www-form-urlencoded")]
        EnumApplicationxwwwformurlencoded
    }
}