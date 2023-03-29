// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile of the managed outbound IP resources of the managed cluster.
    /// </summary>
    public partial class ManagedClusterManagedOutboundIPProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterManagedOutboundIPProfile class.
        /// </summary>
        public ManagedClusterManagedOutboundIPProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterManagedOutboundIPProfile class.
        /// </summary>
        /// <param name="count">The desired number of outbound IPs
        /// created/managed by Azure. Allowed values must be in the range of 1
        /// to 16 (inclusive). The default value is 1. </param>
        public ManagedClusterManagedOutboundIPProfile(int? count = default(int?))
        {
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the desired number of outbound IPs created/managed by
        /// Azure. Allowed values must be in the range of 1 to 16 (inclusive).
        /// The default value is 1.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Count != null)
            {
                if (Count > 16)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Count", 16);
                }
                if (Count < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Count", 1);
                }
            }
        }
    }
}
