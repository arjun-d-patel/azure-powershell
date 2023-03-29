// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VMwareCbt NIC input.
    /// </summary>
    public partial class VMwareCbtNicInput
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtNicInput class.
        /// </summary>
        public VMwareCbtNicInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtNicInput class.
        /// </summary>
        /// <param name="nicId">The NIC Id.</param>
        /// <param name="isPrimaryNic">A value indicating whether this is the
        /// primary NIC.</param>
        /// <param name="targetSubnetName">Target subnet name.</param>
        /// <param name="targetStaticIPAddress">The static IP address.</param>
        /// <param name="isSelectedForMigration">A value indicating whether
        /// this NIC is selected for migration.</param>
        /// <param name="targetNicName">Target NIC name.</param>
        /// <param name="testSubnetName">The test subnet name.</param>
        /// <param name="testStaticIPAddress">The test static IP
        /// address.</param>
        public VMwareCbtNicInput(string nicId, string isPrimaryNic, string targetSubnetName = default(string), string targetStaticIPAddress = default(string), string isSelectedForMigration = default(string), string targetNicName = default(string), string testSubnetName = default(string), string testStaticIPAddress = default(string))
        {
            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
            TargetSubnetName = targetSubnetName;
            TargetStaticIPAddress = targetStaticIPAddress;
            IsSelectedForMigration = isSelectedForMigration;
            TargetNicName = targetNicName;
            TestSubnetName = testSubnetName;
            TestStaticIPAddress = testStaticIPAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the NIC Id.
        /// </summary>
        [JsonProperty(PropertyName = "nicId")]
        public string NicId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the primary NIC.
        /// </summary>
        [JsonProperty(PropertyName = "isPrimaryNic")]
        public string IsPrimaryNic { get; set; }

        /// <summary>
        /// Gets or sets target subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "targetSubnetName")]
        public string TargetSubnetName { get; set; }

        /// <summary>
        /// Gets or sets the static IP address.
        /// </summary>
        [JsonProperty(PropertyName = "targetStaticIPAddress")]
        public string TargetStaticIPAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this NIC is selected for
        /// migration.
        /// </summary>
        [JsonProperty(PropertyName = "isSelectedForMigration")]
        public string IsSelectedForMigration { get; set; }

        /// <summary>
        /// Gets or sets target NIC name.
        /// </summary>
        [JsonProperty(PropertyName = "targetNicName")]
        public string TargetNicName { get; set; }

        /// <summary>
        /// Gets or sets the test subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "testSubnetName")]
        public string TestSubnetName { get; set; }

        /// <summary>
        /// Gets or sets the test static IP address.
        /// </summary>
        [JsonProperty(PropertyName = "testStaticIPAddress")]
        public string TestStaticIPAddress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NicId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NicId");
            }
            if (IsPrimaryNic == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IsPrimaryNic");
            }
        }
    }
}
