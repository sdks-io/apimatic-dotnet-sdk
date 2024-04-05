// <copyright file="GenerateSdkViaUrlRequest.cs" company="APIMatic">
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
    /// GenerateSdkViaUrlRequest.
    /// </summary>
    public class GenerateSdkViaUrlRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSdkViaUrlRequest"/> class.
        /// </summary>
        public GenerateSdkViaUrlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSdkViaUrlRequest"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="template">template.</param>
        public GenerateSdkViaUrlRequest(
            string url,
            Models.Platforms template)
        {
            this.Url = url;
            this.Template = template;
        }

        /// <summary>
        /// <![CDATA[
        /// The URL for the API specification file.<br><br>**Note:** This URL should be publicly accessible.
        /// ]]>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

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

            return $"GenerateSdkViaUrlRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is GenerateSdkViaUrlRequest other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                this.Template.Equals(other.Template);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Template = {this.Template}");
        }
    }
}