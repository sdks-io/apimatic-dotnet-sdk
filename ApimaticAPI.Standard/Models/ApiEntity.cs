// <copyright file="ApiEntity.cs" company="APIMatic">
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
    /// ApiEntity.
    /// </summary>
    public class ApiEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiEntity"/> class.
        /// </summary>
        public ApiEntity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiEntity"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="encryptedId">encryptedId.</param>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="apiGroupId">apiGroupId.</param>
        /// <param name="imageUri">imageUri.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="mPublic">public.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="version">version.</param>
        /// <param name="additionalHeaders">additionalHeaders.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="codeGenSettings">codeGenSettings.</param>
        /// <param name="testGenSettings">testGenSettings.</param>
        /// <param name="errors">errors.</param>
        /// <param name="serverConfiguration">serverConfiguration.</param>
        /// <param name="endpointsGroup">endpointsGroup.</param>
        /// <param name="metaData">metaData.</param>
        public ApiEntity(
            string id,
            string encryptedId,
            string apiKey,
            string apiGroupId,
            string imageUri,
            string creationDate,
            bool mPublic,
            string name,
            string description,
            string version,
            List<string> additionalHeaders,
            Models.Authentication authentication,
            Models.CodeGenSettings codeGenSettings,
            Models.TestGenSettings testGenSettings,
            List<string> errors,
            Models.ServerConfiguration serverConfiguration,
            List<Models.EndpointsGroup> endpointsGroup,
            Models.MetaData metaData)
        {
            this.Id = id;
            this.EncryptedId = encryptedId;
            this.ApiKey = apiKey;
            this.ApiGroupId = apiGroupId;
            this.ImageUri = imageUri;
            this.CreationDate = creationDate;
            this.MPublic = mPublic;
            this.Name = name;
            this.Description = description;
            this.Version = version;
            this.AdditionalHeaders = additionalHeaders;
            this.Authentication = authentication;
            this.CodeGenSettings = codeGenSettings;
            this.TestGenSettings = testGenSettings;
            this.Errors = errors;
            this.ServerConfiguration = serverConfiguration;
            this.EndpointsGroup = endpointsGroup;
            this.MetaData = metaData;
        }

        /// <summary>
        /// Unique API Entity identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Enrcypted API Entity Id
        /// </summary>
        [JsonProperty("encryptedId")]
        public string EncryptedId { get; set; }

        /// <summary>
        /// API Integration Key. Obtain from API Card on Dashboard.
        /// </summary>
        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Unique API Group Identifier
        /// </summary>
        [JsonProperty("apiGroupId")]
        public string ApiGroupId { get; set; }

        /// <summary>
        /// Cover Image
        /// </summary>
        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        /// <summary>
        /// Entity creation date
        /// </summary>
        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        /// <summary>
        /// API Status (Deprecated)
        /// </summary>
        [JsonProperty("public")]
        public bool MPublic { get; set; }

        /// <summary>
        /// API Entity  Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the API
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Entity Version Number
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Header Content
        /// </summary>
        [JsonProperty("additionalHeaders")]
        public List<string> AdditionalHeaders { get; set; }

        /// <summary>
        /// This Structure encapsulates all details of API authentication.
        /// </summary>
        [JsonProperty("authentication")]
        public Models.Authentication Authentication { get; set; }

        /// <summary>
        /// APIMatic’s code generation engine has various code generation configurations to customise the behaviour and outlook across the generated SDKS. This structure encapsulates all settings for CodeGeneration.
        /// </summary>
        [JsonProperty("codeGenSettings")]
        public Models.CodeGenSettings CodeGenSettings { get; set; }

        /// <summary>
        /// This structure helps specify additional test configurations which affects how test cases are generated.
        /// </summary>
        [JsonProperty("testGenSettings")]
        public Models.TestGenSettings TestGenSettings { get; set; }

        /// <summary>
        /// API Errors
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Server configurations can be used to create multiple environments, multiple servers that can be used with specific endpoints and server URLs with template paramters.
        /// </summary>
        [JsonProperty("serverConfiguration")]
        public Models.ServerConfiguration ServerConfiguration { get; set; }

        /// <summary>
        /// API Endpoint Groups
        /// </summary>
        [JsonProperty("endpointsGroup")]
        public List<Models.EndpointsGroup> EndpointsGroup { get; set; }

        /// <summary>
        /// Gets or sets MetaData.
        /// </summary>
        [JsonProperty("metaData")]
        public Models.MetaData MetaData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApiEntity : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApiEntity other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.EncryptedId == null && other.EncryptedId == null) || (this.EncryptedId?.Equals(other.EncryptedId) == true)) &&
                ((this.ApiKey == null && other.ApiKey == null) || (this.ApiKey?.Equals(other.ApiKey) == true)) &&
                ((this.ApiGroupId == null && other.ApiGroupId == null) || (this.ApiGroupId?.Equals(other.ApiGroupId) == true)) &&
                ((this.ImageUri == null && other.ImageUri == null) || (this.ImageUri?.Equals(other.ImageUri) == true)) &&
                ((this.CreationDate == null && other.CreationDate == null) || (this.CreationDate?.Equals(other.CreationDate) == true)) &&
                this.MPublic.Equals(other.MPublic) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.AdditionalHeaders == null && other.AdditionalHeaders == null) || (this.AdditionalHeaders?.Equals(other.AdditionalHeaders) == true)) &&
                ((this.Authentication == null && other.Authentication == null) || (this.Authentication?.Equals(other.Authentication) == true)) &&
                ((this.CodeGenSettings == null && other.CodeGenSettings == null) || (this.CodeGenSettings?.Equals(other.CodeGenSettings) == true)) &&
                ((this.TestGenSettings == null && other.TestGenSettings == null) || (this.TestGenSettings?.Equals(other.TestGenSettings) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true)) &&
                ((this.ServerConfiguration == null && other.ServerConfiguration == null) || (this.ServerConfiguration?.Equals(other.ServerConfiguration) == true)) &&
                ((this.EndpointsGroup == null && other.EndpointsGroup == null) || (this.EndpointsGroup?.Equals(other.EndpointsGroup) == true)) &&
                ((this.MetaData == null && other.MetaData == null) || (this.MetaData?.Equals(other.MetaData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.EncryptedId = {(this.EncryptedId == null ? "null" : this.EncryptedId)}");
            toStringOutput.Add($"this.ApiKey = {(this.ApiKey == null ? "null" : this.ApiKey)}");
            toStringOutput.Add($"this.ApiGroupId = {(this.ApiGroupId == null ? "null" : this.ApiGroupId)}");
            toStringOutput.Add($"this.ImageUri = {(this.ImageUri == null ? "null" : this.ImageUri)}");
            toStringOutput.Add($"this.CreationDate = {(this.CreationDate == null ? "null" : this.CreationDate)}");
            toStringOutput.Add($"this.MPublic = {this.MPublic}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.AdditionalHeaders = {(this.AdditionalHeaders == null ? "null" : $"[{string.Join(", ", this.AdditionalHeaders)} ]")}");
            toStringOutput.Add($"this.Authentication = {(this.Authentication == null ? "null" : this.Authentication.ToString())}");
            toStringOutput.Add($"this.CodeGenSettings = {(this.CodeGenSettings == null ? "null" : this.CodeGenSettings.ToString())}");
            toStringOutput.Add($"this.TestGenSettings = {(this.TestGenSettings == null ? "null" : this.TestGenSettings.ToString())}");
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
            toStringOutput.Add($"this.ServerConfiguration = {(this.ServerConfiguration == null ? "null" : this.ServerConfiguration.ToString())}");
            toStringOutput.Add($"this.EndpointsGroup = {(this.EndpointsGroup == null ? "null" : $"[{string.Join(", ", this.EndpointsGroup)} ]")}");
            toStringOutput.Add($"this.MetaData = {(this.MetaData == null ? "null" : this.MetaData.ToString())}");
        }
    }
}