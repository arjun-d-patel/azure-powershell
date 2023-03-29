
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
Create an in-memory object for VirtualNetworkRule.
.Description
Create an in-memory object for VirtualNetworkRule.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.VirtualNetworkRule
.Link
https://learn.microsoft.com/powershell/module/az.ElasticSan/new-AzElasticSanVirtualNetworkRuleObject
#>
function New-AzElasticSanVirtualNetworkRuleObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.VirtualNetworkRule')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The action of virtual network rule.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.Action])]
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.Action]
        $Action,
        [Parameter(Mandatory, HelpMessage="Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.")]
        [string]
        $VirtualNetworkResourceId
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.VirtualNetworkRule]::New()

        if ($PSBoundParameters.ContainsKey('Action')) {
            $Object.Action = $Action
        }
        if ($PSBoundParameters.ContainsKey('VirtualNetworkResourceId')) {
            $Object.VirtualNetworkResourceId = $VirtualNetworkResourceId
        }
        return $Object
    }
}

