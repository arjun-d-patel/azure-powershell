// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The paginated list of peering registered prefixes.</summary>
    public partial class PeeringRegisteredPrefixListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringRegisteredPrefixListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringRegisteredPrefixListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to fetch the next page of peering registered prefixes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringRegisteredPrefix[] _value;

        /// <summary>The list of peering registered prefixes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringRegisteredPrefix[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PeeringRegisteredPrefixListResult" /> instance.</summary>
        public PeeringRegisteredPrefixListResult()
        {

        }
    }
    /// The paginated list of peering registered prefixes.
    public partial interface IPeeringRegisteredPrefixListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>The link to fetch the next page of peering registered prefixes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to fetch the next page of peering registered prefixes.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of peering registered prefixes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of peering registered prefixes.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringRegisteredPrefix) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringRegisteredPrefix[] Value { get; set; }

    }
    /// The paginated list of peering registered prefixes.
    internal partial interface IPeeringRegisteredPrefixListResultInternal

    {
        /// <summary>The link to fetch the next page of peering registered prefixes.</summary>
        string NextLink { get; set; }
        /// <summary>The list of peering registered prefixes.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringRegisteredPrefix[] Value { get; set; }

    }
}