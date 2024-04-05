// <copyright file="ServerConfiguration.cs" company="APIMatic">
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
    /// ServerConfiguration.
    /// </summary>
    public class ServerConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConfiguration"/> class.
        /// </summary>
        public ServerConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConfiguration"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="defaultEnvironment">defaultEnvironment.</param>
        /// <param name="defaultServer">defaultServer.</param>
        /// <param name="environments">environments.</param>
        /// <param name="parameters">parameters.</param>
        public ServerConfiguration(
            string id,
            string defaultEnvironment,
            string defaultServer,
            List<Models.Environment> environments,
            List<Models.Parameter> parameters)
        {
            this.Id = id;
            this.DefaultEnvironment = defaultEnvironment;
            this.DefaultServer = defaultServer;
            this.Environments = environments;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Server Config Identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Default Environment
        /// </summary>
        [JsonProperty("defaultEnvironment")]
        public string DefaultEnvironment { get; set; }

        /// <summary>
        /// Default Server
        /// </summary>
        [JsonProperty("defaultServer")]
        public string DefaultServer { get; set; }

        /// <summary>
        /// Environment Identifier and Name
        /// </summary>
        [JsonProperty("environments")]
        public List<Models.Environment> Environments { get; set; }

        /// <summary>
        /// Parameter Attributes
        /// </summary>
        [JsonProperty("parameters")]
        public List<Models.Parameter> Parameters { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerConfiguration : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerConfiguration other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.DefaultEnvironment == null && other.DefaultEnvironment == null) || (this.DefaultEnvironment?.Equals(other.DefaultEnvironment) == true)) &&
                ((this.DefaultServer == null && other.DefaultServer == null) || (this.DefaultServer?.Equals(other.DefaultServer) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true)) &&
                ((this.Parameters == null && other.Parameters == null) || (this.Parameters?.Equals(other.Parameters) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.DefaultEnvironment = {(this.DefaultEnvironment == null ? "null" : this.DefaultEnvironment)}");
            toStringOutput.Add($"this.DefaultServer = {(this.DefaultServer == null ? "null" : this.DefaultServer)}");
            toStringOutput.Add($"this.Environments = {(this.Environments == null ? "null" : $"[{string.Join(", ", this.Environments)} ]")}");
            toStringOutput.Add($"this.Parameters = {(this.Parameters == null ? "null" : $"[{string.Join(", ", this.Parameters)} ]")}");
        }
    }
}