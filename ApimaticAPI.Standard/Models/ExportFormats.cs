// <copyright file="ExportFormats.cs" company="APIMatic">
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
    /// ExportFormats.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportFormats
    {
        /// <summary>
        /// APIMATIC.
        /// </summary>
        [EnumMember(Value = "APIMATIC")]
        APIMATIC,

        /// <summary>
        /// WADL2009.
        /// </summary>
        [EnumMember(Value = "WADL2009")]
        WADL2009,

        /// <summary>
        /// WSDL.
        /// </summary>
        [EnumMember(Value = "WSDL")]
        WSDL,

        /// <summary>
        /// SWAGGER10.
        /// </summary>
        [EnumMember(Value = "Swagger10")]
        SWAGGER10,

        /// <summary>
        /// SWAGGER20.
        /// </summary>
        [EnumMember(Value = "Swagger20")]
        SWAGGER20,

        /// <summary>
        /// SWAGGERYAML.
        /// </summary>
        [EnumMember(Value = "SwaggerYaml")]
        SWAGGERYAML,

        /// <summary>
        ///OpenAPI v3.0 (JSON)
        /// OAS3.
        /// </summary>
        [EnumMember(Value = "OpenApi3Json")]
        OAS3,

        /// <summary>
        /// OPENAPI3YAML.
        /// </summary>
        [EnumMember(Value = "OpenApi3Yaml")]
        OPENAPI3YAML,

        /// <summary>
        /// APIBLUEPRINT.
        /// </summary>
        [EnumMember(Value = "APIBluePrint")]
        APIBLUEPRINT,

        /// <summary>
        /// RAML.
        /// </summary>
        [EnumMember(Value = "RAML")]
        RAML,

        /// <summary>
        /// RAML10.
        /// </summary>
        [EnumMember(Value = "RAML10")]
        RAML10,

        /// <summary>
        /// POSTMAN10.
        /// </summary>
        [EnumMember(Value = "Postman10")]
        POSTMAN10,

        /// <summary>
        /// POSTMAN20.
        /// </summary>
        [EnumMember(Value = "Postman20")]
        POSTMAN20,

        /// <summary>
        /// GRAPHQLSCHEMA.
        /// </summary>
        [EnumMember(Value = "GraphQlSchema")]
        GRAPHQLSCHEMA
    }
}