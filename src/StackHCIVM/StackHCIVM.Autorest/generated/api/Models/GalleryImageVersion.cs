// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>
    /// Specifies information about the gallery image version that you want to create or update.
    /// </summary>
    public partial class GalleryImageVersion :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersion,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionInternal
    {

        /// <summary>Internal Acessors for OSDiskImageSizeInMb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionInternal.OSDiskImageSizeInMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionPropertiesInternal)Property).OSDiskImageSizeInMb; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionPropertiesInternal)Property).OSDiskImageSizeInMb = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionProperties Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.GalleryImageVersionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for StorageProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionStorageProfile Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionInternal.StorageProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionPropertiesInternal)Property).StorageProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionPropertiesInternal)Property).StorageProfile = value; }

        /// <summary>Internal Acessors for StorageProfileOSDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryOSDiskImage Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionInternal.StorageProfileOSDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionPropertiesInternal)Property).StorageProfileOSDiskImage; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionPropertiesInternal)Property).StorageProfileOSDiskImage = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>This is the version of the gallery image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>This property indicates the size of the VHD to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Inlined)]
        public long? OSDiskImageSizeInMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionPropertiesInternal)Property).OSDiskImageSizeInMb; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionProperties _property;

        /// <summary>Describes the properties of a gallery image version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.GalleryImageVersionProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="GalleryImageVersion" /> instance.</summary>
        public GalleryImageVersion()
        {

        }
    }
    /// Specifies information about the gallery image version that you want to create or update.
    public partial interface IGalleryImageVersion :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
        /// <summary>This is the version of the gallery image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This is the version of the gallery image.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>This property indicates the size of the VHD to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"This property indicates the size of the VHD to be created.",
        SerializedName = @"sizeInMB",
        PossibleTypes = new [] { typeof(long) })]
        long? OSDiskImageSizeInMb { get;  }

    }
    /// Specifies information about the gallery image version that you want to create or update.
    internal partial interface IGalleryImageVersionInternal

    {
        /// <summary>This is the version of the gallery image.</summary>
        string Name { get; set; }
        /// <summary>This property indicates the size of the VHD to be created.</summary>
        long? OSDiskImageSizeInMb { get; set; }
        /// <summary>Describes the properties of a gallery image version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionProperties Property { get; set; }
        /// <summary>This is the storage profile of a Gallery Image Version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryImageVersionStorageProfile StorageProfile { get; set; }
        /// <summary>This is the OS disk image.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryOSDiskImage StorageProfileOSDiskImage { get; set; }

    }
}