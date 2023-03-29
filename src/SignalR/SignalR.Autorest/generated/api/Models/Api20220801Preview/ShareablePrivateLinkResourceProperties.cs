// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>
    /// Describes the properties of a resource type that has been onboarded to private link service
    /// </summary>
    public partial class ShareablePrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IShareablePrivateLinkResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IShareablePrivateLinkResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// The description of the resource type that has been onboarded to private link service
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>
        /// The resource provider group id for the resource that has been onboarded to private link service
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The resource provider type for the resource that has been onboarded to private link service
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ShareablePrivateLinkResourceProperties" /> instance.</summary>
        public ShareablePrivateLinkResourceProperties()
        {

        }
    }
    /// Describes the properties of a resource type that has been onboarded to private link service
    public partial interface IShareablePrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The description of the resource type that has been onboarded to private link service
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the resource type that has been onboarded to private link service",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// The resource provider group id for the resource that has been onboarded to private link service
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource provider group id for the resource that has been onboarded to private link service",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>
        /// The resource provider type for the resource that has been onboarded to private link service
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource provider type for the resource that has been onboarded to private link service",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Describes the properties of a resource type that has been onboarded to private link service
    internal partial interface IShareablePrivateLinkResourcePropertiesInternal

    {
        /// <summary>
        /// The description of the resource type that has been onboarded to private link service
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// The resource provider group id for the resource that has been onboarded to private link service
        /// </summary>
        string GroupId { get; set; }
        /// <summary>
        /// The resource provider type for the resource that has been onboarded to private link service
        /// </summary>
        string Type { get; set; }

    }
}