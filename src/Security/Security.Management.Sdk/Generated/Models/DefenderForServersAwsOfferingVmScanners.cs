// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Microsoft Defender for Server VM scanning configuration
    /// </summary>
    public partial class DefenderForServersAwsOfferingVmScanners
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DefenderForServersAwsOfferingVmScanners class.
        /// </summary>
        public DefenderForServersAwsOfferingVmScanners()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DefenderForServersAwsOfferingVmScanners class.
        /// </summary>
        /// <param name="enabled">Is Microsoft Defender for Server VM scanning
        /// enabled</param>
        /// <param name="configuration">configuration for Microsoft Defender
        /// for Server VM scanning</param>
        public DefenderForServersAwsOfferingVmScanners(bool? enabled = default(bool?), DefenderForServersAwsOfferingVmScannersConfiguration configuration = default(DefenderForServersAwsOfferingVmScannersConfiguration))
        {
            Enabled = enabled;
            Configuration = configuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets is Microsoft Defender for Server VM scanning enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets configuration for Microsoft Defender for Server VM
        /// scanning
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public DefenderForServersAwsOfferingVmScannersConfiguration Configuration { get; set; }

    }
}
