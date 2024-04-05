// <copyright file="UserCodeGenerationRequirements.cs" company="APIMatic">
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
    /// UserCodeGenerationRequirements.
    /// </summary>
    public class UserCodeGenerationRequirements
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCodeGenerationRequirements"/> class.
        /// </summary>
        public UserCodeGenerationRequirements()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCodeGenerationRequirements"/> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="inputFile">inputFile.</param>
        public UserCodeGenerationRequirements(
            string userId,
            string inputFile)
        {
            this.UserId = userId;
            this.InputFile = inputFile;
        }

        /// <summary>
        /// Unique User Identifier
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// API Specification file in a supported format
        /// </summary>
        [JsonProperty("inputFile")]
        public string InputFile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserCodeGenerationRequirements : ({string.Join(", ", toStringOutput)})";
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
            return obj is UserCodeGenerationRequirements other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.InputFile == null && other.InputFile == null) || (this.InputFile?.Equals(other.InputFile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.InputFile = {(this.InputFile == null ? "null" : this.InputFile)}");
        }
    }
}