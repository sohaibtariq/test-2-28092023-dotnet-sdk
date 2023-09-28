// <copyright file="PolicyStateEnum.cs" company="APIMatic">
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
    /// PolicyStateEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PolicyStateEnum
    {
        /// <summary>
        /// AL.
        /// </summary>
        [EnumMember(Value = "AL")]
        AL,

        /// <summary>
        /// AK.
        /// </summary>
        [EnumMember(Value = "AK")]
        AK,

        /// <summary>
        /// AZ.
        /// </summary>
        [EnumMember(Value = "AZ")]
        AZ,

        /// <summary>
        /// AR.
        /// </summary>
        [EnumMember(Value = "AR")]
        AR,

        /// <summary>
        /// CA.
        /// </summary>
        [EnumMember(Value = "CA")]
        CA,

        /// <summary>
        /// CO.
        /// </summary>
        [EnumMember(Value = "CO")]
        CO,

        /// <summary>
        /// CT.
        /// </summary>
        [EnumMember(Value = "CT")]
        CT,

        /// <summary>
        /// DC.
        /// </summary>
        [EnumMember(Value = "DC")]
        DC,

        /// <summary>
        /// DE.
        /// </summary>
        [EnumMember(Value = "DE")]
        DE,

        /// <summary>
        /// FL.
        /// </summary>
        [EnumMember(Value = "FL")]
        FL,

        /// <summary>
        /// GA.
        /// </summary>
        [EnumMember(Value = "GA")]
        GA,

        /// <summary>
        /// HI.
        /// </summary>
        [EnumMember(Value = "HI")]
        HI,

        /// <summary>
        /// ID.
        /// </summary>
        [EnumMember(Value = "ID")]
        ID,

        /// <summary>
        /// IL.
        /// </summary>
        [EnumMember(Value = "IL")]
        IL,

        /// <summary>
        /// IN.
        /// </summary>
        [EnumMember(Value = "IN")]
        IN,

        /// <summary>
        /// IA.
        /// </summary>
        [EnumMember(Value = "IA")]
        IA,

        /// <summary>
        /// KS.
        /// </summary>
        [EnumMember(Value = "KS")]
        KS,

        /// <summary>
        /// KY.
        /// </summary>
        [EnumMember(Value = "KY")]
        KY,

        /// <summary>
        /// LA.
        /// </summary>
        [EnumMember(Value = "LA")]
        LA,

        /// <summary>
        /// ME.
        /// </summary>
        [EnumMember(Value = "ME")]
        ME,

        /// <summary>
        /// MD.
        /// </summary>
        [EnumMember(Value = "MD")]
        MD,

        /// <summary>
        /// MA.
        /// </summary>
        [EnumMember(Value = "MA")]
        MA,

        /// <summary>
        /// MI.
        /// </summary>
        [EnumMember(Value = "MI")]
        MI,

        /// <summary>
        /// MN.
        /// </summary>
        [EnumMember(Value = "MN")]
        MN,

        /// <summary>
        /// MS.
        /// </summary>
        [EnumMember(Value = "MS")]
        MS,

        /// <summary>
        /// MO.
        /// </summary>
        [EnumMember(Value = "MO")]
        MO,

        /// <summary>
        /// MT.
        /// </summary>
        [EnumMember(Value = "MT")]
        MT,

        /// <summary>
        /// NE.
        /// </summary>
        [EnumMember(Value = "NE")]
        NE,

        /// <summary>
        /// NV.
        /// </summary>
        [EnumMember(Value = "NV")]
        NV,

        /// <summary>
        /// NH.
        /// </summary>
        [EnumMember(Value = "NH")]
        NH,

        /// <summary>
        /// NJ.
        /// </summary>
        [EnumMember(Value = "NJ")]
        NJ,

        /// <summary>
        /// NM.
        /// </summary>
        [EnumMember(Value = "NM")]
        NM,

        /// <summary>
        /// NY.
        /// </summary>
        [EnumMember(Value = "NY")]
        NY,

        /// <summary>
        /// NC.
        /// </summary>
        [EnumMember(Value = "NC")]
        NC,

        /// <summary>
        /// ND.
        /// </summary>
        [EnumMember(Value = "ND")]
        ND,

        /// <summary>
        /// OH.
        /// </summary>
        [EnumMember(Value = "OH")]
        OH,

        /// <summary>
        /// OK.
        /// </summary>
        [EnumMember(Value = "OK")]
        OK,

        /// <summary>
        /// OR.
        /// </summary>
        [EnumMember(Value = "OR")]
        OR,

        /// <summary>
        /// PA.
        /// </summary>
        [EnumMember(Value = "PA")]
        PA,

        /// <summary>
        /// RI.
        /// </summary>
        [EnumMember(Value = "RI")]
        RI,

        /// <summary>
        /// SC.
        /// </summary>
        [EnumMember(Value = "SC")]
        SC,

        /// <summary>
        /// SD.
        /// </summary>
        [EnumMember(Value = "SD")]
        SD,

        /// <summary>
        /// TN.
        /// </summary>
        [EnumMember(Value = "TN")]
        TN,

        /// <summary>
        /// TX.
        /// </summary>
        [EnumMember(Value = "TX")]
        TX,

        /// <summary>
        /// UT.
        /// </summary>
        [EnumMember(Value = "UT")]
        UT,

        /// <summary>
        /// VT.
        /// </summary>
        [EnumMember(Value = "VT")]
        VT,

        /// <summary>
        /// VA.
        /// </summary>
        [EnumMember(Value = "VA")]
        VA,

        /// <summary>
        /// WA.
        /// </summary>
        [EnumMember(Value = "WA")]
        WA,

        /// <summary>
        /// WV.
        /// </summary>
        [EnumMember(Value = "WV")]
        WV,

        /// <summary>
        /// WI.
        /// </summary>
        [EnumMember(Value = "WI")]
        WI,

        /// <summary>
        /// WY.
        /// </summary>
        [EnumMember(Value = "WY")]
        WY
    }
}