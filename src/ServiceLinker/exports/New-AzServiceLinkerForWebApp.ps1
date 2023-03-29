
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
Create or update linker resource in webapp.
.Description
Create or update linker resource in webapp.
.Example
$target=New-AzServiceLinkerAzureResourceObject -Id /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/servicelinker-test-group/providers/Microsoft.DBforPostgreSQL/servers/servicelinker-postgresql/databases/test

$authInfo=New-AzServiceLinkerSecretAuthInfoObject -Name testUser -SecretValue ***  

New-AzServiceLinkerForWebApp -TargetService $target -AuthInfo $auth -ClientType dotnet -LinkerName testLinker -WebApp servicelinker-app -ResourceGroupName servicelinker-test-group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

AUTHINFO <IAuthInfoBase>: The authentication type.
  AuthType <AuthType>: The authentication type.

TARGETSERVICE <ITargetServiceBase>: The target service properties
  Type <TargetServiceType>: The target service type.
.Link
https://learn.microsoft.com/powershell/module/az.servicelinker/new-azservicelinkerforwebapp
#>
function New-AzServiceLinkerForWebApp {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ILinkerResource])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Path')]
    [System.String]
    # The fully qualified Azure Resource manager identifier of the resource to be connected.
    ${ResourceUri},

    [Parameter()]
    [Alias('LinkerName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.DefaultInfo(Script='"connect_"+(-join ((65..90) + (97..122) | Get-Random -Count 5 | % {[char]$_}))')]
    [System.String]
    # The name Linker resource.
    ${Name},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Header')]
    [System.String]
    # .
    ${XmsServiceconnectorUserToken},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IAuthInfoBase]
    # The authentication type.
    # To construct, see NOTES section for AUTHINFO properties and create a hash table.
    ${AuthInfo},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ITargetServiceBase]
    # The target service properties
    # To construct, see NOTES section for TARGETSERVICE properties and create a hash table.
    ${TargetService},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ClientType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.DefaultInfo(Script='"none"')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ClientType]
    # The application client type
    ${ClientType},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType]
    # Optional, indicate whether to apply configurations on source application.
    # If enable, generate configurations and applied to the source application.
    # Default is enable.
    # If optOut, no configuration change will be made on source.
    ${ConfigurationInfoAction},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfoAdditionalConfigurations]))]
    [System.Collections.Hashtable]
    # A dictionary of additional configurations to be added.
    # Service will auto generate a set of basic configurations and this property is to full fill more customized configurations
    ${ConfigurationInfoAdditionalConfiguration},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfoCustomizedKeys]))]
    [System.Collections.Hashtable]
    # Optional.
    # A dictionary of default key name and customized key name mapping.
    # If not specified, default key name will be used for generate configurations
    ${ConfigurationInfoCustomizedKey},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType]
    # Allow Azure services to access the target service if true.
    ${FirewallRuleAzureService},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.AllowType]
    # Allow caller client IP to access the target service if true.
    # the property is used when connecting local application to target service.
    ${FirewallRuleCallerClientIP},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [System.String[]]
    # This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account.
    ${FirewallRuleIPRange},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.ActionType]
    # Optional.
    # Indicates public network solution.
    # If enable, enable public network access of target service with best try.
    # Default is enable.
    # If optOut, opt out public network access configuration.
    ${PublicNetworkSolutionAction},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [System.String]
    # connection scope in source service.
    ${Scope},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [System.String]
    # The key vault id to store secret
    ${SecretStoreKeyVaultId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [System.String]
    # The key vault secret name to store secret, only valid when storing one secret
    ${SecretStoreKeyVaultSecretName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.VNetSolutionType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Support.VNetSolutionType]
    # Type of VNet solution.
    ${VNetSolutionType},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.String]
    # [ResourceGroupCompleter]
    # The resource group of the resource to be connected.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.String]
    # [ResourceNameCompleter("Microsoft.Web/sites", nameof(ResourceGroupName))]
    # The Name of webapp of the resource to be connected.
    ${WebApp},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription ID which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.ServiceLinker.custom\New-AzServiceLinkerForWebApp';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Name')) {
            $PSBoundParameters['Name'] = "connect_"+(-join ((65..90) + (97..122) | Get-Random -Count 5 | % {[char]$_}))
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('ClientType')) {
            $PSBoundParameters['ClientType'] = "none"
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
