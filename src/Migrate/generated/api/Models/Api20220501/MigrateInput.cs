// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input for migrate.</summary>
    public partial class MigrateInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.MigrateInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputProperties _property;

        /// <summary>Migrate input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.MigrateInputProperties()); set => this._property = value; }

        /// <summary>The provider specific details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateProviderSpecificInput ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputPropertiesInternal)Property).ProviderSpecificDetail = value ; }

        /// <summary>Creates an new <see cref="MigrateInput" /> instance.</summary>
        public MigrateInput()
        {

        }
    }
    /// Input for migrate.
    public partial interface IMigrateInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The provider specific details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The provider specific details.",
        SerializedName = @"providerSpecificDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateProviderSpecificInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateProviderSpecificInput ProviderSpecificDetail { get; set; }

    }
    /// Input for migrate.
    internal partial interface IMigrateInputInternal

    {
        /// <summary>Migrate input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateInputProperties Property { get; set; }
        /// <summary>The provider specific details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IMigrateProviderSpecificInput ProviderSpecificDetail { get; set; }

    }
}