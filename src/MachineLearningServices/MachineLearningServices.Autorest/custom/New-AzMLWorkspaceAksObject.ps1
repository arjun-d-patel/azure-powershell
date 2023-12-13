
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
Create an in-memory object for Aks.
.Description
Create an in-memory object for Aks.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20231001.Aks
.Link
https://learn.microsoft.com/powershell/module/az.MachineLearningServices/new-AzMLWorkspaceAksObject
#>
function New-AzMLWorkspaceAksObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20231001.Aks')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The description of the Machine Learning compute.")]
        [string]
        $Description,
        [Parameter(HelpMessage="Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.")]
        [bool]
        $DisableLocalAuth,
        [Parameter(HelpMessage="ARM resource id of the underlying compute.")]
        [string]
        $ResourceId,
        [Parameter(HelpMessage="Number of agents.")]
        [int]
        $AgentCount,
        [Parameter(HelpMessage="Agent virtual machine size.")]
        [string]
        $AgentVMSize,
        [Parameter(HelpMessage="An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr.")]
        [string]
        $AkNetworkingDnsServiceIP,
        [Parameter(HelpMessage="A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the Kubernetes service address range.")]
        [string]
        $AkNetworkingDockerBridgeCidr,
        [Parameter(HelpMessage="A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges.")]
        [string]
        $AkNetworkingServiceCidr,
        [Parameter(HelpMessage="Virtual network subnet resource ID the compute nodes belong to.")]
        [string]
        $AkNetworkingSubnetId,
        [Parameter(HelpMessage="Cluster full qualified domain name.")]
        [string]
        $ClusterFqdn,
        [Parameter(HelpMessage="Intended usage of the cluster.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose]
        $ClusterPurpose,
        [Parameter(HelpMessage="Load Balancer Subnet.")]
        [string]
        $LoadBalancerSubnet,
        [Parameter(HelpMessage="Load Balancer Type.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType]
        $LoadBalancerType,
        [Parameter(HelpMessage="Cert data.")]
        [string]
        $SslCert,
        [Parameter(HelpMessage="CNAME of the cert.")]
        [string]
        $SslCname,
        [Parameter(HelpMessage="Key data.")]
        [string]
        $SslKey,
        [Parameter(HelpMessage="Leaf domain label of public endpoint.")]
        [string]
        $SslLeafDomainLabel,
        [Parameter(HelpMessage="Indicates whether to overwrite existing domain label.")]
        [bool]
        $SslOverwriteExistingDomain,
        [Parameter(HelpMessage="Enable or disable ssl for scoring.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus]
        $SslStatus
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20231001.Aks]::New()
        $Object.Type = 'AKS'

        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('DisableLocalAuth')) {
            $Object.DisableLocalAuth = $DisableLocalAuth
        }
        if ($PSBoundParameters.ContainsKey('ResourceId')) {
            $Object.ResourceId = $ResourceId
        }
        if ($PSBoundParameters.ContainsKey('AgentCount')) {
            $Object.AgentCount = $AgentCount
        }
        if ($PSBoundParameters.ContainsKey('AgentVMSize')) {
            $Object.AgentVMSize = $AgentVMSize
        }
        if ($PSBoundParameters.ContainsKey('AkNetworkingDnsServiceIP')) {
            $Object.AkNetworkingConfigurationDnsServiceIP = $AkNetworkingDnsServiceIP
        }
        if ($PSBoundParameters.ContainsKey('AkNetworkingDockerBridgeCidr')) {
            $Object.AkNetworkingConfigurationDockerBridgeCidr = $AkNetworkingDockerBridgeCidr
        }
        if ($PSBoundParameters.ContainsKey('AkNetworkingServiceCidr')) {
            $Object.AkNetworkingConfigurationServiceCidr = $AkNetworkingServiceCidr
        }
        if ($PSBoundParameters.ContainsKey('AkNetworkingSubnetId')) {
            $Object.AkNetworkingConfigurationSubnetId = $AkNetworkingSubnetId
        }
        if ($PSBoundParameters.ContainsKey('ClusterFqdn')) {
            $Object.ClusterFqdn = $ClusterFqdn
        }
        if ($PSBoundParameters.ContainsKey('ClusterPurpose')) {
            $Object.ClusterPurpose = $ClusterPurpose
        }
        if ($PSBoundParameters.ContainsKey('LoadBalancerSubnet')) {
            $Object.LoadBalancerSubnet = $LoadBalancerSubnet
        }
        if ($PSBoundParameters.ContainsKey('LoadBalancerType')) {
            $Object.LoadBalancerType = $LoadBalancerType
        }
        if ($PSBoundParameters.ContainsKey('SslCert')) {
            $Object.SslConfigurationCert = $SslCert
        }
        if ($PSBoundParameters.ContainsKey('SslCname')) {
            $Object.SslConfigurationCname = $SslCname
        }
        if ($PSBoundParameters.ContainsKey('SslKey')) {
            $Object.SslConfigurationKey = $SslKey
        }
        if ($PSBoundParameters.ContainsKey('SslLeafDomainLabel')) {
            $Object.SslConfigurationLeafDomainLabel = $SslLeafDomainLabel
        }
        if ($PSBoundParameters.ContainsKey('SslOverwriteExistingDomain')) {
            $Object.SslConfigurationOverwriteExistingDomain = $SslOverwriteExistingDomain
        }
        if ($PSBoundParameters.ContainsKey('SslStatus')) {
            $Object.SslConfigurationStatus = $SslStatus
        }
        return $Object
    }
}

