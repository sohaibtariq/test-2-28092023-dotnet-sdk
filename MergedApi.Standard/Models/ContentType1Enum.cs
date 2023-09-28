// <copyright file="ContentType1Enum.cs" company="APIMatic">
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
    /// ContentType1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentType1Enum
    {
        /// <summary>
        /// EnumApplicationvndapijson.
        /// </summary>
        [EnumMember(Value = "application/vnd.api+json")]
        EnumApplicationvndapijson
    }
}