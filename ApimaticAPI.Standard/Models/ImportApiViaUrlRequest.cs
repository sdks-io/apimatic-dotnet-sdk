// <copyright file="ImportApiViaUrlRequest.cs" company="APIMatic">
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
    /// ImportApiViaUrlRequest.
    /// </summary>
    public class ImportApiViaUrlRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportApiViaUrlRequest"/> class.
        /// </summary>
        public ImportApiViaUrlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportApiViaUrlRequest"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        public ImportApiViaUrlRequest(
            string url)
        {
            this.Url = url;
        }

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

            return $"ImportApiViaUrlRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ImportApiViaUrlRequest other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}