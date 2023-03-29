// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>The response to the List Namespace operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class SbAuthorizationRuleListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbAuthorizationRuleListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbAuthorizationRuleListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Authorization Rules.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbAuthorizationRule[] _value;

        /// <summary>Result of the List Authorization Rules operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbAuthorizationRule[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SbAuthorizationRuleListResult" /> instance.</summary>
        public SbAuthorizationRuleListResult()
        {

        }
    }
    /// The response to the List Namespace operation.
    public partial interface ISbAuthorizationRuleListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Authorization Rules.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the next set of results. Not empty if Value contains incomplete list of Authorization Rules.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Result of the List Authorization Rules operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Result of the List Authorization Rules operation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbAuthorizationRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbAuthorizationRule[] Value { get; set; }

    }
    /// The response to the List Namespace operation.
    internal partial interface ISbAuthorizationRuleListResultInternal

    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Authorization Rules.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>Result of the List Authorization Rules operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ISbAuthorizationRule[] Value { get; set; }

    }
}