// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Extensions;

    /// <summary>Quota change requests information.</summary>
    public partial class CreateGenericQuotaRequestParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ICreateGenericQuotaRequestParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ICreateGenericQuotaRequestParametersInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ICurrentQuotaLimitBase> _value;

        /// <summary>Quota change requests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ICurrentQuotaLimitBase> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="CreateGenericQuotaRequestParameters" /> instance.</summary>
        public CreateGenericQuotaRequestParameters()
        {

        }
    }
    /// Quota change requests information.
    public partial interface ICreateGenericQuotaRequestParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.IJsonSerializable
    {
        /// <summary>Quota change requests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Quota change requests.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ICurrentQuotaLimitBase) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ICurrentQuotaLimitBase> Value { get; set; }

    }
    /// Quota change requests information.
    internal partial interface ICreateGenericQuotaRequestParametersInternal

    {
        /// <summary>Quota change requests.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.ICurrentQuotaLimitBase> Value { get; set; }

    }
}