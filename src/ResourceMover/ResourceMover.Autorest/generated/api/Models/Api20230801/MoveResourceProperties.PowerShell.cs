// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801
{
    using Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.PowerShell;

    /// <summary>Defines the move resource properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(MoveResourcePropertiesTypeConverter))]
    public partial class MoveResourceProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MoveResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MoveResourceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MoveResourceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MoveResourceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MoveResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MoveStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceStatus) content.GetValueForProperty("MoveStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).TargetId, global::System.Convert.ToString);
            }
            if (content.Contains("ExistingTargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ExistingTargetId = (string) content.GetValueForProperty("ExistingTargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ExistingTargetId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IResourceSettings) content.GetValueForProperty("ResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.ResourceSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceResourceSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IResourceSettings) content.GetValueForProperty("SourceResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.ResourceSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DependsOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOn = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependency[]) content.GetValueForProperty("DependsOn",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependency>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceDependencyTypeConverter.ConvertFrom));
            }
            if (content.Contains("DependsOnOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOnOverride = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependencyOverride[]) content.GetValueForProperty("DependsOnOverride",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOnOverride, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependencyOverride>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceDependencyOverrideTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsResolveRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).IsResolveRequired = (bool?) content.GetValueForProperty("IsResolveRequired",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).IsResolveRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MoveStatusJobStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusJobStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IJobStatus) content.GetValueForProperty("MoveStatusJobStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusJobStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.JobStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("MoveStatusMoveState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusMoveState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState?) content.GetValueForProperty("MoveStatusMoveState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusMoveState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState.CreateFrom);
            }
            if (content.Contains("MoveStatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusError = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceError) content.GetValueForProperty("MoveStatusError",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusError, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobStatusJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobName = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName?) content.GetValueForProperty("JobStatusJobName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobName, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName.CreateFrom);
            }
            if (content.Contains("JobStatusJobProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobProgress = (string) content.GetValueForProperty("JobStatusJobProgress",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobProgress, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody) content.GetValueForProperty("ErrorsProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            }
            if (content.Contains("MoveStatusErrorsProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody) content.GetValueForProperty("MoveStatusErrorsProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorsPropertiesCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesCode = (string) content.GetValueForProperty("ErrorsPropertiesCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsPropertiesMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesMessage = (string) content.GetValueForProperty("ErrorsPropertiesMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsPropertiesTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesTarget = (string) content.GetValueForProperty("ErrorsPropertiesTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesTarget, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsPropertiesDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody[]) content.GetValueForProperty("ErrorsPropertiesDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            }
            if (content.Contains("MoveStatusErrorsPropertiesCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesCode = (string) content.GetValueForProperty("MoveStatusErrorsPropertiesCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesCode, global::System.Convert.ToString);
            }
            if (content.Contains("MoveStatusErrorsPropertiesMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesMessage = (string) content.GetValueForProperty("MoveStatusErrorsPropertiesMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesMessage, global::System.Convert.ToString);
            }
            if (content.Contains("MoveStatusErrorsPropertiesTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesTarget = (string) content.GetValueForProperty("MoveStatusErrorsPropertiesTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesTarget, global::System.Convert.ToString);
            }
            if (content.Contains("MoveStatusErrorsPropertiesDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody[]) content.GetValueForProperty("MoveStatusErrorsPropertiesDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MoveResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MoveStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceStatus) content.GetValueForProperty("MoveStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceId = (string) content.GetValueForProperty("SourceId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).TargetId, global::System.Convert.ToString);
            }
            if (content.Contains("ExistingTargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ExistingTargetId = (string) content.GetValueForProperty("ExistingTargetId",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ExistingTargetId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IResourceSettings) content.GetValueForProperty("ResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.ResourceSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceResourceSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceResourceSetting = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IResourceSettings) content.GetValueForProperty("SourceResourceSetting",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).SourceResourceSetting, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.ResourceSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DependsOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOn = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependency[]) content.GetValueForProperty("DependsOn",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependency>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceDependencyTypeConverter.ConvertFrom));
            }
            if (content.Contains("DependsOnOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOnOverride = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependencyOverride[]) content.GetValueForProperty("DependsOnOverride",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).DependsOnOverride, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceDependencyOverride>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceDependencyOverrideTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsResolveRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).IsResolveRequired = (bool?) content.GetValueForProperty("IsResolveRequired",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).IsResolveRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MoveStatusJobStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusJobStatus = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IJobStatus) content.GetValueForProperty("MoveStatusJobStatus",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusJobStatus, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.JobStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("MoveStatusMoveState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusMoveState = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState?) content.GetValueForProperty("MoveStatusMoveState",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusMoveState, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.MoveState.CreateFrom);
            }
            if (content.Contains("MoveStatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusError = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceError) content.GetValueForProperty("MoveStatusError",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusError, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobStatusJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobName = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName?) content.GetValueForProperty("JobStatusJobName",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobName, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Support.JobName.CreateFrom);
            }
            if (content.Contains("JobStatusJobProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobProgress = (string) content.GetValueForProperty("JobStatusJobProgress",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).JobStatusJobProgress, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody) content.GetValueForProperty("ErrorsProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            }
            if (content.Contains("MoveStatusErrorsProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsProperty = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody) content.GetValueForProperty("MoveStatusErrorsProperty",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsProperty, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ErrorsPropertiesCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesCode = (string) content.GetValueForProperty("ErrorsPropertiesCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesCode, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsPropertiesMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesMessage = (string) content.GetValueForProperty("ErrorsPropertiesMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesMessage, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsPropertiesTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesTarget = (string) content.GetValueForProperty("ErrorsPropertiesTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesTarget, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorsPropertiesDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody[]) content.GetValueForProperty("ErrorsPropertiesDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).ErrorsPropertiesDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            }
            if (content.Contains("MoveStatusErrorsPropertiesCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesCode = (string) content.GetValueForProperty("MoveStatusErrorsPropertiesCode",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesCode, global::System.Convert.ToString);
            }
            if (content.Contains("MoveStatusErrorsPropertiesMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesMessage = (string) content.GetValueForProperty("MoveStatusErrorsPropertiesMessage",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesMessage, global::System.Convert.ToString);
            }
            if (content.Contains("MoveStatusErrorsPropertiesTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesTarget = (string) content.GetValueForProperty("MoveStatusErrorsPropertiesTarget",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesTarget, global::System.Convert.ToString);
            }
            if (content.Contains("MoveStatusErrorsPropertiesDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesDetail = (Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody[]) content.GetValueForProperty("MoveStatusErrorsPropertiesDetail",((Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourcePropertiesInternal)this).MoveStatusErrorsPropertiesDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.IMoveResourceErrorBody>(__y, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801.MoveResourceErrorBodyTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Defines the move resource properties.
    [System.ComponentModel.TypeConverter(typeof(MoveResourcePropertiesTypeConverter))]
    public partial interface IMoveResourceProperties

    {

    }
}