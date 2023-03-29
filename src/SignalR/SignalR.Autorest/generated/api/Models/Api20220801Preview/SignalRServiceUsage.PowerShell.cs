// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.PowerShell;

    /// <summary>Object that describes a specific usage of the resources.</summary>
    [System.ComponentModel.TypeConverter(typeof(SignalRServiceUsageTypeConverter))]
    public partial class SignalRServiceUsage
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SignalRServiceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsage"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsage DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SignalRServiceUsage(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SignalRServiceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsage"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsage DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SignalRServiceUsage(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SignalRServiceUsage" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SignalRServiceUsage" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsage FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SignalRServiceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SignalRServiceUsage(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageName) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SignalRServiceUsageNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).CurrentValue = (long?) content.GetValueForProperty("CurrentValue",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).CurrentValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Limit = (long?) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Limit, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SignalRServiceUsage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SignalRServiceUsage(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Name = (Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageName) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Name, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.SignalRServiceUsageNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).CurrentValue = (long?) content.GetValueForProperty("CurrentValue",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).CurrentValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Limit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Limit = (long?) content.GetValueForProperty("Limit",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Limit, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("NameValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameValue = (string) content.GetValueForProperty("NameValue",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameValue, global::System.Convert.ToString);
            }
            if (content.Contains("NameLocalizedValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameLocalizedValue = (string) content.GetValueForProperty("NameLocalizedValue",((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ISignalRServiceUsageInternal)this).NameLocalizedValue, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Object that describes a specific usage of the resources.
    [System.ComponentModel.TypeConverter(typeof(SignalRServiceUsageTypeConverter))]
    public partial interface ISignalRServiceUsage

    {

    }
}