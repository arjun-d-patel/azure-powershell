// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>Description of a Check Name availability request properties.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class CheckNameAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICheckNameAvailability,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.ICheckNameAvailabilityInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens.
        /// The namespace must start with a letter, and it must end with a letter or number.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailability" /> instance.</summary>
        public CheckNameAvailability()
        {

        }
    }
    /// Description of a Check Name availability request properties.
    public partial interface ICheckNameAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens.
        /// The namespace must start with a letter, and it must end with a letter or number.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens. The namespace must start with a letter, and it must end with a letter or number.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Description of a Check Name availability request properties.
    internal partial interface ICheckNameAvailabilityInternal

    {
        /// <summary>
        /// The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens.
        /// The namespace must start with a letter, and it must end with a letter or number.
        /// </summary>
        string Name { get; set; }

    }
}