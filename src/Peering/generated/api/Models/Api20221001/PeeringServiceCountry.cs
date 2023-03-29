// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The peering service country.</summary>
    public partial class PeeringServiceCountry :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceCountry,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServiceCountryInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.Resource();

        /// <summary>The ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PeeringServiceCountry" /> instance.</summary>
        public PeeringServiceCountry()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The peering service country.
    public partial interface IPeeringServiceCountry :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource
    {

    }
    /// The peering service country.
    internal partial interface IPeeringServiceCountryInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal
    {

    }
}