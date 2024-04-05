// <copyright file="Authentication.cs" company="APIMatic">
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
    /// Authentication.
    /// </summary>
    public class Authentication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication"/> class.
        /// </summary>
        public Authentication()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="authType">authType.</param>
        /// <param name="scopes">scopes.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="authScopes">authScopes.</param>
        /// <param name="authGrantTypes">authGrantTypes.</param>
        /// <param name="paramFormats">paramFormats.</param>
        public Authentication(
            string id,
            string authType,
            List<Models.AuthScope> scopes,
            List<string> parameters,
            List<string> authScopes,
            List<string> authGrantTypes,
            object paramFormats)
        {
            this.Id = id;
            this.AuthType = authType;
            this.Scopes = scopes;
            this.Parameters = parameters;
            this.AuthScopes = authScopes;
            this.AuthGrantTypes = authGrantTypes;
            this.ParamFormats = paramFormats;
        }

        /// <summary>
        /// Auth Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Auth Type
        /// </summary>
        [JsonProperty("authType")]
        public string AuthType { get; set; }

        /// <summary>
        /// Scope
        /// </summary>
        [JsonProperty("scopes")]
        public List<Models.AuthScope> Scopes { get; set; }

        /// <summary>
        /// Auth Params
        /// </summary>
        [JsonProperty("parameters")]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Auth Scopes
        /// </summary>
        [JsonProperty("authScopes")]
        public List<string> AuthScopes { get; set; }

        /// <summary>
        /// Auth Grant Types
        /// </summary>
        [JsonProperty("authGrantTypes")]
        public List<string> AuthGrantTypes { get; set; }

        /// <summary>
        /// Paramater Formats
        /// </summary>
        [JsonProperty("paramFormats")]
        public object ParamFormats { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Authentication : ({string.Join(", ", toStringOutput)})";
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
            return obj is Authentication other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AuthType == null && other.AuthType == null) || (this.AuthType?.Equals(other.AuthType) == true)) &&
                ((this.Scopes == null && other.Scopes == null) || (this.Scopes?.Equals(other.Scopes) == true)) &&
                ((this.Parameters == null && other.Parameters == null) || (this.Parameters?.Equals(other.Parameters) == true)) &&
                ((this.AuthScopes == null && other.AuthScopes == null) || (this.AuthScopes?.Equals(other.AuthScopes) == true)) &&
                ((this.AuthGrantTypes == null && other.AuthGrantTypes == null) || (this.AuthGrantTypes?.Equals(other.AuthGrantTypes) == true)) &&
                ((this.ParamFormats == null && other.ParamFormats == null) || (this.ParamFormats?.Equals(other.ParamFormats) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.AuthType = {(this.AuthType == null ? "null" : this.AuthType)}");
            toStringOutput.Add($"this.Scopes = {(this.Scopes == null ? "null" : $"[{string.Join(", ", this.Scopes)} ]")}");
            toStringOutput.Add($"this.Parameters = {(this.Parameters == null ? "null" : $"[{string.Join(", ", this.Parameters)} ]")}");
            toStringOutput.Add($"this.AuthScopes = {(this.AuthScopes == null ? "null" : $"[{string.Join(", ", this.AuthScopes)} ]")}");
            toStringOutput.Add($"this.AuthGrantTypes = {(this.AuthGrantTypes == null ? "null" : $"[{string.Join(", ", this.AuthGrantTypes)} ]")}");
            toStringOutput.Add($"ParamFormats = {(this.ParamFormats == null ? "null" : this.ParamFormats.ToString())}");
        }
    }
}