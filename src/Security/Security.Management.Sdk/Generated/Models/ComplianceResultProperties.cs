// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Compliance result data
    /// </summary>
    public partial class ComplianceResultProperties
    {
        /// <summary>
        /// Initializes a new instance of the ComplianceResultProperties class.
        /// </summary>
        public ComplianceResultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComplianceResultProperties class.
        /// </summary>

        /// <param name="resourceStatus">The status of the resource regarding a single assessment
        /// Possible values include: 'Healthy', 'NotApplicable', 'OffByPolicy',
        /// 'NotHealthy'</param>
        public ComplianceResultProperties(string resourceStatus = default(string))

        {
            this.ResourceStatus = resourceStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the status of the resource regarding a single assessment Possible values include: &#39;Healthy&#39;, &#39;NotApplicable&#39;, &#39;OffByPolicy&#39;, &#39;NotHealthy&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceStatus")]
        public string ResourceStatus {get; private set; }
    }
}