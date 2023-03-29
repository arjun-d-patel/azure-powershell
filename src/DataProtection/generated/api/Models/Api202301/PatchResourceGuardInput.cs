// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Patch Request content for Microsoft.DataProtection Resource Guard resources</summary>
    public partial class PatchResourceGuardInput :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IPatchResourceGuardInput,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IPatchResourceGuardInputInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IPatchResourceGuardInputTags _tag;

        /// <summary>Resource Guard tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IPatchResourceGuardInputTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.PatchResourceGuardInputTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="PatchResourceGuardInput" /> instance.</summary>
        public PatchResourceGuardInput()
        {

        }
    }
    /// Patch Request content for Microsoft.DataProtection Resource Guard resources
    public partial interface IPatchResourceGuardInput :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Resource Guard tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Guard tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IPatchResourceGuardInputTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IPatchResourceGuardInputTags Tag { get; set; }

    }
    /// Patch Request content for Microsoft.DataProtection Resource Guard resources
    internal partial interface IPatchResourceGuardInputInternal

    {
        /// <summary>Resource Guard tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IPatchResourceGuardInputTags Tag { get; set; }

    }
}