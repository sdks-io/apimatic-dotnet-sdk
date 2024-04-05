// <copyright file="CodeGenSettings.cs" company="APIMatic">
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
    /// CodeGenSettings.
    /// </summary>
    public class CodeGenSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGenSettings"/> class.
        /// </summary>
        public CodeGenSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGenSettings"/> class.
        /// </summary>
        /// <param name="isAsync">isAsync.</param>
        /// <param name="useHttpMethodPrefix">useHttpMethodPrefix.</param>
        /// <param name="useModelPrefix">useModelPrefix.</param>
        /// <param name="useEnumPrefix">useEnumPrefix.</param>
        /// <param name="useConstructorsForConfig">useConstructorsForConfig.</param>
        /// <param name="useCommonSdkLibrary">useCommonSdkLibrary.</param>
        /// <param name="generateInterfaces">generateInterfaces.</param>
        /// <param name="generateAppveyorConfig">generateAppveyorConfig.</param>
        /// <param name="generateCircleConfig">generateCircleConfig.</param>
        /// <param name="generateJenkinsConfig">generateJenkinsConfig.</param>
        /// <param name="generateTravisConfig">generateTravisConfig.</param>
        /// <param name="androidUseAppManifest">androidUseAppManifest.</param>
        /// <param name="iosUseAppInfoPlist">iosUseAppInfoPlist.</param>
        /// <param name="iosGenerateCoreData">iosGenerateCoreData.</param>
        /// <param name="runscopeEnabled">runscopeEnabled.</param>
        /// <param name="collapseParamsToArray">collapseParamsToArray.</param>
        /// <param name="preserveParameterOrder">preserveParameterOrder.</param>
        /// <param name="appendContentHeaders">appendContentHeaders.</param>
        /// <param name="modelSerializationIsJSON">modelSerializationIsJSON.</param>
        /// <param name="nullify404">nullify404.</param>
        /// <param name="validateRequiredParameters">validateRequiredParameters.</param>
        /// <param name="enableAdditionalModelProperties">enableAdditionalModelProperties.</param>
        /// <param name="javaUsePropertiesConfig">javaUsePropertiesConfig.</param>
        /// <param name="useControllerPrefix">useControllerPrefix.</param>
        /// <param name="useExceptionPrefix">useExceptionPrefix.</param>
        /// <param name="parameterArrayFormat">parameterArrayFormat.</param>
        /// <param name="objCHttpClient">objCHttpClient.</param>
        /// <param name="cSharpHttpClient">cSharpHttpClient.</param>
        /// <param name="androidHttpClient">androidHttpClient.</param>
        /// <param name="nodeHttpClient">nodeHttpClient.</param>
        /// <param name="phpHttpClient">phpHttpClient.</param>
        /// <param name="bodySerialization">bodySerialization.</param>
        /// <param name="arraySerialization">arraySerialization.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="enableLogging">enableLogging.</param>
        /// <param name="enableHttpCache">enableHttpCache.</param>
        /// <param name="retries">retries.</param>
        /// <param name="retryInterval">retryInterval.</param>
        /// <param name="generateAdvancedDocs">generateAdvancedDocs.</param>
        /// <param name="storeTimezoneInformation">storeTimezoneInformation.</param>
        /// <param name="enablePhpComposerVersionString">enablePhpComposerVersionString.</param>
        /// <param name="securityProtocols">securityProtocols.</param>
        /// <param name="underscoreNumbers">underscoreNumbers.</param>
        /// <param name="useSingletonPattern">useSingletonPattern.</param>
        /// <param name="disableLinting">disableLinting.</param>
        /// <param name="allowSkippingSSLCertVerification">allowSkippingSSLCertVerification.</param>
        /// <param name="applyCustomizations">applyCustomizations.</param>
        /// <param name="doNotSplitWords">doNotSplitWords.</param>
        /// <param name="sortResources">sortResources.</param>
        /// <param name="enableGlobalUserAgent">enableGlobalUserAgent.</param>
        public CodeGenSettings(
            bool isAsync,
            bool useHttpMethodPrefix,
            bool useModelPrefix,
            bool useEnumPrefix,
            bool useConstructorsForConfig,
            bool useCommonSdkLibrary,
            bool generateInterfaces,
            bool generateAppveyorConfig,
            bool generateCircleConfig,
            bool generateJenkinsConfig,
            bool generateTravisConfig,
            bool androidUseAppManifest,
            bool iosUseAppInfoPlist,
            bool iosGenerateCoreData,
            bool runscopeEnabled,
            bool collapseParamsToArray,
            bool preserveParameterOrder,
            bool appendContentHeaders,
            bool modelSerializationIsJSON,
            bool nullify404,
            bool validateRequiredParameters,
            bool enableAdditionalModelProperties,
            bool javaUsePropertiesConfig,
            bool useControllerPrefix,
            bool useExceptionPrefix,
            string parameterArrayFormat,
            string objCHttpClient,
            string cSharpHttpClient,
            string androidHttpClient,
            string nodeHttpClient,
            string phpHttpClient,
            int bodySerialization,
            string arraySerialization,
            int timeout,
            bool enableLogging,
            bool enableHttpCache,
            int retries,
            int retryInterval,
            bool generateAdvancedDocs,
            bool storeTimezoneInformation,
            bool enablePhpComposerVersionString,
            List<string> securityProtocols,
            bool underscoreNumbers,
            bool useSingletonPattern,
            bool disableLinting,
            bool allowSkippingSSLCertVerification,
            List<string> applyCustomizations,
            List<string> doNotSplitWords,
            bool sortResources,
            bool enableGlobalUserAgent)
        {
            this.IsAsync = isAsync;
            this.UseHttpMethodPrefix = useHttpMethodPrefix;
            this.UseModelPrefix = useModelPrefix;
            this.UseEnumPrefix = useEnumPrefix;
            this.UseConstructorsForConfig = useConstructorsForConfig;
            this.UseCommonSdkLibrary = useCommonSdkLibrary;
            this.GenerateInterfaces = generateInterfaces;
            this.GenerateAppveyorConfig = generateAppveyorConfig;
            this.GenerateCircleConfig = generateCircleConfig;
            this.GenerateJenkinsConfig = generateJenkinsConfig;
            this.GenerateTravisConfig = generateTravisConfig;
            this.AndroidUseAppManifest = androidUseAppManifest;
            this.IosUseAppInfoPlist = iosUseAppInfoPlist;
            this.IosGenerateCoreData = iosGenerateCoreData;
            this.RunscopeEnabled = runscopeEnabled;
            this.CollapseParamsToArray = collapseParamsToArray;
            this.PreserveParameterOrder = preserveParameterOrder;
            this.AppendContentHeaders = appendContentHeaders;
            this.ModelSerializationIsJSON = modelSerializationIsJSON;
            this.Nullify404 = nullify404;
            this.ValidateRequiredParameters = validateRequiredParameters;
            this.EnableAdditionalModelProperties = enableAdditionalModelProperties;
            this.JavaUsePropertiesConfig = javaUsePropertiesConfig;
            this.UseControllerPrefix = useControllerPrefix;
            this.UseExceptionPrefix = useExceptionPrefix;
            this.ParameterArrayFormat = parameterArrayFormat;
            this.ObjCHttpClient = objCHttpClient;
            this.CSharpHttpClient = cSharpHttpClient;
            this.AndroidHttpClient = androidHttpClient;
            this.NodeHttpClient = nodeHttpClient;
            this.PhpHttpClient = phpHttpClient;
            this.BodySerialization = bodySerialization;
            this.ArraySerialization = arraySerialization;
            this.Timeout = timeout;
            this.EnableLogging = enableLogging;
            this.EnableHttpCache = enableHttpCache;
            this.Retries = retries;
            this.RetryInterval = retryInterval;
            this.GenerateAdvancedDocs = generateAdvancedDocs;
            this.StoreTimezoneInformation = storeTimezoneInformation;
            this.EnablePhpComposerVersionString = enablePhpComposerVersionString;
            this.SecurityProtocols = securityProtocols;
            this.UnderscoreNumbers = underscoreNumbers;
            this.UseSingletonPattern = useSingletonPattern;
            this.DisableLinting = disableLinting;
            this.AllowSkippingSSLCertVerification = allowSkippingSSLCertVerification;
            this.ApplyCustomizations = applyCustomizations;
            this.DoNotSplitWords = doNotSplitWords;
            this.SortResources = sortResources;
            this.EnableGlobalUserAgent = enableGlobalUserAgent;
        }

        /// <summary>
        /// Generate asynchronous code for API Calls and deserialization
        /// </summary>
        [JsonProperty("isAsync")]
        public bool IsAsync { get; set; }

        /// <summary>
        /// Use HTTP Method prefixes for endpoint wrappers
        /// </summary>
        [JsonProperty("useHttpMethodPrefix")]
        public bool UseHttpMethodPrefix { get; set; }

        /// <summary>
        /// Use "Model" postfixes for generated class names
        /// </summary>
        [JsonProperty("useModelPrefix")]
        public bool UseModelPrefix { get; set; }

        /// <summary>
        /// Use "Enum" postfixes for enumerated types
        /// </summary>
        [JsonProperty("useEnumPrefix")]
        public bool UseEnumPrefix { get; set; }

        /// <summary>
        /// Gets or sets UseConstructorsForConfig.
        /// </summary>
        [JsonProperty("useConstructorsForConfig")]
        public bool UseConstructorsForConfig { get; set; }

        /// <summary>
        /// Use common SDK library to reduce code duplication
        /// </summary>
        [JsonProperty("useCommonSdkLibrary")]
        public bool UseCommonSdkLibrary { get; set; }

        /// <summary>
        /// Generates interfaces for controller classes in the generated SDKs
        /// </summary>
        [JsonProperty("generateInterfaces")]
        public bool GenerateInterfaces { get; set; }

        /// <summary>
        /// Generate Appveyor configuration file
        /// </summary>
        [JsonProperty("generateAppveyorConfig")]
        public bool GenerateAppveyorConfig { get; set; }

        /// <summary>
        /// Generate CircleCI configuration file
        /// </summary>
        [JsonProperty("generateCircleConfig")]
        public bool GenerateCircleConfig { get; set; }

        /// <summary>
        /// Generate Jenkins configuration file
        /// </summary>
        [JsonProperty("generateJenkinsConfig")]
        public bool GenerateJenkinsConfig { get; set; }

        /// <summary>
        /// Generate Travis CI configuration file
        /// </summary>
        [JsonProperty("generateTravisConfig")]
        public bool GenerateTravisConfig { get; set; }

        /// <summary>
        /// Use "AndroidManifest.xml" for config variables in Android
        /// </summary>
        [JsonProperty("androidUseAppManifest")]
        public bool AndroidUseAppManifest { get; set; }

        /// <summary>
        /// Use "App-Info.plist" file for config variables in iOS
        /// </summary>
        [JsonProperty("iosUseAppInfoPlist")]
        public bool IosUseAppInfoPlist { get; set; }

        /// <summary>
        /// Generate "CoreData" schema and entity classes in iOS?
        /// </summary>
        [JsonProperty("iosGenerateCoreData")]
        public bool IosGenerateCoreData { get; set; }

        /// <summary>
        /// Enable runscope
        /// </summary>
        [JsonProperty("runscopeEnabled")]
        public bool RunscopeEnabled { get; set; }

        /// <summary>
        /// Collect Parameters as arrays
        /// </summary>
        [JsonProperty("collapseParamsToArray")]
        public bool CollapseParamsToArray { get; set; }

        /// <summary>
        /// Attempts to preserve parameter order for endpoints
        /// </summary>
        [JsonProperty("preserveParameterOrder")]
        public bool PreserveParameterOrder { get; set; }

        /// <summary>
        /// Append JSON/XML accept and content-type headers
        /// </summary>
        [JsonProperty("appendContentHeaders")]
        public bool AppendContentHeaders { get; set; }

        /// <summary>
        /// Gets or sets ModelSerializationIsJSON.
        /// </summary>
        [JsonProperty("modelSerializationIsJSON")]
        public bool ModelSerializationIsJSON { get; set; }

        /// <summary>
        /// Return a null value on HTTP 404
        /// </summary>
        [JsonProperty("nullify404")]
        public bool Nullify404 { get; set; }

        /// <summary>
        /// Validate required parameters to be Not Null
        /// </summary>
        [JsonProperty("validateRequiredParameters")]
        public bool ValidateRequiredParameters { get; set; }

        /// <summary>
        /// Allow models to have additional runtime properties
        /// </summary>
        [JsonProperty("enableAdditionalModelProperties")]
        public bool EnableAdditionalModelProperties { get; set; }

        /// <summary>
        /// Gets or sets JavaUsePropertiesConfig.
        /// </summary>
        [JsonProperty("javaUsePropertiesConfig")]
        public bool JavaUsePropertiesConfig { get; set; }

        /// <summary>
        /// Use "Controller" postfixes for generated controller classes
        /// </summary>
        [JsonProperty("useControllerPrefix")]
        public bool UseControllerPrefix { get; set; }

        /// <summary>
        /// Use Exception Prefixes
        /// </summary>
        [JsonProperty("useExceptionPrefix")]
        public bool UseExceptionPrefix { get; set; }

        /// <summary>
        /// Parameter Array format with index or without
        /// </summary>
        [JsonProperty("parameterArrayFormat")]
        public string ParameterArrayFormat { get; set; }

        /// <summary>
        /// Configure the HTTP client for Objective C
        /// </summary>
        [JsonProperty("objCHttpClient")]
        public string ObjCHttpClient { get; set; }

        /// <summary>
        /// Configure the HTTP client for C#
        /// </summary>
        [JsonProperty("cSharpHttpClient")]
        public string CSharpHttpClient { get; set; }

        /// <summary>
        /// Configure the HTTP client for  Android
        /// </summary>
        [JsonProperty("androidHttpClient")]
        public string AndroidHttpClient { get; set; }

        /// <summary>
        /// Configure the HTTP client for node
        /// </summary>
        [JsonProperty("nodeHttpClient")]
        public string NodeHttpClient { get; set; }

        /// <summary>
        /// Configure the HTTP client for PHP
        /// </summary>
        [JsonProperty("phpHttpClient")]
        public string PhpHttpClient { get; set; }

        /// <summary>
        /// Gets or sets BodySerialization.
        /// </summary>
        [JsonProperty("bodySerialization")]
        public int BodySerialization { get; set; }

        /// <summary>
        /// Specify type of array serialisation
        /// </summary>
        [JsonProperty("arraySerialization")]
        public string ArraySerialization { get; set; }

        /// <summary>
        /// This option specifies the duration (in seconds) after which requests would timeout
        /// </summary>
        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        /// <summary>
        /// Enabling this generates code in the SDKs for logging events in the API cycle using a library.
        /// </summary>
        [JsonProperty("enableLogging")]
        public bool EnableLogging { get; set; }

        /// <summary>
        /// Enabling caching of responses (not available in all languages)
        /// </summary>
        [JsonProperty("enableHttpCache")]
        public bool EnableHttpCache { get; set; }

        /// <summary>
        /// Specify number of retries
        /// </summary>
        [JsonProperty("retries")]
        public int Retries { get; set; }

        /// <summary>
        /// Specify retry interval in case of failures
        /// </summary>
        [JsonProperty("retryInterval")]
        public int RetryInterval { get; set; }

        /// <summary>
        /// Generate advanced read me files
        /// </summary>
        [JsonProperty("generateAdvancedDocs")]
        public bool GenerateAdvancedDocs { get; set; }

        /// <summary>
        /// Store Timezone information for the generation
        /// </summary>
        [JsonProperty("storeTimezoneInformation")]
        public bool StoreTimezoneInformation { get; set; }

        /// <summary>
        /// Use "Controller" postfixes for generated controller classes
        /// </summary>
        [JsonProperty("enablePhpComposerVersionString")]
        public bool EnablePhpComposerVersionString { get; set; }

        /// <summary>
        /// Specify Security Protocols
        /// </summary>
        [JsonProperty("securityProtocols")]
        public List<string> SecurityProtocols { get; set; }

        /// <summary>
        /// Use underscores before and after numbers for underscore case
        /// </summary>
        [JsonProperty("underscoreNumbers")]
        public bool UnderscoreNumbers { get; set; }

        /// <summary>
        /// Allow usage of a Singleton Pattern
        /// </summary>
        [JsonProperty("useSingletonPattern")]
        public bool UseSingletonPattern { get; set; }

        /// <summary>
        /// Files/dependencies used for linting are not generated if this option is enabled
        /// </summary>
        [JsonProperty("disableLinting")]
        public bool DisableLinting { get; set; }

        /// <summary>
        /// Create a configuration option in SDKs to optionally skip certificate verification when establishing HTTPS connections.
        /// </summary>
        [JsonProperty("allowSkippingSSLCertVerification")]
        public bool AllowSkippingSSLCertVerification { get; set; }

        /// <summary>
        /// Apply Customisations
        /// </summary>
        [JsonProperty("applyCustomizations")]
        public List<string> ApplyCustomizations { get; set; }

        /// <summary>
        /// Enabling this will stop splitting of words when converting identifiers from API specification to language-specific identifiers.
        /// </summary>
        [JsonProperty("doNotSplitWords")]
        public List<string> DoNotSplitWords { get; set; }

        /// <summary>
        /// Sorts resources such as endpoints, endpoint groups and models in generated documentation
        /// </summary>
        [JsonProperty("sortResources")]
        public bool SortResources { get; set; }

        /// <summary>
        /// Enable a global user agent
        /// </summary>
        [JsonProperty("enableGlobalUserAgent")]
        public bool EnableGlobalUserAgent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CodeGenSettings : ({string.Join(", ", toStringOutput)})";
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
            return obj is CodeGenSettings other &&                this.IsAsync.Equals(other.IsAsync) &&
                this.UseHttpMethodPrefix.Equals(other.UseHttpMethodPrefix) &&
                this.UseModelPrefix.Equals(other.UseModelPrefix) &&
                this.UseEnumPrefix.Equals(other.UseEnumPrefix) &&
                this.UseConstructorsForConfig.Equals(other.UseConstructorsForConfig) &&
                this.UseCommonSdkLibrary.Equals(other.UseCommonSdkLibrary) &&
                this.GenerateInterfaces.Equals(other.GenerateInterfaces) &&
                this.GenerateAppveyorConfig.Equals(other.GenerateAppveyorConfig) &&
                this.GenerateCircleConfig.Equals(other.GenerateCircleConfig) &&
                this.GenerateJenkinsConfig.Equals(other.GenerateJenkinsConfig) &&
                this.GenerateTravisConfig.Equals(other.GenerateTravisConfig) &&
                this.AndroidUseAppManifest.Equals(other.AndroidUseAppManifest) &&
                this.IosUseAppInfoPlist.Equals(other.IosUseAppInfoPlist) &&
                this.IosGenerateCoreData.Equals(other.IosGenerateCoreData) &&
                this.RunscopeEnabled.Equals(other.RunscopeEnabled) &&
                this.CollapseParamsToArray.Equals(other.CollapseParamsToArray) &&
                this.PreserveParameterOrder.Equals(other.PreserveParameterOrder) &&
                this.AppendContentHeaders.Equals(other.AppendContentHeaders) &&
                this.ModelSerializationIsJSON.Equals(other.ModelSerializationIsJSON) &&
                this.Nullify404.Equals(other.Nullify404) &&
                this.ValidateRequiredParameters.Equals(other.ValidateRequiredParameters) &&
                this.EnableAdditionalModelProperties.Equals(other.EnableAdditionalModelProperties) &&
                this.JavaUsePropertiesConfig.Equals(other.JavaUsePropertiesConfig) &&
                this.UseControllerPrefix.Equals(other.UseControllerPrefix) &&
                this.UseExceptionPrefix.Equals(other.UseExceptionPrefix) &&
                ((this.ParameterArrayFormat == null && other.ParameterArrayFormat == null) || (this.ParameterArrayFormat?.Equals(other.ParameterArrayFormat) == true)) &&
                ((this.ObjCHttpClient == null && other.ObjCHttpClient == null) || (this.ObjCHttpClient?.Equals(other.ObjCHttpClient) == true)) &&
                ((this.CSharpHttpClient == null && other.CSharpHttpClient == null) || (this.CSharpHttpClient?.Equals(other.CSharpHttpClient) == true)) &&
                ((this.AndroidHttpClient == null && other.AndroidHttpClient == null) || (this.AndroidHttpClient?.Equals(other.AndroidHttpClient) == true)) &&
                ((this.NodeHttpClient == null && other.NodeHttpClient == null) || (this.NodeHttpClient?.Equals(other.NodeHttpClient) == true)) &&
                ((this.PhpHttpClient == null && other.PhpHttpClient == null) || (this.PhpHttpClient?.Equals(other.PhpHttpClient) == true)) &&
                this.BodySerialization.Equals(other.BodySerialization) &&
                ((this.ArraySerialization == null && other.ArraySerialization == null) || (this.ArraySerialization?.Equals(other.ArraySerialization) == true)) &&
                this.Timeout.Equals(other.Timeout) &&
                this.EnableLogging.Equals(other.EnableLogging) &&
                this.EnableHttpCache.Equals(other.EnableHttpCache) &&
                this.Retries.Equals(other.Retries) &&
                this.RetryInterval.Equals(other.RetryInterval) &&
                this.GenerateAdvancedDocs.Equals(other.GenerateAdvancedDocs) &&
                this.StoreTimezoneInformation.Equals(other.StoreTimezoneInformation) &&
                this.EnablePhpComposerVersionString.Equals(other.EnablePhpComposerVersionString) &&
                ((this.SecurityProtocols == null && other.SecurityProtocols == null) || (this.SecurityProtocols?.Equals(other.SecurityProtocols) == true)) &&
                this.UnderscoreNumbers.Equals(other.UnderscoreNumbers) &&
                this.UseSingletonPattern.Equals(other.UseSingletonPattern) &&
                this.DisableLinting.Equals(other.DisableLinting) &&
                this.AllowSkippingSSLCertVerification.Equals(other.AllowSkippingSSLCertVerification) &&
                ((this.ApplyCustomizations == null && other.ApplyCustomizations == null) || (this.ApplyCustomizations?.Equals(other.ApplyCustomizations) == true)) &&
                ((this.DoNotSplitWords == null && other.DoNotSplitWords == null) || (this.DoNotSplitWords?.Equals(other.DoNotSplitWords) == true)) &&
                this.SortResources.Equals(other.SortResources) &&
                this.EnableGlobalUserAgent.Equals(other.EnableGlobalUserAgent);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsAsync = {this.IsAsync}");
            toStringOutput.Add($"this.UseHttpMethodPrefix = {this.UseHttpMethodPrefix}");
            toStringOutput.Add($"this.UseModelPrefix = {this.UseModelPrefix}");
            toStringOutput.Add($"this.UseEnumPrefix = {this.UseEnumPrefix}");
            toStringOutput.Add($"this.UseConstructorsForConfig = {this.UseConstructorsForConfig}");
            toStringOutput.Add($"this.UseCommonSdkLibrary = {this.UseCommonSdkLibrary}");
            toStringOutput.Add($"this.GenerateInterfaces = {this.GenerateInterfaces}");
            toStringOutput.Add($"this.GenerateAppveyorConfig = {this.GenerateAppveyorConfig}");
            toStringOutput.Add($"this.GenerateCircleConfig = {this.GenerateCircleConfig}");
            toStringOutput.Add($"this.GenerateJenkinsConfig = {this.GenerateJenkinsConfig}");
            toStringOutput.Add($"this.GenerateTravisConfig = {this.GenerateTravisConfig}");
            toStringOutput.Add($"this.AndroidUseAppManifest = {this.AndroidUseAppManifest}");
            toStringOutput.Add($"this.IosUseAppInfoPlist = {this.IosUseAppInfoPlist}");
            toStringOutput.Add($"this.IosGenerateCoreData = {this.IosGenerateCoreData}");
            toStringOutput.Add($"this.RunscopeEnabled = {this.RunscopeEnabled}");
            toStringOutput.Add($"this.CollapseParamsToArray = {this.CollapseParamsToArray}");
            toStringOutput.Add($"this.PreserveParameterOrder = {this.PreserveParameterOrder}");
            toStringOutput.Add($"this.AppendContentHeaders = {this.AppendContentHeaders}");
            toStringOutput.Add($"this.ModelSerializationIsJSON = {this.ModelSerializationIsJSON}");
            toStringOutput.Add($"this.Nullify404 = {this.Nullify404}");
            toStringOutput.Add($"this.ValidateRequiredParameters = {this.ValidateRequiredParameters}");
            toStringOutput.Add($"this.EnableAdditionalModelProperties = {this.EnableAdditionalModelProperties}");
            toStringOutput.Add($"this.JavaUsePropertiesConfig = {this.JavaUsePropertiesConfig}");
            toStringOutput.Add($"this.UseControllerPrefix = {this.UseControllerPrefix}");
            toStringOutput.Add($"this.UseExceptionPrefix = {this.UseExceptionPrefix}");
            toStringOutput.Add($"this.ParameterArrayFormat = {(this.ParameterArrayFormat == null ? "null" : this.ParameterArrayFormat)}");
            toStringOutput.Add($"this.ObjCHttpClient = {(this.ObjCHttpClient == null ? "null" : this.ObjCHttpClient)}");
            toStringOutput.Add($"this.CSharpHttpClient = {(this.CSharpHttpClient == null ? "null" : this.CSharpHttpClient)}");
            toStringOutput.Add($"this.AndroidHttpClient = {(this.AndroidHttpClient == null ? "null" : this.AndroidHttpClient)}");
            toStringOutput.Add($"this.NodeHttpClient = {(this.NodeHttpClient == null ? "null" : this.NodeHttpClient)}");
            toStringOutput.Add($"this.PhpHttpClient = {(this.PhpHttpClient == null ? "null" : this.PhpHttpClient)}");
            toStringOutput.Add($"this.BodySerialization = {this.BodySerialization}");
            toStringOutput.Add($"this.ArraySerialization = {(this.ArraySerialization == null ? "null" : this.ArraySerialization)}");
            toStringOutput.Add($"this.Timeout = {this.Timeout}");
            toStringOutput.Add($"this.EnableLogging = {this.EnableLogging}");
            toStringOutput.Add($"this.EnableHttpCache = {this.EnableHttpCache}");
            toStringOutput.Add($"this.Retries = {this.Retries}");
            toStringOutput.Add($"this.RetryInterval = {this.RetryInterval}");
            toStringOutput.Add($"this.GenerateAdvancedDocs = {this.GenerateAdvancedDocs}");
            toStringOutput.Add($"this.StoreTimezoneInformation = {this.StoreTimezoneInformation}");
            toStringOutput.Add($"this.EnablePhpComposerVersionString = {this.EnablePhpComposerVersionString}");
            toStringOutput.Add($"this.SecurityProtocols = {(this.SecurityProtocols == null ? "null" : $"[{string.Join(", ", this.SecurityProtocols)} ]")}");
            toStringOutput.Add($"this.UnderscoreNumbers = {this.UnderscoreNumbers}");
            toStringOutput.Add($"this.UseSingletonPattern = {this.UseSingletonPattern}");
            toStringOutput.Add($"this.DisableLinting = {this.DisableLinting}");
            toStringOutput.Add($"this.AllowSkippingSSLCertVerification = {this.AllowSkippingSSLCertVerification}");
            toStringOutput.Add($"this.ApplyCustomizations = {(this.ApplyCustomizations == null ? "null" : $"[{string.Join(", ", this.ApplyCustomizations)} ]")}");
            toStringOutput.Add($"this.DoNotSplitWords = {(this.DoNotSplitWords == null ? "null" : $"[{string.Join(", ", this.DoNotSplitWords)} ]")}");
            toStringOutput.Add($"this.SortResources = {this.SortResources}");
            toStringOutput.Add($"this.EnableGlobalUserAgent = {this.EnableGlobalUserAgent}");
        }
    }
}