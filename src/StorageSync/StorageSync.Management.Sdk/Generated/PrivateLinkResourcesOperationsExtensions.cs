// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for PrivateLinkResourcesOperations
    /// </summary>
    public static partial class PrivateLinkResourcesOperationsExtensions
    {
        /// <summary>
        /// Gets the private link resources that need to be created for a storage sync
        /// service.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// The name of the storage sync service name within the specified resource
        /// group.
        /// </param>
        public static PrivateLinkResourceListResult ListByStorageSyncService(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string storageSyncServiceName)
        {
                return ((IPrivateLinkResourcesOperations)operations).ListByStorageSyncServiceAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a storage sync
        /// service.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// The name of the storage sync service name within the specified resource
        /// group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<PrivateLinkResourceListResult> ListByStorageSyncServiceAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string storageSyncServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByStorageSyncServiceWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
