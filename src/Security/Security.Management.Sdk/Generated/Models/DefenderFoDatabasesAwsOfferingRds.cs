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
    /// The RDS configuration
    /// </summary>
    public partial class DefenderFoDatabasesAwsOfferingRds
    {
        /// <summary>
        /// Initializes a new instance of the DefenderFoDatabasesAwsOfferingRds
        /// class.
        /// </summary>
        public DefenderFoDatabasesAwsOfferingRds()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefenderFoDatabasesAwsOfferingRds
        /// class.
        /// </summary>
        /// <param name="enabled">Is RDS protection enabled</param>
        /// <param name="cloudRoleArn">The cloud role ARN in AWS for this
        /// feature</param>
        public DefenderFoDatabasesAwsOfferingRds(bool? enabled = default(bool?), string cloudRoleArn = default(string))
        {
            Enabled = enabled;
            CloudRoleArn = cloudRoleArn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets is RDS protection enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the cloud role ARN in AWS for this feature
        /// </summary>
        [JsonProperty(PropertyName = "cloudRoleArn")]
        public string CloudRoleArn { get; set; }

    }
}
