// <copyright file="ImportNewAPIVersionViaFileRequestBody.cs" company="APIMatic">
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
    /// ImportNewAPIVersionViaFileRequestBody.
    /// </summary>
    public class ImportNewAPIVersionViaFileRequestBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportNewAPIVersionViaFileRequestBody"/> class.
        /// </summary>
        public ImportNewAPIVersionViaFileRequestBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportNewAPIVersionViaFileRequestBody"/> class.
        /// </summary>
        /// <param name="versionOverride">version_override.</param>
        /// <param name="file">file.</param>
        public ImportNewAPIVersionViaFileRequestBody(
            string versionOverride,
            Stream file)
        {
            this.VersionOverride = versionOverride;
            this.File = file;
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
        /// The API specification file.<br>The type of the specification file should be any of the [supported formats](https://docs.apimatic.io/api-transformer/overview-transformer#supported-input-formats).
        /// ]]>
        /// </summary>
        [JsonProperty("file")]
        public Stream File { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ImportNewAPIVersionViaFileRequestBody : ({string.Join(", ", toStringOutput)})";
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
            return obj is ImportNewAPIVersionViaFileRequestBody other &&                ((this.VersionOverride == null && other.VersionOverride == null) || (this.VersionOverride?.Equals(other.VersionOverride) == true)) &&
                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VersionOverride = {(this.VersionOverride == null ? "null" : this.VersionOverride)}");
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File.ToString())}");
        }
    }
}