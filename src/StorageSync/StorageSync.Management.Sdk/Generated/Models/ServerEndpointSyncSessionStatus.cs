// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using System.Linq;

    /// <summary>
    /// Sync Session status object.
    /// </summary>
    public partial class ServerEndpointSyncSessionStatus
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpointSyncSessionStatus class.
        /// </summary>
        public ServerEndpointSyncSessionStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpointSyncSessionStatus class.
        /// </summary>

        /// <param name="lastSyncResult">Last sync result (HResult)
        /// </param>

        /// <param name="lastSyncTimestamp">Last sync timestamp
        /// </param>

        /// <param name="lastSyncSuccessTimestamp">Last sync success timestamp
        /// </param>

        /// <param name="lastSyncPerItemErrorCount">Last sync per item error count.
        /// </param>

        /// <param name="persistentFilesNotSyncingCount">Count of persistent files not syncing.
        /// </param>

        /// <param name="transientFilesNotSyncingCount">Count of transient files not syncing.
        /// </param>

        /// <param name="filesNotSyncingErrors">Array of per-item errors coming from the last sync session.
        /// </param>

        /// <param name="lastSyncMode">Sync mode
        /// Possible values include: &#39;Regular&#39;, &#39;NamespaceDownload&#39;, &#39;InitialUpload&#39;,
        /// &#39;SnapshotUpload&#39;, &#39;InitialFullDownload&#39;</param>
        public ServerEndpointSyncSessionStatus(int? lastSyncResult = default(int?), System.DateTime? lastSyncTimestamp = default(System.DateTime?), System.DateTime? lastSyncSuccessTimestamp = default(System.DateTime?), long? lastSyncPerItemErrorCount = default(long?), long? persistentFilesNotSyncingCount = default(long?), long? transientFilesNotSyncingCount = default(long?), System.Collections.Generic.IList<ServerEndpointFilesNotSyncingError> filesNotSyncingErrors = default(System.Collections.Generic.IList<ServerEndpointFilesNotSyncingError>), string lastSyncMode = default(string))

        {
            this.LastSyncResult = lastSyncResult;
            this.LastSyncTimestamp = lastSyncTimestamp;
            this.LastSyncSuccessTimestamp = lastSyncSuccessTimestamp;
            this.LastSyncPerItemErrorCount = lastSyncPerItemErrorCount;
            this.PersistentFilesNotSyncingCount = persistentFilesNotSyncingCount;
            this.TransientFilesNotSyncingCount = transientFilesNotSyncingCount;
            this.FilesNotSyncingErrors = filesNotSyncingErrors;
            this.LastSyncMode = lastSyncMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets last sync result (HResult)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSyncResult")]
        public int? LastSyncResult {get; private set; }

        /// <summary>
        /// Gets last sync timestamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSyncTimestamp")]
        public System.DateTime? LastSyncTimestamp {get; private set; }

        /// <summary>
        /// Gets last sync success timestamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSyncSuccessTimestamp")]
        public System.DateTime? LastSyncSuccessTimestamp {get; private set; }

        /// <summary>
        /// Gets last sync per item error count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSyncPerItemErrorCount")]
        public long? LastSyncPerItemErrorCount {get; private set; }

        /// <summary>
        /// Gets count of persistent files not syncing.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "persistentFilesNotSyncingCount")]
        public long? PersistentFilesNotSyncingCount {get; private set; }

        /// <summary>
        /// Gets count of transient files not syncing.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "transientFilesNotSyncingCount")]
        public long? TransientFilesNotSyncingCount {get; private set; }

        /// <summary>
        /// Gets array of per-item errors coming from the last sync session.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "filesNotSyncingErrors")]
        public System.Collections.Generic.IList<ServerEndpointFilesNotSyncingError> FilesNotSyncingErrors {get; private set; }

        /// <summary>
        /// Gets sync mode Possible values include: &#39;Regular&#39;, &#39;NamespaceDownload&#39;, &#39;InitialUpload&#39;, &#39;SnapshotUpload&#39;, &#39;InitialFullDownload&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSyncMode")]
        public string LastSyncMode {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.LastSyncPerItemErrorCount != null)
            {
                if (this.LastSyncPerItemErrorCount < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "LastSyncPerItemErrorCount", 0);
                }
            }
            if (this.PersistentFilesNotSyncingCount != null)
            {
                if (this.PersistentFilesNotSyncingCount < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "PersistentFilesNotSyncingCount", 0);
                }
            }
            if (this.TransientFilesNotSyncingCount != null)
            {
                if (this.TransientFilesNotSyncingCount < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "TransientFilesNotSyncingCount", 0);
                }
            }
            if (this.FilesNotSyncingErrors != null)
            {
                foreach (var element in this.FilesNotSyncingErrors)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }

        }
    }
}