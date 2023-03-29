// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Replication provider specific settings.</summary>
    public partial class ReplicationProviderSpecificSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IReplicationProviderSpecificSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IReplicationProviderSpecificSettingsInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="ReplicationProviderSpecificSettings" /> instance.</summary>
        public ReplicationProviderSpecificSettings()
        {

        }
    }
    /// Replication provider specific settings.
    public partial interface IReplicationProviderSpecificSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Gets the Instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets the Instance type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Replication provider specific settings.
    internal partial interface IReplicationProviderSpecificSettingsInternal

    {
        /// <summary>Gets the Instance type.</summary>
        string InstanceType { get; set; }

    }
}