// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Properties of the PrivateEndpointConnectProperties.</summary>
    public partial class PrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal
    {

        /// <summary>
        /// Application security groups in which the private endpoint IP configuration is included.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[] ApplicationSecurityGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ApplicationSecurityGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ApplicationSecurityGroup = value ?? null /* arrayOf */; }

        /// <summary>An array of custom dns configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat[] CustomDnsConfig { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).CustomDnsConfig; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).CustomDnsConfig = value ?? null /* arrayOf */; }

        /// <summary>The custom name of the network interface attached to the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string CustomNetworkInterfaceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).CustomNetworkInterfaceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).CustomNetworkInterfaceName = value ?? null; }

        /// <summary>The name of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string ExtendedLocationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ExtendedLocationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ExtendedLocationName = value ?? null; }

        /// <summary>The type of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes? ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ExtendedLocationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ExtendedLocationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes)""); }

        /// <summary>
        /// A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration[] IPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).IPConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).IPConfiguration = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="LinkIdentifier" /> property.</summary>
        private string _linkIdentifier;

        /// <summary>The consumer link id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string LinkIdentifier { get => this._linkIdentifier; }

        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access
        /// to approve connections to the remote resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] ManualPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ManualPrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ManualPrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LinkIdentifier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.LinkIdentifier { get => this._linkIdentifier; set { {_linkIdentifier = value;} } }

        /// <summary>Internal Acessors for NetworkInterface</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.NetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).NetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).NetworkInterface = value; }

        /// <summary>Internal Acessors for PrivateEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpoint Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateEndpoint()); set { {_privateEndpoint = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointEtag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointEtag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).Etag = value; }

        /// <summary>Internal Acessors for PrivateEndpointExtendedLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocation Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointExtendedLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ExtendedLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ExtendedLocation = value; }

        /// <summary>Internal Acessors for PrivateEndpointName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Name = value; }

        /// <summary>Internal Acessors for PrivateEndpointPropertiesProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointPropertiesProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ProvisioningState = value; }

        /// <summary>Internal Acessors for PrivateEndpointProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointProperties Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).Property = value; }

        /// <summary>Internal Acessors for PrivateEndpointType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateEndpointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Type = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateLinkServiceConnectionState()); set { {_privateLinkServiceConnectionState = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>
        /// An array of references to the network interfaces created for this private endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] NetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).NetworkInterface; }

        /// <summary>Backing field for <see cref="PrivateEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpoint _privateEndpoint;

        /// <summary>The resource of private end point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpoint PrivateEndpoint { get => (this._privateEndpoint = this._privateEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateEndpoint()); }

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateEndpointEtag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).Etag; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateEndpointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Id = value ?? null; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateEndpointLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Location = value ?? null; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateEndpointName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Name; }

        /// <summary>The provisioning state of the private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? PrivateEndpointPropertiesProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).ProvisioningState; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceTags PrivateEndpointTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Tag = value ?? null /* model class */; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateEndpointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)PrivateEndpoint).Type; }

        /// <summary>A grouping of information about the connection to the remote resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] PrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).PrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).PrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceConnectionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionState _privateLinkServiceConnectionState;

        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateLinkServiceConnectionState()); set => this._privateLinkServiceConnectionState = value; }

        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired = value ?? null; }

        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description = value ?? null; }

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>The ID of the subnet from which the private IP will be allocated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal)PrivateEndpoint).Subnet = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionProperties" /> instance.</summary>
        public PrivateEndpointConnectionProperties()
        {

        }
    }
    /// Properties of the PrivateEndpointConnectProperties.
    public partial interface IPrivateEndpointConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Application security groups in which the private endpoint IP configuration is included.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application security groups in which the private endpoint IP configuration is included.",
        SerializedName = @"applicationSecurityGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[] ApplicationSecurityGroup { get; set; }
        /// <summary>An array of custom dns configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of custom dns configurations.",
        SerializedName = @"customDnsConfigs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat[] CustomDnsConfig { get; set; }
        /// <summary>The custom name of the network interface attached to the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The custom name of the network interface attached to the private endpoint.",
        SerializedName = @"customNetworkInterfaceName",
        PossibleTypes = new [] { typeof(string) })]
        string CustomNetworkInterfaceName { get; set; }
        /// <summary>The name of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the extended location.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationName { get; set; }
        /// <summary>The type of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the extended location.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes? ExtendedLocationType { get; set; }
        /// <summary>
        /// A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.",
        SerializedName = @"ipConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration[] IPConfiguration { get; set; }
        /// <summary>The consumer link id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The consumer link id.",
        SerializedName = @"linkIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string LinkIdentifier { get;  }
        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access
        /// to approve connections to the remote resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource.",
        SerializedName = @"manualPrivateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] ManualPrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// An array of references to the network interfaces created for this private endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to the network interfaces created for this private endpoint.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] NetworkInterface { get;  }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointEtag { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointId { get; set; }
        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointLocation { get; set; }
        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointName { get;  }
        /// <summary>The provisioning state of the private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the private endpoint resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? PrivateEndpointPropertiesProvisioningState { get;  }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceTags PrivateEndpointTag { get; set; }
        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointType { get;  }
        /// <summary>A grouping of information about the connection to the remote resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A grouping of information about the connection to the remote resource.",
        SerializedName = @"privateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] PrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message indicating if changes on the service provider require any updates on the consumer.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason for approval/rejection of the connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the private endpoint connection resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The ID of the subnet from which the private IP will be allocated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the subnet from which the private IP will be allocated.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet Subnet { get; set; }

    }
    /// Properties of the PrivateEndpointConnectProperties.
    internal partial interface IPrivateEndpointConnectionPropertiesInternal

    {
        /// <summary>
        /// Application security groups in which the private endpoint IP configuration is included.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[] ApplicationSecurityGroup { get; set; }
        /// <summary>An array of custom dns configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat[] CustomDnsConfig { get; set; }
        /// <summary>The custom name of the network interface attached to the private endpoint.</summary>
        string CustomNetworkInterfaceName { get; set; }
        /// <summary>The name of the extended location.</summary>
        string ExtendedLocationName { get; set; }
        /// <summary>The type of the extended location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes? ExtendedLocationType { get; set; }
        /// <summary>
        /// A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration[] IPConfiguration { get; set; }
        /// <summary>The consumer link id.</summary>
        string LinkIdentifier { get; set; }
        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access
        /// to approve connections to the remote resource.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] ManualPrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// An array of references to the network interfaces created for this private endpoint.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] NetworkInterface { get; set; }
        /// <summary>The resource of private end point.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string PrivateEndpointEtag { get; set; }
        /// <summary>The extended location of the load balancer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocation PrivateEndpointExtendedLocation { get; set; }
        /// <summary>Resource ID.</summary>
        string PrivateEndpointId { get; set; }
        /// <summary>Resource location.</summary>
        string PrivateEndpointLocation { get; set; }
        /// <summary>Resource name.</summary>
        string PrivateEndpointName { get; set; }
        /// <summary>The provisioning state of the private endpoint resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? PrivateEndpointPropertiesProvisioningState { get; set; }
        /// <summary>Properties of the private endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointProperties PrivateEndpointProperty { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceTags PrivateEndpointTag { get; set; }
        /// <summary>Resource type.</summary>
        string PrivateEndpointType { get; set; }
        /// <summary>A grouping of information about the connection to the remote resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] PrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The provisioning state of the private endpoint connection resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The ID of the subnet from which the private IP will be allocated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet Subnet { get; set; }

    }
}