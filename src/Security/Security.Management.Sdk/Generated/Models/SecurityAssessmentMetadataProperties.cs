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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes properties of an assessment metadata.
    /// </summary>
    public partial class SecurityAssessmentMetadataProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SecurityAssessmentMetadataProperties class.
        /// </summary>
        public SecurityAssessmentMetadataProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SecurityAssessmentMetadataProperties class.
        /// </summary>
        /// <param name="displayName">User friendly display name of the
        /// assessment</param>
        /// <param name="severity">The severity level of the assessment.
        /// Possible values include: 'Low', 'Medium', 'High'</param>
        /// <param name="assessmentType">BuiltIn if the assessment based on
        /// built-in Azure Policy definition, Custom if the assessment based on
        /// custom Azure Policy definition. Possible values include: 'BuiltIn',
        /// 'CustomPolicy', 'CustomerManaged', 'VerifiedPartner'</param>
        /// <param name="policyDefinitionId">Azure resource ID of the policy
        /// definition that turns this assessment calculation on</param>
        /// <param name="description">Human readable description of the
        /// assessment</param>
        /// <param name="remediationDescription">Human readable description of
        /// what you should do to mitigate this security issue</param>
        /// <param name="userImpact">The user impact of the assessment.
        /// Possible values include: 'Low', 'Moderate', 'High'</param>
        /// <param name="implementationEffort">The implementation effort
        /// required to remediate this assessment. Possible values include:
        /// 'Low', 'Moderate', 'High'</param>
        /// <param name="preview">True if this assessment is in preview release
        /// status</param>
        public SecurityAssessmentMetadataProperties(string displayName, string severity, string assessmentType, string policyDefinitionId = default(string), string description = default(string), string remediationDescription = default(string), IList<string> categories = default(IList<string>), string userImpact = default(string), string implementationEffort = default(string), IList<string> threats = default(IList<string>), bool? preview = default(bool?), SecurityAssessmentMetadataPartnerData partnerData = default(SecurityAssessmentMetadataPartnerData))
        {
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Description = description;
            RemediationDescription = remediationDescription;
            Categories = categories;
            Severity = severity;
            UserImpact = userImpact;
            ImplementationEffort = implementationEffort;
            Threats = threats;
            Preview = preview;
            AssessmentType = assessmentType;
            PartnerData = partnerData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user friendly display name of the assessment
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets azure resource ID of the policy definition that turns this
        /// assessment calculation on
        /// </summary>
        [JsonProperty(PropertyName = "policyDefinitionId")]
        public string PolicyDefinitionId { get; private set; }

        /// <summary>
        /// Gets or sets human readable description of the assessment
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets human readable description of what you should do to
        /// mitigate this security issue
        /// </summary>
        [JsonProperty(PropertyName = "remediationDescription")]
        public string RemediationDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the severity level of the assessment. Possible values
        /// include: 'Low', 'Medium', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the user impact of the assessment. Possible values
        /// include: 'Low', 'Moderate', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "userImpact")]
        public string UserImpact { get; set; }

        /// <summary>
        /// Gets or sets the implementation effort required to remediate this
        /// assessment. Possible values include: 'Low', 'Moderate', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "implementationEffort")]
        public string ImplementationEffort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "threats")]
        public IList<string> Threats { get; set; }

        /// <summary>
        /// Gets or sets true if this assessment is in preview release status
        /// </summary>
        [JsonProperty(PropertyName = "preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// Gets or sets builtIn if the assessment based on built-in Azure
        /// Policy definition, Custom if the assessment based on custom Azure
        /// Policy definition. Possible values include: 'BuiltIn',
        /// 'CustomPolicy', 'CustomerManaged', 'VerifiedPartner'
        /// </summary>
        [JsonProperty(PropertyName = "assessmentType")]
        public string AssessmentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partnerData")]
        public SecurityAssessmentMetadataPartnerData PartnerData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Severity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Severity");
            }
            if (AssessmentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssessmentType");
            }
            if (PartnerData != null)
            {
                PartnerData.Validate();
            }
        }
    }
}
