// <copyright file="ImportApiVersionViaUrlRequest.cs" company="APIMatic">
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
    /// ImportApiVersionViaUrlRequest.
    /// </summary>
    public class ImportApiVersionViaUrlRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportApiVersionViaUrlRequest"/> class.
        /// </summary>
        public ImportApiVersionViaUrlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportApiVersionViaUrlRequest"/> class.
        /// </summary>
        /// <param name="versionOverride">version_override.</param>
        /// <param name="url">url.</param>
        public ImportApiVersionViaUrlRequest(
            string versionOverride,
            string url)
        {
            this.VersionOverride = versionOverride;
            this.Url = url;
        }

        /// <summary>
        /// <![CDATA[
        /// The version number with which the new API version will be imported. This version number will override the version specified in the API specification file.<br>APIMatic recommends versioning the API with the [versioning scheme](https://docs.apimatic.io/define-apis/basic-settings/#version) documented in the docs.
        /// ]]>
        /// </summary>
        [JsonProperty("version_override")]
        public string VersionOverride { get; set; }

        /// <summary>
        /// <![CDATA[
        /// The URL for the API specification file.<br><br>**Note:** This URL should be publicly accessible.
        /// ]]>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ImportApiVersionViaUrlRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ImportApiVersionViaUrlRequest other &&                ((this.VersionOverride == null && other.VersionOverride == null) || (this.VersionOverride?.Equals(other.VersionOverride) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VersionOverride = {(this.VersionOverride == null ? "null" : this.VersionOverride)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}