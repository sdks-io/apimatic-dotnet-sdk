// <copyright file="Transformation.cs" company="APIMatic">
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
    /// Transformation.
    /// </summary>
    public class Transformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transformation"/> class.
        /// </summary>
        public Transformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transformation"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="transformedOn">transformedOn.</param>
        /// <param name="userId">userId.</param>
        /// <param name="inputtedFile">inputtedFile.</param>
        /// <param name="generatedFile">generatedFile.</param>
        /// <param name="exportFormat">exportFormat.</param>
        /// <param name="transformationSource">transformationSource.</param>
        /// <param name="transformationInput">transformationInput.</param>
        /// <param name="codeGenVersion">codeGenVersion.</param>
        /// <param name="success">success.</param>
        /// <param name="importSummary">importSummary.</param>
        /// <param name="apiValidationSummary">apiValidationSummary.</param>
        public Transformation(
            string id,
            string transformedOn,
            string userId,
            string inputtedFile,
            string generatedFile,
            string exportFormat,
            string transformationSource,
            string transformationInput,
            string codeGenVersion,
            bool success,
            Models.ApiValidationSummary importSummary,
            Models.ApiValidationSummary apiValidationSummary)
        {
            this.Id = id;
            this.TransformedOn = transformedOn;
            this.UserId = userId;
            this.InputtedFile = inputtedFile;
            this.GeneratedFile = generatedFile;
            this.ExportFormat = exportFormat;
            this.TransformationSource = transformationSource;
            this.TransformationInput = transformationInput;
            this.CodeGenVersion = codeGenVersion;
            this.Success = success;
            this.ImportSummary = importSummary;
            this.ApiValidationSummary = apiValidationSummary;
        }

        /// <summary>
        /// Unique Transformation Identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Transformation Date and Time
        /// </summary>
        [JsonProperty("transformedOn")]
        public string TransformedOn { get; set; }

        /// <summary>
        /// Unique User Identifier
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// API Specification file to be transformed
        /// </summary>
        [JsonProperty("inputtedFile")]
        public string InputtedFile { get; set; }

        /// <summary>
        /// API Specification file transformed to desired format
        /// </summary>
        [JsonProperty("generatedFile")]
        public string GeneratedFile { get; set; }

        /// <summary>
        /// Desired Specification format
        /// </summary>
        [JsonProperty("exportFormat")]
        public string ExportFormat { get; set; }

        /// <summary>
        /// Source of Transformation
        /// </summary>
        [JsonProperty("transformationSource")]
        public string TransformationSource { get; set; }

        /// <summary>
        /// Via File or URL
        /// </summary>
        [JsonProperty("transformationInput")]
        public string TransformationInput { get; set; }

        /// <summary>
        /// CodeGen Engine Version
        /// </summary>
        [JsonProperty("codeGenVersion")]
        public string CodeGenVersion { get; set; }

        /// <summary>
        /// Successful Transformation Flag
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets ImportSummary.
        /// </summary>
        [JsonProperty("importSummary")]
        public Models.ApiValidationSummary ImportSummary { get; set; }

        /// <summary>
        /// Gets or sets ApiValidationSummary.
        /// </summary>
        [JsonProperty("apiValidationSummary")]
        public Models.ApiValidationSummary ApiValidationSummary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Transformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is Transformation other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.TransformedOn == null && other.TransformedOn == null) || (this.TransformedOn?.Equals(other.TransformedOn) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.InputtedFile == null && other.InputtedFile == null) || (this.InputtedFile?.Equals(other.InputtedFile) == true)) &&
                ((this.GeneratedFile == null && other.GeneratedFile == null) || (this.GeneratedFile?.Equals(other.GeneratedFile) == true)) &&
                ((this.ExportFormat == null && other.ExportFormat == null) || (this.ExportFormat?.Equals(other.ExportFormat) == true)) &&
                ((this.TransformationSource == null && other.TransformationSource == null) || (this.TransformationSource?.Equals(other.TransformationSource) == true)) &&
                ((this.TransformationInput == null && other.TransformationInput == null) || (this.TransformationInput?.Equals(other.TransformationInput) == true)) &&
                ((this.CodeGenVersion == null && other.CodeGenVersion == null) || (this.CodeGenVersion?.Equals(other.CodeGenVersion) == true)) &&
                this.Success.Equals(other.Success) &&
                ((this.ImportSummary == null && other.ImportSummary == null) || (this.ImportSummary?.Equals(other.ImportSummary) == true)) &&
                ((this.ApiValidationSummary == null && other.ApiValidationSummary == null) || (this.ApiValidationSummary?.Equals(other.ApiValidationSummary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.TransformedOn = {(this.TransformedOn == null ? "null" : this.TransformedOn)}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.InputtedFile = {(this.InputtedFile == null ? "null" : this.InputtedFile)}");
            toStringOutput.Add($"this.GeneratedFile = {(this.GeneratedFile == null ? "null" : this.GeneratedFile)}");
            toStringOutput.Add($"this.ExportFormat = {(this.ExportFormat == null ? "null" : this.ExportFormat)}");
            toStringOutput.Add($"this.TransformationSource = {(this.TransformationSource == null ? "null" : this.TransformationSource)}");
            toStringOutput.Add($"this.TransformationInput = {(this.TransformationInput == null ? "null" : this.TransformationInput)}");
            toStringOutput.Add($"this.CodeGenVersion = {(this.CodeGenVersion == null ? "null" : this.CodeGenVersion)}");
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.ImportSummary = {(this.ImportSummary == null ? "null" : this.ImportSummary.ToString())}");
            toStringOutput.Add($"this.ApiValidationSummary = {(this.ApiValidationSummary == null ? "null" : this.ApiValidationSummary.ToString())}");
        }
    }
}