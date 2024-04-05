// <copyright file="Parameter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ApimaticAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using ApimaticAPI.Standard;
    using ApimaticAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Parameter.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class.
        /// </summary>
        public Parameter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class.
        /// </summary>
        /// <param name="optional">optional.</param>
        /// <param name="type">type.</param>
        /// <param name="constant">constant.</param>
        /// <param name="isArray">isArray.</param>
        /// <param name="isStream">isStream.</param>
        /// <param name="isAttribute">isAttribute.</param>
        /// <param name="isMap">isMap.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="nullable">nullable.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="paramFormat">ParamFormat.</param>
        public Parameter(
            bool optional,
            string type,
            bool constant,
            bool isArray,
            bool isStream,
            bool isAttribute,
            bool isMap,
            Models.Attributes attributes,
            bool nullable,
            string id,
            string name,
            string description,
            string defaultValue,
            string paramFormat)
        {
            this.Optional = optional;
            this.Type = type;
            this.Constant = constant;
            this.IsArray = isArray;
            this.IsStream = isStream;
            this.IsAttribute = isAttribute;
            this.IsMap = isMap;
            this.Attributes = attributes;
            this.Nullable = nullable;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.DefaultValue = defaultValue;
            this.ParamFormat = paramFormat;
        }

        /// <summary>
        /// If parameter is optional
        /// </summary>
        [JsonProperty("optional")]
        public bool Optional { get; set; }

        /// <summary>
        /// Type of Parameter
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// IF Parameter is constant
        /// </summary>
        [JsonProperty("constant")]
        public bool Constant { get; set; }

        /// <summary>
        /// If Param is collected as array
        /// </summary>
        [JsonProperty("isArray")]
        public bool IsArray { get; set; }

        /// <summary>
        /// Gets or sets IsStream.
        /// </summary>
        [JsonProperty("isStream")]
        public bool IsStream { get; set; }

        /// <summary>
        /// Gets or sets IsAttribute.
        /// </summary>
        [JsonProperty("isAttribute")]
        public bool IsAttribute { get; set; }

        /// <summary>
        /// Gets or sets IsMap.
        /// </summary>
        [JsonProperty("isMap")]
        public bool IsMap { get; set; }

        /// <summary>
        /// The structure contain attribute details of a parameter type.
        /// </summary>
        [JsonProperty("attributes")]
        public Models.Attributes Attributes { get; set; }

        /// <summary>
        /// If Parameter is nullable
        /// </summary>
        [JsonProperty("nullable")]
        public bool Nullable { get; set; }

        /// <summary>
        /// Unique Parameter identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Parameter Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Parameter Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Default Values of a Parameter
        /// </summary>
        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Specify Parameter Format
        /// </summary>
        [JsonProperty("ParamFormat")]
        public string ParamFormat { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Parameter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Parameter other &&                this.Optional.Equals(other.Optional) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Constant.Equals(other.Constant) &&
                this.IsArray.Equals(other.IsArray) &&
                this.IsStream.Equals(other.IsStream) &&
                this.IsAttribute.Equals(other.IsAttribute) &&
                this.IsMap.Equals(other.IsMap) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                this.Nullable.Equals(other.Nullable) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.DefaultValue == null && other.DefaultValue == null) || (this.DefaultValue?.Equals(other.DefaultValue) == true)) &&
                ((this.ParamFormat == null && other.ParamFormat == null) || (this.ParamFormat?.Equals(other.ParamFormat) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Optional = {this.Optional}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Constant = {this.Constant}");
            toStringOutput.Add($"this.IsArray = {this.IsArray}");
            toStringOutput.Add($"this.IsStream = {this.IsStream}");
            toStringOutput.Add($"this.IsAttribute = {this.IsAttribute}");
            toStringOutput.Add($"this.IsMap = {this.IsMap}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.Nullable = {this.Nullable}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.DefaultValue = {(this.DefaultValue == null ? "null" : this.DefaultValue)}");
            toStringOutput.Add($"this.ParamFormat = {(this.ParamFormat == null ? "null" : this.ParamFormat)}");
        }
    }
}