// <copyright file="GrantTypeEnum.cs" company="APIMatic">
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
    /// GrantTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GrantTypeEnum
    {
        /// <summary>
        /// ClientCredentials.
        /// </summary>
        [EnumMember(Value = "client_credentials")]
        ClientCredentials
    }
}