// <copyright file="ParamterFormatDetails.cs" company="APIMatic">
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
    /// ParamterFormatDetails.
    /// </summary>
    public class ParamterFormatDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParamterFormatDetails"/> class.
        /// </summary>
        public ParamterFormatDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParamterFormatDetails"/> class.
        /// </summary>
        /// <param name="paramFormat">ParamFormat.</param>
        public ParamterFormatDetails(
            string paramFormat)
        {
            this.ParamFormat = paramFormat;
        }

        /// <summary>
        /// Specify Parameter Format
        /// </summary>
        [JsonProperty("ParamFormat")]
        public string ParamFormat { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ParamterFormatDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is ParamterFormatDetails other &&                ((this.ParamFormat == null && other.ParamFormat == null) || (this.ParamFormat?.Equals(other.ParamFormat) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ParamFormat = {(this.ParamFormat == null ? "null" : this.ParamFormat)}");
        }
    }
}