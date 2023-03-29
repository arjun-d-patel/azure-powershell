// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Refund policy result property</summary>
    [System.ComponentModel.TypeConverter(typeof(RefundPolicyResultPropertyTypeConverter))]
    public partial class RefundPolicyResultProperty
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundPolicyResultProperty"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultProperty"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultProperty DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RefundPolicyResultProperty(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundPolicyResultProperty"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultProperty"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultProperty DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RefundPolicyResultProperty(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RefundPolicyResultProperty" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RefundPolicyResultProperty" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultProperty FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundPolicyResultProperty"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RefundPolicyResultProperty(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConsumedRefundsTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).ConsumedRefundsTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("ConsumedRefundsTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).ConsumedRefundsTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("MaxRefundLimit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).MaxRefundLimit = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MaxRefundLimit",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).MaxRefundLimit, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).PolicyError = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyError[]) content.GetValueForProperty("PolicyError",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).PolicyError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundPolicyErrorTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundPolicyResultProperty"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RefundPolicyResultProperty(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConsumedRefundsTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).ConsumedRefundsTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("ConsumedRefundsTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).ConsumedRefundsTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("MaxRefundLimit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).MaxRefundLimit = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) content.GetValueForProperty("MaxRefundLimit",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).MaxRefundLimit, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).PolicyError = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyError[]) content.GetValueForProperty("PolicyError",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyResultPropertyInternal)this).PolicyError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundPolicyError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundPolicyErrorTypeConverter.ConvertFrom));
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
    /// Refund policy result property
    [System.ComponentModel.TypeConverter(typeof(RefundPolicyResultPropertyTypeConverter))]
    public partial interface IRefundPolicyResultProperty

    {

    }
}