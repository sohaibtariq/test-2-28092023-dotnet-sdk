// <copyright file="EntityTypeEnum.cs" company="APIMatic">
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
    /// EntityTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityTypeEnum
    {
        /// <summary>
        /// Person.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,

        /// <summary>
        /// Business.
        /// </summary>
        [EnumMember(Value = "business")]
        Business
    }
}