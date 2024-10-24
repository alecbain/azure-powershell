// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>This is the disk image base class.</summary>
    public partial class GalleryDiskImage :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryDiskImage,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryDiskImageInternal
    {

        /// <summary>Internal Acessors for SizeInMb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IGalleryDiskImageInternal.SizeInMb { get => this._sizeInMb; set { {_sizeInMb = value;} } }

        /// <summary>Backing field for <see cref="SizeInMb" /> property.</summary>
        private long? _sizeInMb;

        /// <summary>This property indicates the size of the VHD to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public long? SizeInMb { get => this._sizeInMb; }

        /// <summary>Creates an new <see cref="GalleryDiskImage" /> instance.</summary>
        public GalleryDiskImage()
        {

        }
    }
    /// This is the disk image base class.
    public partial interface IGalleryDiskImage :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
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
        long? SizeInMb { get;  }

    }
    /// This is the disk image base class.
    internal partial interface IGalleryDiskImageInternal

    {
        /// <summary>This property indicates the size of the VHD to be created.</summary>
        long? SizeInMb { get; set; }

    }
}