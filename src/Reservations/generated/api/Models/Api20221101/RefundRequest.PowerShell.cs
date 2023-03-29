// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Request containing information needed for returning reservation.</summary>
    [System.ComponentModel.TypeConverter(typeof(RefundRequestTypeConverter))]
    public partial class RefundRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RefundRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RefundRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RefundRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RefundRequest" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RefundRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservationToReturn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturn = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IReservationToReturn) content.GetValueForProperty("ReservationToReturn",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturn, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ReservationToReturnTypeConverter.ConvertFrom);
            }
            if (content.Contains("SessionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).SessionId = (string) content.GetValueForProperty("SessionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).SessionId, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReturnReason = (string) content.GetValueForProperty("ReturnReason",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReturnReason, global::System.Convert.ToString);
            }
            if (content.Contains("ReservationToReturnReservationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnReservationId = (string) content.GetValueForProperty("ReservationToReturnReservationId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnReservationId, global::System.Convert.ToString);
            }
            if (content.Contains("ReservationToReturnQuantity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnQuantity = (int?) content.GetValueForProperty("ReservationToReturnQuantity",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnQuantity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RefundRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.RefundRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReservationToReturn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturn = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IReservationToReturn) content.GetValueForProperty("ReservationToReturn",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturn, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ReservationToReturnTypeConverter.ConvertFrom);
            }
            if (content.Contains("SessionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).SessionId = (string) content.GetValueForProperty("SessionId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).SessionId, global::System.Convert.ToString);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReturnReason = (string) content.GetValueForProperty("ReturnReason",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReturnReason, global::System.Convert.ToString);
            }
            if (content.Contains("ReservationToReturnReservationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnReservationId = (string) content.GetValueForProperty("ReservationToReturnReservationId",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnReservationId, global::System.Convert.ToString);
            }
            if (content.Contains("ReservationToReturnQuantity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnQuantity = (int?) content.GetValueForProperty("ReservationToReturnQuantity",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IRefundRequestInternal)this).ReservationToReturnQuantity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
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
    /// Request containing information needed for returning reservation.
    [System.ComponentModel.TypeConverter(typeof(RefundRequestTypeConverter))]
    public partial interface IRefundRequest

    {

    }
}