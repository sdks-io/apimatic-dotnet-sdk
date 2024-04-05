// <copyright file="PlatformsTemplate.cs" company="APIMatic">
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
    /// PlatformsTemplate.
    /// </summary>
    public class PlatformsTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformsTemplate"/> class.
        /// </summary>
        public PlatformsTemplate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformsTemplate"/> class.
        /// </summary>
        /// <param name="template">template.</param>
        public PlatformsTemplate(
            Models.Platforms template)
        {
            this.Template = template;
        }

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

            return $"PlatformsTemplate : ({string.Join(", ", toStringOutput)})";
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
            return obj is PlatformsTemplate other &&                this.Template.Equals(other.Template);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Template = {this.Template}");
        }
    }
}