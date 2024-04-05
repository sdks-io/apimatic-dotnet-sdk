// <copyright file="TransformViaUrlRequest.cs" company="APIMatic">
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
    /// TransformViaUrlRequest.
    /// </summary>
    public class TransformViaUrlRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransformViaUrlRequest"/> class.
        /// </summary>
        public TransformViaUrlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformViaUrlRequest"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="exportFormat">export_format.</param>
        public TransformViaUrlRequest(
            string url,
            Models.ExportFormats exportFormat)
        {
            this.Url = url;
            this.ExportFormat = exportFormat;
        }

        /// <summary>
        /// <![CDATA[
        /// The URL for the API specification file.<br><br>**Note:** This URL should be publicly accessible.
        /// ]]>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

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

            return $"TransformViaUrlRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransformViaUrlRequest other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                this.ExportFormat.Equals(other.ExportFormat);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.ExportFormat = {this.ExportFormat}");
        }
    }
}