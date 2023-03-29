// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list ServiceBus operations. It contains a list of operations and a URL link to get the next set
    /// of results.
    /// </summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class OperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperationListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperationListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperation[] Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperationListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperation[] _value;

        /// <summary>
        /// List of ServiceBus operations supported by the Microsoft.ServiceBus resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperation[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationListResult" /> instance.</summary>
        public OperationListResult()
        {

        }
    }
    /// Result of the request to list ServiceBus operations. It contains a list of operations and a URL link to get the next set
    /// of results.
    public partial interface IOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next set of operation list results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>
        /// List of ServiceBus operations supported by the Microsoft.ServiceBus resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of ServiceBus operations supported by the Microsoft.ServiceBus resource provider.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperation[] Value { get;  }

    }
    /// Result of the request to list ServiceBus operations. It contains a list of operations and a URL link to get the next set
    /// of results.
    internal partial interface IOperationListResultInternal

    {
        /// <summary>URL to get the next set of operation list results if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>
        /// List of ServiceBus operations supported by the Microsoft.ServiceBus resource provider.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IOperation[] Value { get; set; }

    }
}