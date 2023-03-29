// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input for InstallPatches as directly received by the API
    /// </summary>
    public partial class VirtualMachineInstallPatchesParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineInstallPatchesParameters class.
        /// </summary>
        public VirtualMachineInstallPatchesParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineInstallPatchesParameters class.
        /// </summary>
        /// <param name="rebootSetting">Defines when it is acceptable to reboot
        /// a VM during a software update operation. Possible values include:
        /// 'IfRequired', 'Never', 'Always'</param>
        /// <param name="maximumDuration">Specifies the maximum amount of time
        /// that the operation will run. It must be an ISO 8601-compliant
        /// duration string such as PT4H (4 hours)</param>
        /// <param name="windowsParameters">Input for InstallPatches on a
        /// Windows VM, as directly received by the API</param>
        /// <param name="linuxParameters">Input for InstallPatches on a Linux
        /// VM, as directly received by the API</param>
        public VirtualMachineInstallPatchesParameters(string rebootSetting, string maximumDuration = default(string), WindowsParameters windowsParameters = default(WindowsParameters), LinuxParameters linuxParameters = default(LinuxParameters))
        {
            MaximumDuration = maximumDuration;
            RebootSetting = rebootSetting;
            WindowsParameters = windowsParameters;
            LinuxParameters = linuxParameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the maximum amount of time that the
        /// operation will run. It must be an ISO 8601-compliant duration
        /// string such as PT4H (4 hours)
        /// </summary>
        [JsonProperty(PropertyName = "maximumDuration")]
        public string MaximumDuration { get; set; }

        /// <summary>
        /// Gets or sets defines when it is acceptable to reboot a VM during a
        /// software update operation. Possible values include: 'IfRequired',
        /// 'Never', 'Always'
        /// </summary>
        [JsonProperty(PropertyName = "rebootSetting")]
        public string RebootSetting { get; set; }

        /// <summary>
        /// Gets or sets input for InstallPatches on a Windows VM, as directly
        /// received by the API
        /// </summary>
        [JsonProperty(PropertyName = "windowsParameters")]
        public WindowsParameters WindowsParameters { get; set; }

        /// <summary>
        /// Gets or sets input for InstallPatches on a Linux VM, as directly
        /// received by the API
        /// </summary>
        [JsonProperty(PropertyName = "linuxParameters")]
        public LinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RebootSetting == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RebootSetting");
            }
        }
    }
}
