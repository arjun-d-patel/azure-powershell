// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.PowerShell;

    /// <summary>
    /// Specifies information about the operating system disk used by the virtual machine. <br><br> For more information about
    /// disks, see [About disks and VHDs for Azure virtual machines](https://learn.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(OSDiskTypeConverter))]
    public partial class OSDisk
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.OSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDisk DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OSDisk(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.OSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDisk DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OSDisk(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OSDisk" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDisk FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.OSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OSDisk(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Vhd"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Vhd = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVirtualHardDisk) content.GetValueForProperty("Vhd",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Vhd, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.VirtualHardDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).OSType = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes?) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).OSType, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes.CreateFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).DiskSizeGb = (int?) content.GetValueForProperty("DiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).DiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VhdUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).VhdUri = (string) content.GetValueForProperty("VhdUri",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).VhdUri, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.OSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OSDisk(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Vhd"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Vhd = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IVirtualHardDisk) content.GetValueForProperty("Vhd",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Vhd, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.VirtualHardDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).OSType = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes?) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).OSType, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes.CreateFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).DiskSizeGb = (int?) content.GetValueForProperty("DiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).DiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VhdUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).VhdUri = (string) content.GetValueForProperty("VhdUri",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IOSDiskInternal)this).VhdUri, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Specifies information about the operating system disk used by the virtual machine. <br><br> For more information about
    /// disks, see [About disks and VHDs for Azure virtual machines](https://learn.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    [System.ComponentModel.TypeConverter(typeof(OSDiskTypeConverter))]
    public partial interface IOSDisk

    {

    }
}