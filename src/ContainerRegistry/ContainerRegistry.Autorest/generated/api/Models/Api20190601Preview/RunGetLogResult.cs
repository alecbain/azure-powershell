// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The result of get log link operation.</summary>
    public partial class RunGetLogResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunGetLogResult,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunGetLogResultInternal
    {

        /// <summary>Backing field for <see cref="LogArtifactLink" /> property.</summary>
        private string _logArtifactLink;

        /// <summary>The link to logs in registry for a run on a azure container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string LogArtifactLink { get => this._logArtifactLink; set => this._logArtifactLink = value; }

        /// <summary>Backing field for <see cref="LogLink" /> property.</summary>
        private string _logLink;

        /// <summary>The link to logs for a run on a azure container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string LogLink { get => this._logLink; set => this._logLink = value; }

        /// <summary>Creates an new <see cref="RunGetLogResult" /> instance.</summary>
        public RunGetLogResult()
        {

        }
    }
    /// The result of get log link operation.
    public partial interface IRunGetLogResult :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The link to logs in registry for a run on a azure container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to logs in registry for a run on a azure container registry.",
        SerializedName = @"logArtifactLink",
        PossibleTypes = new [] { typeof(string) })]
        string LogArtifactLink { get; set; }
        /// <summary>The link to logs for a run on a azure container registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to logs for a run on a azure container registry.",
        SerializedName = @"logLink",
        PossibleTypes = new [] { typeof(string) })]
        string LogLink { get; set; }

    }
    /// The result of get log link operation.
    internal partial interface IRunGetLogResultInternal

    {
        /// <summary>The link to logs in registry for a run on a azure container registry.</summary>
        string LogArtifactLink { get; set; }
        /// <summary>The link to logs for a run on a azure container registry.</summary>
        string LogLink { get; set; }

    }
}