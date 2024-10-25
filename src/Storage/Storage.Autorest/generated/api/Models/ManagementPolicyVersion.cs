// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Extensions;

    /// <summary>Management policy action for blob version.</summary>
    public partial class ManagementPolicyVersion :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IManagementPolicyVersion,
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IManagementPolicyVersionInternal
    {

        /// <summary>Backing field for <see cref="Delete" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation _delete;

        /// <summary>The function to delete the blob version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation Delete { get => (this._delete = this._delete ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set => this._delete = value; }

        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? DeleteDaysAfterCreationGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)Delete).DaysAfterCreationGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)Delete).DaysAfterCreationGreaterThan = value ?? default(float); }

        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? DeleteDaysAfterLastTierChangeGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)Delete).DaysAfterLastTierChangeGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)Delete).DaysAfterLastTierChangeGreaterThan = value ?? default(float); }

        /// <summary>Internal Acessors for Delete</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IManagementPolicyVersionInternal.Delete { get => (this._delete = this._delete ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set { {_delete = value;} } }

        /// <summary>Internal Acessors for TierToArchive</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IManagementPolicyVersionInternal.TierToArchive { get => (this._tierToArchive = this._tierToArchive ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set { {_tierToArchive = value;} } }

        /// <summary>Internal Acessors for TierToCold</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IManagementPolicyVersionInternal.TierToCold { get => (this._tierToCold = this._tierToCold ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set { {_tierToCold = value;} } }

        /// <summary>Internal Acessors for TierToCool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IManagementPolicyVersionInternal.TierToCool { get => (this._tierToCool = this._tierToCool ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set { {_tierToCool = value;} } }

        /// <summary>Internal Acessors for TierToHot</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IManagementPolicyVersionInternal.TierToHot { get => (this._tierToHot = this._tierToHot ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set { {_tierToHot = value;} } }

        /// <summary>Backing field for <see cref="TierToArchive" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation _tierToArchive;

        /// <summary>The function to tier blob version to archive storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToArchive { get => (this._tierToArchive = this._tierToArchive ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set => this._tierToArchive = value; }

        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToArchiveDaysAfterCreationGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToArchive).DaysAfterCreationGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToArchive).DaysAfterCreationGreaterThan = value ?? default(float); }

        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToArchiveDaysAfterLastTierChangeGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToArchive).DaysAfterLastTierChangeGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToArchive).DaysAfterLastTierChangeGreaterThan = value ?? default(float); }

        /// <summary>Backing field for <see cref="TierToCold" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation _tierToCold;

        /// <summary>The function to tier blobs to cold storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToCold { get => (this._tierToCold = this._tierToCold ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set => this._tierToCold = value; }

        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToColdDaysAfterCreationGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCold).DaysAfterCreationGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCold).DaysAfterCreationGreaterThan = value ?? default(float); }

        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToColdDaysAfterLastTierChangeGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCold).DaysAfterLastTierChangeGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCold).DaysAfterLastTierChangeGreaterThan = value ?? default(float); }

        /// <summary>Backing field for <see cref="TierToCool" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation _tierToCool;

        /// <summary>The function to tier blob version to cool storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToCool { get => (this._tierToCool = this._tierToCool ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set => this._tierToCool = value; }

        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToCoolDaysAfterCreationGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCool).DaysAfterCreationGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCool).DaysAfterCreationGreaterThan = value ?? default(float); }

        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToCoolDaysAfterLastTierChangeGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCool).DaysAfterLastTierChangeGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToCool).DaysAfterLastTierChangeGreaterThan = value ?? default(float); }

        /// <summary>Backing field for <see cref="TierToHot" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation _tierToHot;

        /// <summary>
        /// The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage Accounts
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToHot { get => (this._tierToHot = this._tierToHot ?? new Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.DateAfterCreation()); set => this._tierToHot = value; }

        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToHotDaysAfterCreationGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToHot).DaysAfterCreationGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToHot).DaysAfterCreationGreaterThan = value ?? default(float); }

        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Inlined)]
        public float? TierToHotDaysAfterLastTierChangeGreaterThan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToHot).DaysAfterLastTierChangeGreaterThan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreationInternal)TierToHot).DaysAfterLastTierChangeGreaterThan = value ?? default(float); }

        /// <summary>Creates an new <see cref="ManagementPolicyVersion" /> instance.</summary>
        public ManagementPolicyVersion()
        {

        }
    }
    /// Management policy action for blob version.
    public partial interface IManagementPolicyVersion :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.IJsonSerializable
    {
        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after creation",
        SerializedName = @"daysAfterCreationGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? DeleteDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will be archived if both the conditions are satisfied.",
        SerializedName = @"daysAfterLastTierChangeGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? DeleteDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after creation",
        SerializedName = @"daysAfterCreationGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToArchiveDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will be archived if both the conditions are satisfied.",
        SerializedName = @"daysAfterLastTierChangeGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToArchiveDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after creation",
        SerializedName = @"daysAfterCreationGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToColdDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will be archived if both the conditions are satisfied.",
        SerializedName = @"daysAfterLastTierChangeGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToColdDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after creation",
        SerializedName = @"daysAfterCreationGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToCoolDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will be archived if both the conditions are satisfied.",
        SerializedName = @"daysAfterLastTierChangeGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToCoolDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after creation",
        SerializedName = @"daysAfterCreationGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToHotDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will be archived if both the conditions are satisfied.",
        SerializedName = @"daysAfterLastTierChangeGreaterThan",
        PossibleTypes = new [] { typeof(float) })]
        float? TierToHotDaysAfterLastTierChangeGreaterThan { get; set; }

    }
    /// Management policy action for blob version.
    internal partial interface IManagementPolicyVersionInternal

    {
        /// <summary>The function to delete the blob version</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation Delete { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        float? DeleteDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        float? DeleteDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>The function to tier blob version to archive storage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToArchive { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        float? TierToArchiveDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        float? TierToArchiveDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>The function to tier blobs to cold storage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToCold { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        float? TierToColdDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        float? TierToColdDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>The function to tier blob version to cool storage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToCool { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        float? TierToCoolDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        float? TierToCoolDaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary>
        /// The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage Accounts
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IDateAfterCreation TierToHot { get; set; }
        /// <summary>Value indicating the age in days after creation</summary>
        float? TierToHotDaysAfterCreationGreaterThan { get; set; }
        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive
        /// actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will
        /// be archived if both the conditions are satisfied.
        /// </summary>
        float? TierToHotDaysAfterLastTierChangeGreaterThan { get; set; }

    }
}