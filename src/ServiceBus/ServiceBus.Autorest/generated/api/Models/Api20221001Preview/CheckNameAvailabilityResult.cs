// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>Description of a Check Name availability request properties.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class CheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICheckNameAvailabilityResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICheckNameAvailabilityResultInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The detailed info regarding the reason associated with the namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICheckNameAvailabilityResultInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>
        /// Value indicating namespace is availability, true if the namespace is available; otherwise, false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.UnavailableReason? _reason;

        /// <summary>The reason for unavailability of a namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.UnavailableReason? Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityResult" /> instance.</summary>
        public CheckNameAvailabilityResult()
        {

        }
    }
    /// Description of a Check Name availability request properties.
    public partial interface ICheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>The detailed info regarding the reason associated with the namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The detailed info regarding the reason associated with the namespace.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>
        /// Value indicating namespace is availability, true if the namespace is available; otherwise, false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating namespace is availability, true if the namespace is available; otherwise, false.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get; set; }
        /// <summary>The reason for unavailability of a namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason for unavailability of a namespace.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.UnavailableReason) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.UnavailableReason? Reason { get; set; }

    }
    /// Description of a Check Name availability request properties.
    internal partial interface ICheckNameAvailabilityResultInternal

    {
        /// <summary>The detailed info regarding the reason associated with the namespace.</summary>
        string Message { get; set; }
        /// <summary>
        /// Value indicating namespace is availability, true if the namespace is available; otherwise, false.
        /// </summary>
        bool? NameAvailable { get; set; }
        /// <summary>The reason for unavailability of a namespace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Support.UnavailableReason? Reason { get; set; }

    }
}