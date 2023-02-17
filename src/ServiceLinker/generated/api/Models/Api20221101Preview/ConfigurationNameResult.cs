// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Extensions;

    /// <summary>
    /// Configuration Name list which will be set based on different target resource, client type, auth type.
    /// </summary>
    public partial class ConfigurationNameResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameItem[] _value;

        /// <summary>Expected configuration names for each target service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameItem[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ConfigurationNameResult" /> instance.</summary>
        public ConfigurationNameResult()
        {

        }
    }
    /// Configuration Name list which will be set based on different target resource, client type, auth type.
    public partial interface IConfigurationNameResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IJsonSerializable
    {
        /// <summary>Link to next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to next page of resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Expected configuration names for each target service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expected configuration names for each target service.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameItem[] Value { get; set; }

    }
    /// Configuration Name list which will be set based on different target resource, client type, auth type.
    internal partial interface IConfigurationNameResultInternal

    {
        /// <summary>Link to next page of resources.</summary>
        string NextLink { get; set; }
        /// <summary>Expected configuration names for each target service.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationNameItem[] Value { get; set; }

    }
}