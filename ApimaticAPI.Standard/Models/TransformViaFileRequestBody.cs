// <copyright file="TransformViaFileRequestBody.cs" company="APIMatic">
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
    /// TransformViaFileRequestBody.
    /// </summary>
    public class TransformViaFileRequestBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransformViaFileRequestBody"/> class.
        /// </summary>
        public TransformViaFileRequestBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformViaFileRequestBody"/> class.
        /// </summary>
        /// <param name="file">file.</param>
        /// <param name="exportFormat">export_format.</param>
        public TransformViaFileRequestBody(
            Stream file,
            Models.ExportFormats exportFormat)
        {
            this.File = file;
            this.ExportFormat = exportFormat;
        }

        /// <summary>
        /// <![CDATA[
        /// The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats).
        /// ]]>
        /// </summary>
        [JsonProperty("file")]
        public Stream File { get; set; }

        /// <summary>
        /// The structure contains API specification formats that Transformer can convert to.
        /// </summary>
        [JsonProperty("export_format")]
        public Models.ExportFormats ExportFormat { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransformViaFileRequestBody : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransformViaFileRequestBody other &&                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true)) &&
                this.ExportFormat.Equals(other.ExportFormat);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File.ToString())}");
            toStringOutput.Add($"this.ExportFormat = {this.ExportFormat}");
        }
    }
}