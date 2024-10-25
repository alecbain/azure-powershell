// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Server role migration result
    /// </summary>
    public partial class StartMigrationScenarioServerRoleResult
    {
        /// <summary>
        /// Initializes a new instance of the StartMigrationScenarioServerRoleResult class.
        /// </summary>
        public StartMigrationScenarioServerRoleResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StartMigrationScenarioServerRoleResult class.
        /// </summary>

        /// <param name="name">Name of server role.
        /// </param>

        /// <param name="state">Current state of migration
        /// Possible values include: &#39;None&#39;, &#39;InProgress&#39;, &#39;Failed&#39;, &#39;Warning&#39;,
        /// &#39;Completed&#39;, &#39;Skipped&#39;, &#39;Stopped&#39;</param>

        /// <param name="exceptionsAndWarnings">Migration exceptions and warnings.
        /// </param>
        public StartMigrationScenarioServerRoleResult(string name = default(string), string state = default(string), System.Collections.Generic.IList<ReportableException> exceptionsAndWarnings = default(System.Collections.Generic.IList<ReportableException>))

        {
            this.Name = name;
            this.State = state;
            this.ExceptionsAndWarnings = exceptionsAndWarnings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets name of server role.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets current state of migration Possible values include: &#39;None&#39;, &#39;InProgress&#39;, &#39;Failed&#39;, &#39;Warning&#39;, &#39;Completed&#39;, &#39;Skipped&#39;, &#39;Stopped&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public string State {get; private set; }

        /// <summary>
        /// Gets migration exceptions and warnings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exceptionsAndWarnings")]
        public System.Collections.Generic.IList<ReportableException> ExceptionsAndWarnings {get; private set; }
    }
}