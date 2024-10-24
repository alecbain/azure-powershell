// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Diagnostic details.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DiagnosticContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticContract class.
        /// </summary>
        public DiagnosticContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticContract class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="alwaysLog">Specifies for what type of messages sampling settings should not apply.
        /// Possible values include: &#39;allErrors&#39;</param>

        /// <param name="verbosity">The verbosity level applied to traces emitted by trace policies.
        /// Possible values include: &#39;verbose&#39;, &#39;information&#39;, &#39;error&#39;</param>

        /// <param name="loggerId">Resource Id of a target logger.
        /// </param>

        /// <param name="sampling">Sampling settings for Diagnostic.
        /// </param>

        /// <param name="frontend">Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
        /// </param>

        /// <param name="backend">Diagnostic settings for incoming/outgoing HTTP messages to the Backend
        /// </param>

        /// <param name="logClientIP">Log the ClientIP. Default is false.
        /// </param>

        /// <param name="httpCorrelationProtocol">Sets correlation protocol to use for Application Insights diagnostics.
        /// Possible values include: &#39;None&#39;, &#39;Legacy&#39;, &#39;W3C&#39;</param>

        /// <param name="operationNameFormat">The format of the Operation Name for Application Insights telemetries.
        /// Default is Name.
        /// Possible values include: &#39;Name&#39;, &#39;Url&#39;</param>
        public DiagnosticContract(string id = default(string), string name = default(string), string type = default(string), string alwaysLog = default(string), string verbosity = default(string), string loggerId = default(string), SamplingSettings sampling = default(SamplingSettings), PipelineDiagnosticSettings frontend = default(PipelineDiagnosticSettings), PipelineDiagnosticSettings backend = default(PipelineDiagnosticSettings), bool? logClientIP = default(bool?), string httpCorrelationProtocol = default(string), string operationNameFormat = default(string))

        : base(id, name, type)
        {
            this.AlwaysLog = alwaysLog;
            this.Verbosity = verbosity;
            this.LoggerId = loggerId;
            this.Sampling = sampling;
            this.Frontend = frontend;
            this.Backend = backend;
            this.LogClientIP = logClientIP;
            this.HttpCorrelationProtocol = httpCorrelationProtocol;
            this.OperationNameFormat = operationNameFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifies for what type of messages sampling settings should
        /// not apply. Possible values include: &#39;allErrors&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.alwaysLog")]
        public string AlwaysLog {get; set; }

        /// <summary>
        /// Gets or sets the verbosity level applied to traces emitted by trace
        /// policies. Possible values include: &#39;verbose&#39;, &#39;information&#39;, &#39;error&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.verbosity")]
        public string Verbosity {get; set; }

        /// <summary>
        /// Gets or sets resource Id of a target logger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.loggerId")]
        public string LoggerId {get; set; }

        /// <summary>
        /// Gets or sets sampling settings for Diagnostic.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sampling")]
        public SamplingSettings Sampling {get; set; }

        /// <summary>
        /// Gets or sets diagnostic settings for incoming/outgoing HTTP messages to the
        /// Gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.frontend")]
        public PipelineDiagnosticSettings Frontend {get; set; }

        /// <summary>
        /// Gets or sets diagnostic settings for incoming/outgoing HTTP messages to the
        /// Backend
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backend")]
        public PipelineDiagnosticSettings Backend {get; set; }

        /// <summary>
        /// Gets or sets log the ClientIP. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.logClientIp")]
        public bool? LogClientIP {get; set; }

        /// <summary>
        /// Gets or sets sets correlation protocol to use for Application Insights
        /// diagnostics. Possible values include: &#39;None&#39;, &#39;Legacy&#39;, &#39;W3C&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.httpCorrelationProtocol")]
        public string HttpCorrelationProtocol {get; set; }

        /// <summary>
        /// Gets or sets the format of the Operation Name for Application Insights
        /// telemetries. Default is Name. Possible values include: &#39;Name&#39;, &#39;Url&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.operationNameFormat")]
        public string OperationNameFormat {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {



            if (this.Sampling != null)
            {
                this.Sampling.Validate();
            }
            if (this.Frontend != null)
            {
                this.Frontend.Validate();
            }
            if (this.Backend != null)
            {
                this.Backend.Validate();
            }


        }
    }
}