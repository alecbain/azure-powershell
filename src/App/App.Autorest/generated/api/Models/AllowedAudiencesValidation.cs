// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>The configuration settings of the Allowed Audiences validation flow.</summary>
    public partial class AllowedAudiencesValidation :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAllowedAudiencesValidation,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAllowedAudiencesValidationInternal
    {

        /// <summary>Backing field for <see cref="AllowedAudience" /> property.</summary>
        private System.Collections.Generic.List<string> _allowedAudience;

        /// <summary>
        /// The configuration settings of the allowed list of audiences from which to validate the JWT token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AllowedAudience { get => this._allowedAudience; set => this._allowedAudience = value; }

        /// <summary>Creates an new <see cref="AllowedAudiencesValidation" /> instance.</summary>
        public AllowedAudiencesValidation()
        {

        }
    }
    /// The configuration settings of the Allowed Audiences validation flow.
    public partial interface IAllowedAudiencesValidation :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The configuration settings of the allowed list of audiences from which to validate the JWT token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The configuration settings of the allowed list of audiences from which to validate the JWT token.",
        SerializedName = @"allowedAudiences",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AllowedAudience { get; set; }

    }
    /// The configuration settings of the Allowed Audiences validation flow.
    internal partial interface IAllowedAudiencesValidationInternal

    {
        /// <summary>
        /// The configuration settings of the allowed list of audiences from which to validate the JWT token.
        /// </summary>
        System.Collections.Generic.List<string> AllowedAudience { get; set; }

    }
}