// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery plan action custom details.</summary>
    public partial class RecoveryPlanActionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPlanActionDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IRecoveryPlanActionDetailsInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>
        /// Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="RecoveryPlanActionDetails" /> instance.</summary>
        public RecoveryPlanActionDetails()
        {

        }
    }
    /// Recovery plan action custom details.
    public partial interface IRecoveryPlanActionDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values).",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Recovery plan action custom details.
    internal partial interface IRecoveryPlanActionDetailsInternal

    {
        /// <summary>
        /// Gets the type of action details (see RecoveryPlanActionDetailsTypes enum for possible values).
        /// </summary>
        string InstanceType { get; set; }

    }
}