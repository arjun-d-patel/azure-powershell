// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cosmos DB SQL trigger resource object
    /// </summary>
    public partial class SqlTriggerResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlTriggerResource class.
        /// </summary>
        public SqlTriggerResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlTriggerResource class.
        /// </summary>
        /// <param name="id">Name of the Cosmos DB SQL trigger</param>
        /// <param name="body">Body of the Trigger</param>
        /// <param name="triggerType">Type of the Trigger. Possible values
        /// include: 'Pre', 'Post'</param>
        /// <param name="triggerOperation">The operation the trigger is
        /// associated with. Possible values include: 'All', 'Create',
        /// 'Update', 'Delete', 'Replace'</param>
        public SqlTriggerResource(string id, string body = default(string), string triggerType = default(string), string triggerOperation = default(string))
        {
            Id = id;
            Body = body;
            TriggerType = triggerType;
            TriggerOperation = triggerOperation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Cosmos DB SQL trigger
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets body of the Trigger
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets type of the Trigger. Possible values include: 'Pre',
        /// 'Post'
        /// </summary>
        [JsonProperty(PropertyName = "triggerType")]
        public string TriggerType { get; set; }

        /// <summary>
        /// Gets or sets the operation the trigger is associated with. Possible
        /// values include: 'All', 'Create', 'Update', 'Delete', 'Replace'
        /// </summary>
        [JsonProperty(PropertyName = "triggerOperation")]
        public string TriggerOperation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
