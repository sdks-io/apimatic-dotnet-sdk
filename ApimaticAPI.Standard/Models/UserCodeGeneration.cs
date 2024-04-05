// <copyright file="UserCodeGeneration.cs" company="APIMatic">
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
    /// UserCodeGeneration.
    /// </summary>
    public class UserCodeGeneration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCodeGeneration"/> class.
        /// </summary>
        public UserCodeGeneration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCodeGeneration"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="template">template.</param>
        /// <param name="generatedFile">generatedFile.</param>
        /// <param name="generatedOn">generatedOn.</param>
        /// <param name="hashCode">hashCode.</param>
        /// <param name="codeGenerationSource">codeGenerationSource.</param>
        /// <param name="codeGenVersion">codeGenVersion.</param>
        /// <param name="success">success.</param>
        /// <param name="userId">userId.</param>
        /// <param name="inputFile">inputFile.</param>
        public UserCodeGeneration(
            string id,
            Models.Platforms template,
            string generatedFile,
            DateTime generatedOn,
            string hashCode,
            string codeGenerationSource,
            string codeGenVersion,
            bool success,
            string userId,
            string inputFile)
        {
            this.Id = id;
            this.Template = template;
            this.GeneratedFile = generatedFile;
            this.GeneratedOn = generatedOn;
            this.HashCode = hashCode;
            this.CodeGenerationSource = codeGenerationSource;
            this.CodeGenVersion = codeGenVersion;
            this.Success = success;
            this.UserId = userId;
            this.InputFile = inputFile;
        }

        /// <summary>
        /// Unique Code Generation Identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in.
        /// </summary>
        [JsonProperty("template")]
        public Models.Platforms Template { get; set; }

        /// <summary>
        /// The generated SDK
        /// </summary>
        [JsonProperty("generatedFile")]
        public string GeneratedFile { get; set; }

        /// <summary>
        /// Generation Date and Time
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("generatedOn")]
        public DateTime GeneratedOn { get; set; }

        /// <summary>
        /// The md5 hash of the API Description
        /// </summary>
        [JsonProperty("hashCode")]
        public string HashCode { get; set; }

        /// <summary>
        /// Generation Source
        /// </summary>
        [JsonProperty("codeGenerationSource")]
        public string CodeGenerationSource { get; set; }

        /// <summary>
        /// Generation Version
        /// </summary>
        [JsonProperty("codeGenVersion")]
        public string CodeGenVersion { get; set; }

        /// <summary>
        /// Generation Status
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Unique User Identifier
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// API Specification file in a supported format
        /// </summary>
        [JsonProperty("inputFile")]
        public string InputFile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserCodeGeneration : ({string.Join(", ", toStringOutput)})";
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
            return obj is UserCodeGeneration other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Template.Equals(other.Template) &&
                ((this.GeneratedFile == null && other.GeneratedFile == null) || (this.GeneratedFile?.Equals(other.GeneratedFile) == true)) &&
                this.GeneratedOn.Equals(other.GeneratedOn) &&
                ((this.HashCode == null && other.HashCode == null) || (this.HashCode?.Equals(other.HashCode) == true)) &&
                ((this.CodeGenerationSource == null && other.CodeGenerationSource == null) || (this.CodeGenerationSource?.Equals(other.CodeGenerationSource) == true)) &&
                ((this.CodeGenVersion == null && other.CodeGenVersion == null) || (this.CodeGenVersion?.Equals(other.CodeGenVersion) == true)) &&
                this.Success.Equals(other.Success) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.InputFile == null && other.InputFile == null) || (this.InputFile?.Equals(other.InputFile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Template = {this.Template}");
            toStringOutput.Add($"this.GeneratedFile = {(this.GeneratedFile == null ? "null" : this.GeneratedFile)}");
            toStringOutput.Add($"this.GeneratedOn = {this.GeneratedOn}");
            toStringOutput.Add($"this.HashCode = {(this.HashCode == null ? "null" : this.HashCode)}");
            toStringOutput.Add($"this.CodeGenerationSource = {(this.CodeGenerationSource == null ? "null" : this.CodeGenerationSource)}");
            toStringOutput.Add($"this.CodeGenVersion = {(this.CodeGenVersion == null ? "null" : this.CodeGenVersion)}");
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.InputFile = {(this.InputFile == null ? "null" : this.InputFile)}");
        }
    }
}