// <copyright file="ApiValidationSummary.cs" company="APIMatic">
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
    /// ApiValidationSummary.
    /// </summary>
    public class ApiValidationSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiValidationSummary"/> class.
        /// </summary>
        public ApiValidationSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiValidationSummary"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="errors">errors.</param>
        /// <param name="warnings">warnings.</param>
        /// <param name="messages">messages.</param>
        public ApiValidationSummary(
            bool success,
            List<string> errors,
            List<string> warnings,
            List<string> messages)
        {
            this.Success = success;
            this.Errors = errors;
            this.Warnings = warnings;
            this.Messages = messages;
        }

        /// <summary>
        /// Gets or sets Success.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or sets Warnings.
        /// </summary>
        [JsonProperty("warnings")]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Gets or sets Messages.
        /// </summary>
        [JsonProperty("messages")]
        public List<string> Messages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApiValidationSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApiValidationSummary other &&                this.Success.Equals(other.Success) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true)) &&
                ((this.Warnings == null && other.Warnings == null) || (this.Warnings?.Equals(other.Warnings) == true)) &&
                ((this.Messages == null && other.Messages == null) || (this.Messages?.Equals(other.Messages) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
            toStringOutput.Add($"this.Warnings = {(this.Warnings == null ? "null" : $"[{string.Join(", ", this.Warnings)} ]")}");
            toStringOutput.Add($"this.Messages = {(this.Messages == null ? "null" : $"[{string.Join(", ", this.Messages)} ]")}");
        }
    }
}