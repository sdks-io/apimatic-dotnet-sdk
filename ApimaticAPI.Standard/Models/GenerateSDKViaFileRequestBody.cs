// <copyright file="GenerateSDKViaFileRequestBody.cs" company="APIMatic">
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
    /// GenerateSDKViaFileRequestBody.
    /// </summary>
    public class GenerateSDKViaFileRequestBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSDKViaFileRequestBody"/> class.
        /// </summary>
        public GenerateSDKViaFileRequestBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSDKViaFileRequestBody"/> class.
        /// </summary>
        /// <param name="file">file.</param>
        /// <param name="template">template.</param>
        public GenerateSDKViaFileRequestBody(
            Stream file,
            Models.Platforms template)
        {
            this.File = file;
            this.Template = template;
        }

        /// <summary>
        /// <![CDATA[
        /// The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats).
        /// ]]>
        /// </summary>
        [JsonProperty("file")]
        public Stream File { get; set; }

        /// <summary>
        /// The structure contains platforms that APIMatic CodeGen can generate SDKs and Docs in.
        /// </summary>
        [JsonProperty("template")]
        public Models.Platforms Template { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GenerateSDKViaFileRequestBody : ({string.Join(", ", toStringOutput)})";
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
            return obj is GenerateSDKViaFileRequestBody other &&                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true)) &&
                this.Template.Equals(other.Template);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File.ToString())}");
            toStringOutput.Add($"this.Template = {this.Template}");
        }
    }
}