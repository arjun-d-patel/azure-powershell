// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Add action groups to alert processing rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AddActionGroups")]
    public partial class AddActionGroups : Action
    {
        /// <summary>
        /// Initializes a new instance of the AddActionGroups class.
        /// </summary>
        public AddActionGroups()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddActionGroups class.
        /// </summary>
        /// <param name="actionGroupIds">List of action group Ids to add to
        /// alert processing rule.</param>
        public AddActionGroups(IList<string> actionGroupIds)
        {
            ActionGroupIds = actionGroupIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of action group Ids to add to alert processing
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "actionGroupIds")]
        public IList<string> ActionGroupIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ActionGroupIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ActionGroupIds");
            }
        }
    }
}
