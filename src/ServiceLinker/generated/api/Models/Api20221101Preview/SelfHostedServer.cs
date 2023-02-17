// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Extensions;

    /// <summary>The service properties when target service type is SelfHostedServer</summary>
    public partial class SelfHostedServer :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ISelfHostedServer,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ISelfHostedServerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBase __targetServiceBase = new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.TargetServiceBase();

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private string _endpoint;

        /// <summary>The endpoint of service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Owned)]
        public string Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>The target service type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.TargetServiceType Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBaseInternal)__targetServiceBase).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBaseInternal)__targetServiceBase).Type = value ; }

        /// <summary>Creates an new <see cref="SelfHostedServer" /> instance.</summary>
        public SelfHostedServer()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__targetServiceBase), __targetServiceBase);
            await eventListener.AssertObjectIsValid(nameof(__targetServiceBase), __targetServiceBase);
        }
    }
    /// The service properties when target service type is SelfHostedServer
    public partial interface ISelfHostedServer :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBase
    {
        /// <summary>The endpoint of service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint of service.",
        SerializedName = @"endpoint",
        PossibleTypes = new [] { typeof(string) })]
        string Endpoint { get; set; }

    }
    /// The service properties when target service type is SelfHostedServer
    internal partial interface ISelfHostedServerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBaseInternal
    {
        /// <summary>The endpoint of service.</summary>
        string Endpoint { get; set; }

    }
}