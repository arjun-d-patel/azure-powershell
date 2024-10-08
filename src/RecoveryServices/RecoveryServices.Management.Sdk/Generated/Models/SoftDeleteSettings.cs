// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using System.Linq;

    /// <summary>
    /// Soft delete Settings of vault
    /// </summary>
    public partial class SoftDeleteSettings
    {
        /// <summary>
        /// Initializes a new instance of the SoftDeleteSettings class.
        /// </summary>
        public SoftDeleteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SoftDeleteSettings class.
        /// </summary>

        /// <param name="softDeleteState">
        /// Possible values include: &#39;Invalid&#39;, &#39;Enabled&#39;, &#39;Disabled&#39;, &#39;AlwaysON&#39;</param>

        /// <param name="softDeleteRetentionPeriodInDays">Soft delete retention period in days
        /// </param>

        /// <param name="enhancedSecurityState">
        /// Possible values include: &#39;Invalid&#39;, &#39;Enabled&#39;, &#39;Disabled&#39;, &#39;AlwaysON&#39;</param>
        public SoftDeleteSettings(string softDeleteState = default(string), int? softDeleteRetentionPeriodInDays = default(int?), string enhancedSecurityState = default(string))

        {
            this.SoftDeleteState = softDeleteState;
            this.SoftDeleteRetentionPeriodInDays = softDeleteRetentionPeriodInDays;
            this.EnhancedSecurityState = enhancedSecurityState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets Possible values include: &#39;Invalid&#39;, &#39;Enabled&#39;, &#39;Disabled&#39;, &#39;AlwaysON&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "softDeleteState")]
        public string SoftDeleteState {get; set; }

        /// <summary>
        /// Gets or sets soft delete retention period in days
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "softDeleteRetentionPeriodInDays")]
        public int? SoftDeleteRetentionPeriodInDays {get; set; }

        /// <summary>
        /// Gets or sets Possible values include: &#39;Invalid&#39;, &#39;Enabled&#39;, &#39;Disabled&#39;, &#39;AlwaysON&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enhancedSecurityState")]
        public string EnhancedSecurityState {get; set; }
    }
}