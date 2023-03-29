// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Properties of reservation purchase request</summary>
    [System.ComponentModel.TypeConverter(typeof(PurchaseRequestPropertiesTypeConverter))]
    public partial class PurchaseRequestProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PurchaseRequestProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PurchaseRequestProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PurchaseRequestProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PurchaseRequestProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PurchaseRequestProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AppliedScopeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties) content.GetValueForProperty("AppliedScopeProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.AppliedScopePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservedResourceProperties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceProperties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourceProperties) content.GetValueForProperty("ReservedResourceProperties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceProperties, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestPropertiesReservedResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservedResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceType = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType?) content.GetValueForProperty("ReservedResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceType, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType.CreateFrom);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Term = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm?) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Term, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm.CreateFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan?) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan.CreateFrom);
            }
            if (content.Contains("Quantity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Quantity = (int?) content.GetValueForProperty("Quantity",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Quantity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeType = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType?) content.GetValueForProperty("AppliedScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeType, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType.CreateFrom);
            }
            if (content.Contains("AppliedScopes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopes = (string[]) content.GetValueForProperty("AppliedScopes",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Renew"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Renew = (bool?) content.GetValueForProperty("Renew",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Renew, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReviewDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReviewDateTime = (global::System.DateTime?) content.GetValueForProperty("ReviewDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReviewDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AppliedScopePropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyTenantId = (string) content.GetValueForProperty("AppliedScopePropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertySubscriptionId = (string) content.GetValueForProperty("AppliedScopePropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyDisplayName = (string) content.GetValueForProperty("AppliedScopePropertyDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ReservedResourcePropertyInstanceFlexibility"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourcePropertyInstanceFlexibility = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility?) content.GetValueForProperty("ReservedResourcePropertyInstanceFlexibility",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourcePropertyInstanceFlexibility, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility.CreateFrom);
            }
            if (content.Contains("AppliedScopePropertyManagementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyManagementGroupId = (string) content.GetValueForProperty("AppliedScopePropertyManagementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyManagementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyResourceGroupId = (string) content.GetValueForProperty("AppliedScopePropertyResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyResourceGroupId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PurchaseRequestProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AppliedScopeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeProperty = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties) content.GetValueForProperty("AppliedScopeProperty",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeProperty, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.AppliedScopePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservedResourceProperties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceProperties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesReservedResourceProperties) content.GetValueForProperty("ReservedResourceProperties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceProperties, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PurchaseRequestPropertiesReservedResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservedResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceType = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType?) content.GetValueForProperty("ReservedResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourceType, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservedResourceType.CreateFrom);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Term = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm?) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Term, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm.CreateFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan?) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationBillingPlan.CreateFrom);
            }
            if (content.Contains("Quantity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Quantity = (int?) content.GetValueForProperty("Quantity",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Quantity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeType = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType?) content.GetValueForProperty("AppliedScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopeType, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType.CreateFrom);
            }
            if (content.Contains("AppliedScopes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopes = (string[]) content.GetValueForProperty("AppliedScopes",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Renew"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Renew = (bool?) content.GetValueForProperty("Renew",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).Renew, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReviewDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReviewDateTime = (global::System.DateTime?) content.GetValueForProperty("ReviewDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReviewDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AppliedScopePropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyTenantId = (string) content.GetValueForProperty("AppliedScopePropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertySubscriptionId = (string) content.GetValueForProperty("AppliedScopePropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyDisplayName = (string) content.GetValueForProperty("AppliedScopePropertyDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ReservedResourcePropertyInstanceFlexibility"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourcePropertyInstanceFlexibility = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility?) content.GetValueForProperty("ReservedResourcePropertyInstanceFlexibility",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).ReservedResourcePropertyInstanceFlexibility, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.InstanceFlexibility.CreateFrom);
            }
            if (content.Contains("AppliedScopePropertyManagementGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyManagementGroupId = (string) content.GetValueForProperty("AppliedScopePropertyManagementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyManagementGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("AppliedScopePropertyResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyResourceGroupId = (string) content.GetValueForProperty("AppliedScopePropertyResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPurchaseRequestPropertiesInternal)this).AppliedScopePropertyResourceGroupId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Properties of reservation purchase request
    [System.ComponentModel.TypeConverter(typeof(PurchaseRequestPropertiesTypeConverter))]
    public partial interface IPurchaseRequestProperties

    {

    }
}