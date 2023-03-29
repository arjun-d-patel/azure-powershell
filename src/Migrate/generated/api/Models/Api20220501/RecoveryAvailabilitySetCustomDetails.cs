// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery Availability Set custom input.</summary>
    public partial class RecoveryAvailabilitySetCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryAvailabilitySetCustomDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryAvailabilitySetCustomDetailsInternal
    {

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Creates an new <see cref="RecoveryAvailabilitySetCustomDetails" /> instance.</summary>
        public RecoveryAvailabilitySetCustomDetails()
        {

        }
    }
    /// Recovery Availability Set custom input.
    public partial interface IRecoveryAvailabilitySetCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }

    }
    /// Recovery Availability Set custom input.
    internal partial interface IRecoveryAvailabilitySetCustomDetailsInternal

    {
        /// <summary>The class type.</summary>
        string ResourceType { get; set; }

    }
}