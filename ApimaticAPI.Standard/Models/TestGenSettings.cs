// <copyright file="TestGenSettings.cs" company="APIMatic">
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
    /// TestGenSettings.
    /// </summary>
    public class TestGenSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestGenSettings"/> class.
        /// </summary>
        public TestGenSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestGenSettings"/> class.
        /// </summary>
        /// <param name="precisionDelta">precisionDelta.</param>
        /// <param name="testTimeout">testTimeout.</param>
        /// <param name="configuration">configuration.</param>
        public TestGenSettings(
            double precisionDelta,
            int testTimeout,
            object configuration)
        {
            this.PrecisionDelta = precisionDelta;
            this.TestTimeout = testTimeout;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Error margin for comparing values in decimal places
        /// </summary>
        [JsonProperty("precisionDelta")]
        public double PrecisionDelta { get; set; }

        /// <summary>
        /// Number of seconds after which if the endpoint is not returning any response, the test is forced to fail e.g. a timeout of 60
        /// </summary>
        [JsonProperty("testTimeout")]
        public int TestTimeout { get; set; }

        /// <summary>
        /// The parameters allows to provide values for configuration file for use in the test environment
        /// </summary>
        [JsonProperty("configuration")]
        public object Configuration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TestGenSettings : ({string.Join(", ", toStringOutput)})";
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
            return obj is TestGenSettings other &&                this.PrecisionDelta.Equals(other.PrecisionDelta) &&
                this.TestTimeout.Equals(other.TestTimeout) &&
                ((this.Configuration == null && other.Configuration == null) || (this.Configuration?.Equals(other.Configuration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrecisionDelta = {this.PrecisionDelta}");
            toStringOutput.Add($"this.TestTimeout = {this.TestTimeout}");
            toStringOutput.Add($"Configuration = {(this.Configuration == null ? "null" : this.Configuration.ToString())}");
        }
    }
}