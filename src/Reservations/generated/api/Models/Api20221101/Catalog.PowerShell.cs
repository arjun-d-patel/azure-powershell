// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Product details of a type of resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(CatalogTypeConverter))]
    public partial class Catalog
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.Catalog"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Catalog(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Msrp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Msrp = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogMsrp) content.GetValueForProperty("Msrp",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Msrp, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.CatalogMsrpTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogBillingPlans) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.CatalogBillingPlansTypeConverter.ConvertFrom);
            }
            if (content.Contains("Terms"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Terms = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm[]) content.GetValueForProperty("Terms",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Terms, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm.CreateFrom));
            }
            if (content.Contains("Locations"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Locations = (string[]) content.GetValueForProperty("Locations",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Locations, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SkuProperties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).SkuProperties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuProperty[]) content.GetValueForProperty("SkuProperties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).SkuProperties, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("Restrictions"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Restrictions = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuRestriction[]) content.GetValueForProperty("Restrictions",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Restrictions, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuRestriction>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuRestrictionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Tier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Tier = (string) content.GetValueForProperty("Tier",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Tier, global::System.Convert.ToString);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("Capability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Capability = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuCapability[]) content.GetValueForProperty("Capability",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Capability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuCapabilityTypeConverter.ConvertFrom));
            }
            if (content.Contains("MsrpP1Y"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP1Y = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MsrpP1Y",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP1Y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("MsrpP3Y"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP3Y = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MsrpP3Y",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP3Y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("MsrpP5Y"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP5Y = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MsrpP5Y",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP5Y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.Catalog"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Catalog(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Msrp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Msrp = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogMsrp) content.GetValueForProperty("Msrp",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Msrp, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.CatalogMsrpTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogBillingPlans) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.CatalogBillingPlansTypeConverter.ConvertFrom);
            }
            if (content.Contains("Terms"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Terms = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm[]) content.GetValueForProperty("Terms",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Terms, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ReservationTerm.CreateFrom));
            }
            if (content.Contains("Locations"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Locations = (string[]) content.GetValueForProperty("Locations",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Locations, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SkuProperties"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).SkuProperties = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuProperty[]) content.GetValueForProperty("SkuProperties",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).SkuProperties, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("Restrictions"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Restrictions = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuRestriction[]) content.GetValueForProperty("Restrictions",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Restrictions, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuRestriction>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuRestrictionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Tier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Tier = (string) content.GetValueForProperty("Tier",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Tier, global::System.Convert.ToString);
            }
            if (content.Contains("Size"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Size = (string) content.GetValueForProperty("Size",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Size, global::System.Convert.ToString);
            }
            if (content.Contains("Capability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Capability = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuCapability[]) content.GetValueForProperty("Capability",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).Capability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SkuCapabilityTypeConverter.ConvertFrom));
            }
            if (content.Contains("MsrpP1Y"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP1Y = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MsrpP1Y",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP1Y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("MsrpP3Y"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP3Y = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MsrpP3Y",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP3Y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("MsrpP5Y"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP5Y = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MsrpP5Y",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalogInternal)this).MsrpP5Y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.Catalog"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalog" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalog DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Catalog(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.Catalog"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalog" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalog DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Catalog(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Catalog" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Catalog" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICatalog FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Product details of a type of resource.
    [System.ComponentModel.TypeConverter(typeof(CatalogTypeConverter))]
    public partial interface ICatalog

    {

    }
}