// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904
{
    using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.PowerShell;

    /// <summary>
    /// Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer
    /// configuration must have exactly one frontend IP configuration.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(LoadBalancerFrontendIPConfigurationTypeConverter))]
    public partial class LoadBalancerFrontendIPConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.LoadBalancerFrontendIPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LoadBalancerFrontendIPConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.LoadBalancerFrontendIPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LoadBalancerFrontendIPConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LoadBalancerFrontendIPConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="LoadBalancerFrontendIPConfiguration" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.LoadBalancerFrontendIPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LoadBalancerFrontendIPConfiguration(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.LoadBalancerFrontendIPConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.ISubResource) content.GetValueForProperty("PublicIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddress, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Subnet = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.ISubResource) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Subnet, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrivateIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PrivateIPAddress = (string) content.GetValueForProperty("PrivateIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PrivateIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddressId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddressId = (string) content.GetValueForProperty("PublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddressId, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.LoadBalancerFrontendIPConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LoadBalancerFrontendIPConfiguration(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.LoadBalancerFrontendIPConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.ISubResource) content.GetValueForProperty("PublicIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddress, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Subnet = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.ISubResource) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).Subnet, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api10.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrivateIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PrivateIPAddress = (string) content.GetValueForProperty("PrivateIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PrivateIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPAddressId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddressId = (string) content.GetValueForProperty("PublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).PublicIPAddressId, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfigurationInternal)this).SubnetId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer
    /// configuration must have exactly one frontend IP configuration.
    [System.ComponentModel.TypeConverter(typeof(LoadBalancerFrontendIPConfigurationTypeConverter))]
    public partial interface ILoadBalancerFrontendIPConfiguration

    {

    }
}