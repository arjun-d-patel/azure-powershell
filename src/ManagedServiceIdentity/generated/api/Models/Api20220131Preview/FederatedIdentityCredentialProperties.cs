// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Extensions;

    /// <summary>The properties associated with a federated identity credential.</summary>
    public partial class FederatedIdentityCredentialProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Audience" /> property.</summary>
        private string[] _audience;

        /// <summary>The list of audiences that can appear in the issued token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Owned)]
        public string[] Audience { get => this._audience; set => this._audience = value; }

        /// <summary>Backing field for <see cref="Issuer" /> property.</summary>
        private string _issuer;

        /// <summary>The URL of the issuer to be trusted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Owned)]
        public string Issuer { get => this._issuer; set => this._issuer = value; }

        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        /// <summary>The identifier of the external identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Owned)]
        public string Subject { get => this._subject; set => this._subject = value; }

        /// <summary>Creates an new <see cref="FederatedIdentityCredentialProperties" /> instance.</summary>
        public FederatedIdentityCredentialProperties()
        {

        }
    }
    /// The properties associated with a federated identity credential.
    public partial interface IFederatedIdentityCredentialProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IJsonSerializable
    {
        /// <summary>The list of audiences that can appear in the issued token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The list of audiences that can appear in the issued token.",
        SerializedName = @"audiences",
        PossibleTypes = new [] { typeof(string) })]
        string[] Audience { get; set; }
        /// <summary>The URL of the issuer to be trusted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The URL of the issuer to be trusted.",
        SerializedName = @"issuer",
        PossibleTypes = new [] { typeof(string) })]
        string Issuer { get; set; }
        /// <summary>The identifier of the external identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The identifier of the external identity.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get; set; }

    }
    /// The properties associated with a federated identity credential.
    internal partial interface IFederatedIdentityCredentialPropertiesInternal

    {
        /// <summary>The list of audiences that can appear in the issued token.</summary>
        string[] Audience { get; set; }
        /// <summary>The URL of the issuer to be trusted.</summary>
        string Issuer { get; set; }
        /// <summary>The identifier of the external identity.</summary>
        string Subject { get; set; }

    }
}