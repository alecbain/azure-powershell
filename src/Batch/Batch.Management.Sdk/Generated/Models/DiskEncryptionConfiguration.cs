// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// The disk encryption configuration applied on compute nodes in the pool.
    /// Disk encryption configuration is not supported on Linux pool created with
    /// Virtual Machine Image or Shared Image Gallery Image.
    /// </summary>
    public partial class DiskEncryptionConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionConfiguration class.
        /// </summary>
        public DiskEncryptionConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskEncryptionConfiguration class.
        /// </summary>

        /// <param name="targets">On Linux pool, only &#34;TemporaryDisk&#34; is supported; on Windows pool, &#34;OsDisk&#34;
        /// and &#34;TemporaryDisk&#34; must be specified.
        /// </param>
        public DiskEncryptionConfiguration(System.Collections.Generic.IList<DiskEncryptionTarget> targets = default(System.Collections.Generic.IList<DiskEncryptionTarget>))

        {
            this.Targets = targets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets on Linux pool, only &#34;TemporaryDisk&#34; is supported; on Windows
        /// pool, &#34;OsDisk&#34; and &#34;TemporaryDisk&#34; must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targets")]
        public System.Collections.Generic.IList<DiskEncryptionTarget> Targets {get; set; }
    }
}