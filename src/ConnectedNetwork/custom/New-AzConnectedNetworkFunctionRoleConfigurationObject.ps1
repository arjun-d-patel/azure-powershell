
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a in-memory object for NetworkFunctionRoleConfiguration
.Description
Create a in-memory object for NetworkFunctionRoleConfiguration

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionRoleConfiguration
.Link
https://learn.microsoft.com/powershell/module/az.ConnectedNetwork/new-AzConnectedNetworkFunctionRoleConfigurationObject
#>
function New-AzConnectedNetworkFunctionRoleConfigurationObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionRoleConfiguration')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Path for metadata configuration.")]
        [string]
        $CustomProfileMetadataConfigurationPath,
        [Parameter(HelpMessage="Specifies in decimal numbers, the exact version of image used to create the virtual machine.")]
        [string]
        $ImageReferenceExactVersion,
        [Parameter(HelpMessage="Specifies the offer of the image used to create the virtual machine.")]
        [string]
        $ImageReferenceOffer,
        [Parameter(HelpMessage="The image publisher.")]
        [string]
        $ImageReferencePublisher,
        [Parameter(HelpMessage="The image SKU.")]
        [string]
        $ImageReferenceSku,
        [Parameter(HelpMessage="Specifies the version of the image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.")]
        [string]
        $ImageReferenceVersion,
        [Parameter(HelpMessage="The network interface configurations.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkInterface[]]
        $NetworkInterface,
        [Parameter(HelpMessage="The VHD name.")]
        [string]
        $OSDiskName,
        [Parameter(HelpMessage="The OS type.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.OperatingSystemTypes]
        $OSDiskOstype,
        [Parameter(HelpMessage="Specifies the size of os disk in gigabytes. This is the fully expanded disk size needed of the VHD image on the ASE. This disk size should be greater than the size of the VHD provided in vhdUri.")]
        [int]
        $OSDiskSizeGb,
        [Parameter(HelpMessage="Specifies the name of the administrator account. <br><br> **Windows-only restriction:** Cannot end in `".`" <br><br> **Disallowed values:** `"administrator`", `"admin`", `"user`", `"user1`", `"test`", `"user2`", `"test1`", `"user3`", `"admin1`", `"1`", `"123`", `"a`", `"actuser`", `"adm`", `"admin2`", `"aspnet`", `"backup`", `"console`", `"david`", `"guest`", `"john`", `"owner`", `"root`", `"server`", `"sql`", `"support`", `"support_388945a0`", `"sys`", `"test2`", `"test3`", `"user4`", `"user5`". <br><br> **Minimum-length (Linux):** 1  character <br><br> **Max-length (Linux):** 64 characters <br><br> **Max-length (Windows):** 20 characters  <br><br><li> For root access to the Linux VM, see [Using root privileges on Linux virtual machines in Azure](https://learn.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)<br><li> For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for Linux on Azure](https://learn.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).")]
        [string]
        $OSProfileAdminUsername,
        [Parameter(HelpMessage="Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. <br><br> **Note: Do not pass any secrets or passwords in customData property** <br><br> This property cannot be updated after the VM is created. <br><br> customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/) <br><br> For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://learn.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).")]
        [string]
        $OSProfileCustomData,
        [Parameter(HelpMessage="Indicates if custom data is required to deploy this role.")]
        [bool]
        $OSProfileCustomDataRequired,
        [Parameter(HelpMessage="The name of the network function role.")]
        [string]
        $RoleName,
        [Parameter(HelpMessage="Role type.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.NetworkFunctionRoleConfigurationType]
        $RoleType,
        [Parameter(HelpMessage="The list of SSH public keys used to authenticate with linux based VMs.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.ISshPublicKey[]]
        $SshPublicKey,
        [Parameter(HelpMessage="Specifies the parameters that are used to add a data disk to a virtual machine.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IDataDisk[]]
        $StorageProfileDataDisk,
        [Parameter(HelpMessage="The user parameters for customers. The format of user data parameters has to be matched with the provided user data template.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IAny]
        $UserDataParameter,
        [Parameter(HelpMessage="The user data template for customers. This is a json schema template describing the format and data type of user data parameters.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IAny]
        $UserDataTemplate,
        [Parameter(HelpMessage="Specifies the virtual hard disk's uri.")]
        [string]
        $VhdUri,
        [Parameter(HelpMessage="The size of the virtual machine.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.VirtualMachineSizeTypes]
        $VirtualMachineSize
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionRoleConfiguration]::New()

        $Object.CustomProfileMetadataConfigurationPath = $CustomProfileMetadataConfigurationPath
        $Object.ImageReferenceExactVersion = $ImageReferenceExactVersion
        $Object.ImageReferenceOffer = $ImageReferenceOffer
        $Object.ImageReferencePublisher = $ImageReferencePublisher
        $Object.ImageReferenceSku = $ImageReferenceSku
        $Object.ImageReferenceVersion = $ImageReferenceVersion
        $Object.NetworkInterface = $NetworkInterface
        $Object.OSDiskName = $OSDiskName
        $Object.OSDiskOstype = $OSDiskOstype
        $Object.OSDiskSizeGb = $OSDiskSizeGb
        $Object.OSProfileAdminUsername = $OSProfileAdminUsername
        $Object.OSProfileCustomData = $OSProfileCustomData
        $Object.OSProfileCustomDataRequired = $OSProfileCustomDataRequired
        $Object.RoleName = $RoleName
        $Object.RoleType = $RoleType
        $Object.SshPublicKey = $SshPublicKey
        $Object.StorageProfileDataDisk = $StorageProfileDataDisk
        $Object.UserDataParameter = $UserDataParameter
        $Object.UserDataTemplate = $UserDataTemplate
        $Object.VhdUri = $VhdUri
        $Object.VirtualMachineSize = $VirtualMachineSize
        return $Object
    }
}

