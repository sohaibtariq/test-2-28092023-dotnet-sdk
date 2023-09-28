// <copyright file="ExpiresInEnum.cs" company="APIMatic">
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
    /// ExpiresInEnum.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum ExpiresInEnum
    {
        /// <summary>
        /// Enum7200.
        /// </summary>
        Enum7200 = 7200
    }
}