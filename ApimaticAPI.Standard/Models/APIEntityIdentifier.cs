// <copyright file="APIEntityIdentifier.cs" company="APIMatic">
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
    /// APIEntityIdentifier.
    /// </summary>
    public class APIEntityIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIEntityIdentifier"/> class.
        /// </summary>
        public APIEntityIdentifier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIEntityIdentifier"/> class.
        /// </summary>
        /// <param name="apiEntityId">apiEntityId.</param>
        public APIEntityIdentifier(
            string apiEntityId)
        {
            this.ApiEntityId = apiEntityId;
        }

        /// <summary>
        /// Unique API Entity Identifier
        /// </summary>
        [JsonProperty("apiEntityId")]
        public string ApiEntityId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"APIEntityIdentifier : ({string.Join(", ", toStringOutput)})";
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
            return obj is APIEntityIdentifier other &&                ((this.ApiEntityId == null && other.ApiEntityId == null) || (this.ApiEntityId?.Equals(other.ApiEntityId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApiEntityId = {(this.ApiEntityId == null ? "null" : this.ApiEntityId)}");
        }
    }
}