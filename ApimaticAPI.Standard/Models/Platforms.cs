// <copyright file="Platforms.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ApimaticAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using ApimaticAPI.Standard;
    using ApimaticAPI.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// Platforms.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Platforms
    {
        /// <summary>
        ///.NET Standard Library
        /// CSNETSTANDARDLIB.
        /// </summary>
        [EnumMember(Value = "CS_NET_STANDARD_LIB")]
        CSNETSTANDARDLIB,

        /// <summary>
        ///JAVA
        /// JAVAECLIPSEJRELIB.
        /// </summary>
        [EnumMember(Value = "JAVA_ECLIPSE_JRE_LIB")]
        JAVAECLIPSEJRELIB,

        /// <summary>
        ///PHP
        /// PHPGENERICLIBV2.
        /// </summary>
        [EnumMember(Value = "PHP_GENERIC_LIB")]
        PHPGENERICLIBV2,

        /// <summary>
        ///Python
        /// PYTHONGENERICLIB.
        /// </summary>
        [EnumMember(Value = "PYTHON_GENERIC_LIB")]
        PYTHONGENERICLIB,

        /// <summary>
        ///Ruby
        /// RUBYGENERICLIB.
        /// </summary>
        [EnumMember(Value = "RUBY_GENERIC_LIB")]
        RUBYGENERICLIB,

        /// <summary>
        ///Typescript
        /// TSGENERICLIB.
        /// </summary>
        [EnumMember(Value = "TS_GENERIC_LIB")]
        TSGENERICLIB,

        /// <summary>
        ///Go
        /// GOGENERICLIB.
        /// </summary>
        [EnumMember(Value = "GO_GENERIC_LIB")]
        GOGENERICLIB
    }
}