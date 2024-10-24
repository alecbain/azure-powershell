// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Function app resource requirements.</summary>
    public partial class ResourceConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceConfig,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceConfigInternal
    {

        /// <summary>Backing field for <see cref="Cpu" /> property.</summary>
        private double? _cpu;

        /// <summary>Required CPU in cores, e.g. 0.5</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public double? Cpu { get => this._cpu; set => this._cpu = value; }

        /// <summary>Backing field for <see cref="Memory" /> property.</summary>
        private string _memory;

        /// <summary>Required memory, e.g. "1Gi"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string Memory { get => this._memory; set => this._memory = value; }

        /// <summary>Creates an new <see cref="ResourceConfig" /> instance.</summary>
        public ResourceConfig()
        {

        }
    }
    /// Function app resource requirements.
    public partial interface IResourceConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Required CPU in cores, e.g. 0.5</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required CPU in cores, e.g. 0.5",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(double) })]
        double? Cpu { get; set; }
        /// <summary>Required memory, e.g. "1Gi"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Required memory, e.g. ""1Gi""",
        SerializedName = @"memory",
        PossibleTypes = new [] { typeof(string) })]
        string Memory { get; set; }

    }
    /// Function app resource requirements.
    internal partial interface IResourceConfigInternal

    {
        /// <summary>Required CPU in cores, e.g. 0.5</summary>
        double? Cpu { get; set; }
        /// <summary>Required memory, e.g. "1Gi"</summary>
        string Memory { get; set; }

    }
}