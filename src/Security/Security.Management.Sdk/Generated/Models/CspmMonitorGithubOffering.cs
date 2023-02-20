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
    /// The CSPM monitoring for github offering
    /// </summary>
    [Newtonsoft.Json.JsonObject("CspmMonitorGithub")]
    public partial class CspmMonitorGithubOffering : CloudOffering
    {
        /// <summary>
        /// Initializes a new instance of the CspmMonitorGithubOffering class.
        /// </summary>
        public CspmMonitorGithubOffering()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CspmMonitorGithubOffering class.
        /// </summary>
        /// <param name="description">The offering description.</param>
        public CspmMonitorGithubOffering(string description = default(string))
            : base(description)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
