// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Secrets related to a Machine Learning compute based on AKS.</summary>
    public partial class VirtualMachineSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecrets,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeSecrets"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeSecrets __computeSecrets = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ComputeSecrets();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchema"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchema __virtualMachineSecretsSchema = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSecretsSchema();

        /// <summary>Admin credentials for virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentials AdministratorAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccount = value ?? null /* model class */; }

        /// <summary>Password of admin account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string AdministratorAccountPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountPassword = value ?? null; }

        /// <summary>Private key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string AdministratorAccountPrivateKeyData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountPrivateKeyData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountPrivateKeyData = value ?? null; }

        /// <summary>Public key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string AdministratorAccountPublicKeyData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountPublicKeyData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountPublicKeyData = value ?? null; }

        /// <summary>Username of admin account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string AdministratorAccountUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal)__virtualMachineSecretsSchema).AdministratorAccountUsername = value ?? null; }

        /// <summary>The type of compute</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType ComputeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeSecretsInternal)__computeSecrets).ComputeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeSecretsInternal)__computeSecrets).ComputeType = value ; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__computeSecrets), __computeSecrets);
            await eventListener.AssertObjectIsValid(nameof(__computeSecrets), __computeSecrets);
            await eventListener.AssertNotNull(nameof(__virtualMachineSecretsSchema), __virtualMachineSecretsSchema);
            await eventListener.AssertObjectIsValid(nameof(__virtualMachineSecretsSchema), __virtualMachineSecretsSchema);
        }

        /// <summary>Creates an new <see cref="VirtualMachineSecrets" /> instance.</summary>
        public VirtualMachineSecrets()
        {

        }
    }
    /// Secrets related to a Machine Learning compute based on AKS.
    public partial interface IVirtualMachineSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeSecrets,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchema
    {

    }
    /// Secrets related to a Machine Learning compute based on AKS.
    internal partial interface IVirtualMachineSecretsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeSecretsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal
    {

    }
}