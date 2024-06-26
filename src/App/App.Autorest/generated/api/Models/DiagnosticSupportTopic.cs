// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Support topic information</summary>
    public partial class DiagnosticSupportTopic :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticSupportTopic,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticSupportTopicInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Unique topic identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticSupportTopicInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for PesId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticSupportTopicInternal.PesId { get => this._pesId; set { {_pesId = value;} } }

        /// <summary>Backing field for <see cref="PesId" /> property.</summary>
        private string _pesId;

        /// <summary>PES identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string PesId { get => this._pesId; }

        /// <summary>Creates an new <see cref="DiagnosticSupportTopic" /> instance.</summary>
        public DiagnosticSupportTopic()
        {

        }
    }
    /// Support topic information
    public partial interface IDiagnosticSupportTopic :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Unique topic identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique topic identifier",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>PES identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"PES identifier",
        SerializedName = @"pesId",
        PossibleTypes = new [] { typeof(string) })]
        string PesId { get;  }

    }
    /// Support topic information
    internal partial interface IDiagnosticSupportTopicInternal

    {
        /// <summary>Unique topic identifier</summary>
        string Id { get; set; }
        /// <summary>PES identifier</summary>
        string PesId { get; set; }

    }
}