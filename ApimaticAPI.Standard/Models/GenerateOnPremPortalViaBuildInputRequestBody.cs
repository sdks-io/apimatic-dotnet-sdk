// <copyright file="GenerateOnPremPortalViaBuildInputRequestBody.cs" company="APIMatic">
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
    /// GenerateOnPremPortalViaBuildInputRequestBody.
    /// </summary>
    public class GenerateOnPremPortalViaBuildInputRequestBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateOnPremPortalViaBuildInputRequestBody"/> class.
        /// </summary>
        public GenerateOnPremPortalViaBuildInputRequestBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateOnPremPortalViaBuildInputRequestBody"/> class.
        /// </summary>
        /// <param name="file">file.</param>
        public GenerateOnPremPortalViaBuildInputRequestBody(
            Stream file)
        {
            this.File = file;
        }

        /// <summary>
        /// The input file to the Portal Generator. Must contain the build file.
        /// </summary>
        [JsonProperty("file")]
        public Stream File { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GenerateOnPremPortalViaBuildInputRequestBody : ({string.Join(", ", toStringOutput)})";
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
            return obj is GenerateOnPremPortalViaBuildInputRequestBody other &&                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File.ToString())}");
        }
    }
}