// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Execute data flow activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ExecuteDataFlow")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ExecuteDataFlowActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the ExecuteDataFlowActivity class.
        /// </summary>
        public ExecuteDataFlowActivity()
        {
            this.DataFlow = new DataFlowReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecuteDataFlowActivity class.
        /// </summary>

        /// <param name="additionalProperties">A pipeline activity.
        /// </param>

        /// <param name="name">Activity name.
        /// </param>

        /// <param name="description">Activity description.
        /// </param>

        /// <param name="state">Activity state. This is an optional property and if not provided, the state
        /// will be Active by default.
        /// Possible values include: &#39;Active&#39;, &#39;Inactive&#39;</param>

        /// <param name="onInactiveMarkAs">Status result of the activity when the state is set to Inactive. This is an
        /// optional property and if not provided when the activity is inactive, the
        /// status will be Succeeded by default.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;Skipped&#39;</param>

        /// <param name="dependsOn">Activity depends on condition.
        /// </param>

        /// <param name="userProperties">Activity user properties.
        /// </param>

        /// <param name="linkedServiceName">Linked service reference.
        /// </param>

        /// <param name="policy">Activity policy.
        /// </param>

        /// <param name="dataFlow">Data flow reference.
        /// </param>

        /// <param name="staging">Staging info for execute data flow activity.
        /// </param>

        /// <param name="integrationRuntime">The integration runtime reference.
        /// </param>

        /// <param name="continuationSettings">Continuation settings for execute data flow activity.
        /// </param>

        /// <param name="compute">Compute properties for data flow activity.
        /// </param>

        /// <param name="traceLevel">Trace level setting used for data flow monitoring output. Supported values
        /// are: &#39;coarse&#39;, &#39;fine&#39;, and &#39;none&#39;. Type: string (or Expression with
        /// resultType string)
        /// </param>

        /// <param name="continueOnError">Continue on error setting used for data flow execution. Enables processing
        /// to continue if a sink fails. Type: boolean (or Expression with resultType
        /// boolean)
        /// </param>

        /// <param name="runConcurrently">Concurrent run setting used for data flow execution. Allows sinks with the
        /// same save order to be processed concurrently. Type: boolean (or Expression
        /// with resultType boolean)
        /// </param>

        /// <param name="sourceStagingConcurrency">Specify number of parallel staging for sources applicable to the sink.
        /// Type: integer (or Expression with resultType integer)
        /// </param>
        public ExecuteDataFlowActivity(string name, DataFlowReference dataFlow, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), System.Collections.Generic.IList<ActivityDependency> dependsOn = default(System.Collections.Generic.IList<ActivityDependency>), System.Collections.Generic.IList<UserProperty> userProperties = default(System.Collections.Generic.IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), DataFlowStagingInfo staging = default(DataFlowStagingInfo), IntegrationRuntimeReference integrationRuntime = default(IntegrationRuntimeReference), ContinuationSettingsReference continuationSettings = default(ContinuationSettingsReference), ExecuteDataFlowActivityTypePropertiesCompute compute = default(ExecuteDataFlowActivityTypePropertiesCompute), object traceLevel = default(object), object continueOnError = default(object), object runConcurrently = default(object), object sourceStagingConcurrency = default(object))

        : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties, linkedServiceName, policy)
        {
            this.DataFlow = dataFlow;
            this.Staging = staging;
            this.IntegrationRuntime = integrationRuntime;
            this.ContinuationSettings = continuationSettings;
            this.Compute = compute;
            this.TraceLevel = traceLevel;
            this.ContinueOnError = continueOnError;
            this.RunConcurrently = runConcurrently;
            this.SourceStagingConcurrency = sourceStagingConcurrency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets data flow reference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.dataFlow")]
        public DataFlowReference DataFlow {get; set; }

        /// <summary>
        /// Gets or sets staging info for execute data flow activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.staging")]
        public DataFlowStagingInfo Staging {get; set; }

        /// <summary>
        /// Gets or sets the integration runtime reference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.integrationRuntime")]
        public IntegrationRuntimeReference IntegrationRuntime {get; set; }

        /// <summary>
        /// Gets or sets continuation settings for execute data flow activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.continuationSettings")]
        public ContinuationSettingsReference ContinuationSettings {get; set; }

        /// <summary>
        /// Gets or sets compute properties for data flow activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.compute")]
        public ExecuteDataFlowActivityTypePropertiesCompute Compute {get; set; }

        /// <summary>
        /// Gets or sets trace level setting used for data flow monitoring output.
        /// Supported values are: &#39;coarse&#39;, &#39;fine&#39;, and &#39;none&#39;. Type: string (or
        /// Expression with resultType string)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.traceLevel")]
        public object TraceLevel {get; set; }

        /// <summary>
        /// Gets or sets continue on error setting used for data flow execution.
        /// Enables processing to continue if a sink fails. Type: boolean (or
        /// Expression with resultType boolean)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.continueOnError")]
        public object ContinueOnError {get; set; }

        /// <summary>
        /// Gets or sets concurrent run setting used for data flow execution. Allows
        /// sinks with the same save order to be processed concurrently. Type: boolean
        /// (or Expression with resultType boolean)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.runConcurrently")]
        public object RunConcurrently {get; set; }

        /// <summary>
        /// Gets or sets specify number of parallel staging for sources applicable to
        /// the sink. Type: integer (or Expression with resultType integer)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.sourceStagingConcurrency")]
        public object SourceStagingConcurrency {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.DataFlow == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataFlow");
            }
            if (this.DataFlow != null)
            {
                this.DataFlow.Validate();
            }
            if (this.Staging != null)
            {
                this.Staging.Validate();
            }
            if (this.IntegrationRuntime != null)
            {
                this.IntegrationRuntime.Validate();
            }






        }
    }
}