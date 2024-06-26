// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Reservation order alias</summary>
    public partial class ReservationOrderAliasRequest :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequest,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.Resource();

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyDisplayName = value ?? null; }

        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyManagementGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyManagementGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyManagementGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyResourceGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertySubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertySubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertySubscriptionId = value ?? null; }

        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopePropertyTenantId = value ?? null; }

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopeType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType)""); }

        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).BillingPlan; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).BillingPlan = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan)""); }

        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string BillingScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).BillingScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).BillingScopeId = value ?? null; }

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The Azure Region where the reservation benefits are applied to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for AppliedScopeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestInternal.AppliedScopeProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopeProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).AppliedScopeProperty = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ReservationOrderAliasRequestProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReservedResourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesReservedResourceProperties Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestInternal.ReservedResourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReservedResourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReservedResourceProperty = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestProperties _property;

        /// <summary>Reservation order alias request properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ReservationOrderAliasRequestProperties()); set => this._property = value; }

        /// <summary>Total Quantity of the SKUs purchased in the Reservation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public int? Quantity { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).Quantity; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).Quantity = value ?? default(int); }

        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public bool? Renew { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).Renew; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).Renew = value ?? default(bool); }

        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.InstanceFlexibility? ReservedResourcePropertyInstanceFlexibility { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReservedResourcePropertyInstanceFlexibility; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReservedResourcePropertyInstanceFlexibility = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.InstanceFlexibility)""); }

        /// <summary>The type of the resource that is being reserved.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ReservedResourceType? ReservedResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReservedResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReservedResourceType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ReservedResourceType)""); }

        /// <summary>This is the date-time when the Azure Hybrid Benefit needs to be reviewed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public global::System.DateTime? ReviewDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReviewDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).ReviewDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku _sku;

        /// <summary>Reservation order SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.Sku()); set => this._sku = value; }

        /// <summary>Name of the SKU to be applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.CreatedByType)""); }

        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).Term; set => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesInternal)Property).Term = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ReservationOrderAliasRequest" /> instance.</summary>
        public ReservationOrderAliasRequest()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Reservation order alias
    public partial interface IReservationOrderAliasRequest :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResource
    {
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the management group where the benefit must be applied.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the resource group.",
        SerializedName = @"resourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant ID where the benefit is applied.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.",
        SerializedName = @"billingPlan",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription that will be charged for purchasing the benefit",
        SerializedName = @"billingScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingScopeId { get; set; }
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The Azure Region where the reservation benefits are applied to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure Region where the reservation benefits are applied to.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Total Quantity of the SKUs purchased in the Reservation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total Quantity of the SKUs purchased in the Reservation.",
        SerializedName = @"quantity",
        PossibleTypes = new [] { typeof(int) })]
        int? Quantity { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Setting this to true will automatically purchase a new benefit on the expiration date time.",
        SerializedName = @"renew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Renew { get; set; }
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Turning this on will apply the reservation discount to other VMs in the same VM size group.",
        SerializedName = @"instanceFlexibility",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.InstanceFlexibility) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.InstanceFlexibility? ReservedResourcePropertyInstanceFlexibility { get; set; }
        /// <summary>The type of the resource that is being reserved.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the resource that is being reserved.",
        SerializedName = @"reservedResourceType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ReservedResourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ReservedResourceType? ReservedResourceType { get; set; }
        /// <summary>This is the date-time when the Azure Hybrid Benefit needs to be reviewed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This is the date-time when the Azure Hybrid Benefit needs to be reviewed.",
        SerializedName = @"reviewDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ReviewDateTime { get; set; }
        /// <summary>Name of the SKU to be applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the SKU to be applied",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represent benefit term in ISO 8601 format.",
        SerializedName = @"term",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
    /// Reservation order alias
    internal partial interface IReservationOrderAliasRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api30.IResourceInternal
    {
        /// <summary>Properties specific to applied scope type. Not required if not applicable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get; set; }
        /// <summary>Display name</summary>
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the benefit is applied.</summary>
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing the benefit</summary>
        string BillingScopeId { get; set; }
        /// <summary>Display name</summary>
        string DisplayName { get; set; }
        /// <summary>The Azure Region where the reservation benefits are applied to.</summary>
        string Location { get; set; }
        /// <summary>Reservation order alias request properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestProperties Property { get; set; }
        /// <summary>Total Quantity of the SKUs purchased in the Reservation.</summary>
        int? Quantity { get; set; }
        /// <summary>
        /// Setting this to true will automatically purchase a new benefit on the expiration date time.
        /// </summary>
        bool? Renew { get; set; }
        /// <summary>
        /// Properties specific to each reserved resource type. Not required if not applicable.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IReservationOrderAliasRequestPropertiesReservedResourceProperties ReservedResourceProperty { get; set; }
        /// <summary>
        /// Turning this on will apply the reservation discount to other VMs in the same VM size group.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.InstanceFlexibility? ReservedResourcePropertyInstanceFlexibility { get; set; }
        /// <summary>The type of the resource that is being reserved.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ReservedResourceType? ReservedResourceType { get; set; }
        /// <summary>This is the date-time when the Azure Hybrid Benefit needs to be reviewed.</summary>
        global::System.DateTime? ReviewDateTime { get; set; }
        /// <summary>Reservation order SKU</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISku Sku { get; set; }
        /// <summary>Name of the SKU to be applied</summary>
        string SkuName { get; set; }
        /// <summary>Represent benefit term in ISO 8601 format.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term? Term { get; set; }

    }
}