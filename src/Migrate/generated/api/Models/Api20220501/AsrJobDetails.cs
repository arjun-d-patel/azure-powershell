// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>This class represents job details based on specific job type.</summary>
    public partial class AsrJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IAsrJobDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IAsrJobDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetails __jobDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.JobDetails();

        /// <summary>
        /// The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow
        /// object details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetailsAffectedObjectDetails AffectedObjectDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetailsInternal)__jobDetails).AffectedObjectDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetailsInternal)__jobDetails).AffectedObjectDetail = value ?? null /* model class */; }

        /// <summary>Gets the type of job details (see JobDetailsTypes enum for possible values).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetailsInternal)__jobDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetailsInternal)__jobDetails).InstanceType = value ; }

        /// <summary>Creates an new <see cref="AsrJobDetails" /> instance.</summary>
        public AsrJobDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobDetails), __jobDetails);
            await eventListener.AssertObjectIsValid(nameof(__jobDetails), __jobDetails);
        }
    }
    /// This class represents job details based on specific job type.
    public partial interface IAsrJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetails
    {

    }
    /// This class represents job details based on specific job type.
    internal partial interface IAsrJobDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IJobDetailsInternal
    {

    }
}