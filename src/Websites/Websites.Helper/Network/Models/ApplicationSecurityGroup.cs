// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network.Models
{
    using System.Linq;

    /// <summary>
    /// An application security group in a resource group.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationSecurityGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationSecurityGroup class.
        /// </summary>
        public ApplicationSecurityGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationSecurityGroup class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the application security group resource.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;</param>

        /// <param name="resourceGuid">The resource GUID property of the application security group resource. It
        /// uniquely identifies a resource, even if the user changes its name or
        /// migrate the resource across subscriptions or resource groups.
        /// </param>
        public ApplicationSecurityGroup(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), string provisioningState = default(string), string resourceGuid = default(string))

        : base(id, name, type, location, tags)
        {
            this.Etag = etag;
            this.ProvisioningState = provisioningState;
            this.ResourceGuid = resourceGuid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the application security group resource. Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets the resource GUID property of the application security group resource.
        /// It uniquely identifies a resource, even if the user changes its name or
        /// migrate the resource across subscriptions or resource groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid {get; private set; }
    }
}