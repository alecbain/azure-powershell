// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>
    /// List of validator error details. Populated when changes are made to the resource or its dependent resources that impact
    /// the validity of the Catalog resource.
    /// </summary>
    public partial class CatalogResourceValidationErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogResourceValidationErrorDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogResourceValidationErrorDetailsInternal
    {

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogErrorDetails[] _error;

        /// <summary>Errors associated with resources synchronized from the catalog.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogErrorDetails[] Error { get => this._error; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogErrorDetails[] Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogResourceValidationErrorDetailsInternal.Error { get => this._error; set { {_error = value;} } }

        /// <summary>Creates an new <see cref="CatalogResourceValidationErrorDetails" /> instance.</summary>
        public CatalogResourceValidationErrorDetails()
        {

        }
    }
    /// List of validator error details. Populated when changes are made to the resource or its dependent resources that impact
    /// the validity of the Catalog resource.
    public partial interface ICatalogResourceValidationErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>Errors associated with resources synchronized from the catalog.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Errors associated with resources synchronized from the catalog.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogErrorDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogErrorDetails[] Error { get;  }

    }
    /// List of validator error details. Populated when changes are made to the resource or its dependent resources that impact
    /// the validity of the Catalog resource.
    internal partial interface ICatalogResourceValidationErrorDetailsInternal

    {
        /// <summary>Errors associated with resources synchronized from the catalog.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.ICatalogErrorDetails[] Error { get; set; }

    }
}