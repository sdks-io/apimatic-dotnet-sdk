// <copyright file="MetaData.cs" company="APIMatic">
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
    /// MetaData.
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaData"/> class.
        /// </summary>
        public MetaData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaData"/> class.
        /// </summary>
        /// <param name="importValidationSummary">importValidationSummary.</param>
        /// <param name="apiValidationSummary">apiValidationSummary.</param>
        /// <param name="docsValidationSummary">docsValidationSummary.</param>
        public MetaData(
            Models.ImportValidationSummary importValidationSummary,
            Models.ApiValidationSummary apiValidationSummary,
            Models.DocsValidationSummary docsValidationSummary)
        {
            this.ImportValidationSummary = importValidationSummary;
            this.ApiValidationSummary = apiValidationSummary;
            this.DocsValidationSummary = docsValidationSummary;
        }

        /// <summary>
        /// Gets or sets ImportValidationSummary.
        /// </summary>
        [JsonProperty("importValidationSummary")]
        public Models.ImportValidationSummary ImportValidationSummary { get; set; }

        /// <summary>
        /// Gets or sets ApiValidationSummary.
        /// </summary>
        [JsonProperty("apiValidationSummary")]
        public Models.ApiValidationSummary ApiValidationSummary { get; set; }

        /// <summary>
        /// Gets or sets DocsValidationSummary.
        /// </summary>
        [JsonProperty("docsValidationSummary")]
        public Models.DocsValidationSummary DocsValidationSummary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MetaData : ({string.Join(", ", toStringOutput)})";
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
            return obj is MetaData other &&                ((this.ImportValidationSummary == null && other.ImportValidationSummary == null) || (this.ImportValidationSummary?.Equals(other.ImportValidationSummary) == true)) &&
                ((this.ApiValidationSummary == null && other.ApiValidationSummary == null) || (this.ApiValidationSummary?.Equals(other.ApiValidationSummary) == true)) &&
                ((this.DocsValidationSummary == null && other.DocsValidationSummary == null) || (this.DocsValidationSummary?.Equals(other.DocsValidationSummary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ImportValidationSummary = {(this.ImportValidationSummary == null ? "null" : this.ImportValidationSummary.ToString())}");
            toStringOutput.Add($"this.ApiValidationSummary = {(this.ApiValidationSummary == null ? "null" : this.ApiValidationSummary.ToString())}");
            toStringOutput.Add($"this.DocsValidationSummary = {(this.DocsValidationSummary == null ? "null" : this.DocsValidationSummary.ToString())}");
        }
    }
}