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
Migrate the classic AFD instance to Azure Front Door(Standard/Premium) profile.
MigrationWebApplicationFirewallMapping should be associated if the front door has WAF policy. Managed Identity should be associated if the frontdoor has Customer Certificates.
The change need to be committed after this.
.Description
Migrate the classic AFD instance to Azure Front Door(Standard/Premium) profile.
The change need to be committed after this.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IMigrateResult
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

MIGRATIONWEBAPPLICATIONFIREWALLMAPPING <IMigrationWebApplicationFirewallMapping[]>: Waf mapping for the migrated profile
  [MigratedFromId <String>]: Resource ID.
  [MigratedToId <String>]: Resource ID.
.Link
https://learn.microsoft.com/powershell/module/az.cdn/start-azfrontdoorcdnprofilepreparemigration

#>
function Start-AzFrontDoorCdnProfilePrepareMigration {
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PreviewMessageAttribute("This cmdlet is using a preview API version and is subject to breaking change in a future release.")]
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IMigrateResult])]
    [CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Resource group within the Azure subscription.
        ${ResourceGroupName},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.String]
        # Resource ID of the classic front door instance.
        ${ClassicResourceReferenceId},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.String]
        # Name of the new AFD Standard/Premium profile that need to be created.
        ${ProfileName},

        [Parameter(Mandatory)]
        [ValidateNotNull()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName]
        # Name of the pricing tier.
        ${SkuName},

        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IMigrationWebApplicationFirewallMapping[]]
        # Waf mapping for the migrated profile
        # To construct, see NOTES section for MIGRATIONWEBAPPLICATIONFIREWALLMAPPING properties and create a hash table.
        ${MigrationWebApplicationFirewallMapping},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Azure Subscription ID.
        ${SubscriptionId},

        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedServiceIdentityType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedServiceIdentityType]
        # Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        ${IdentityType},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api40.IUserAssignedIdentities]))]
        [System.Collections.Hashtable]
        # The set of user assigned identities associated with the resource.
        # The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        # The dictionary values can be empty objects ({}) in requests.
        ${IdentityUserAssignedIdentity},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        if (!(Get-Module -ListAvailable -Name Az.FrontDoor)) {
            Write-Host("Starting the install Az.FrontDoor module.")
            Install-Module -Name Az.FrontDoor
            # throw 'Please install Az.FrontDoor module by entering "Install-Module -Name Az.FrontDoor".'
        }
        Import-Module -Name Az.FrontDoor
        if (!(Get-Module -ListAvailable -Name Az.KeyVault)) {
            Write-Host("Starting the install Az.KeyVault module.")
            Install-Module -Name Az.KeyVault
            # throw 'Please install Az.KeyVault module by entering "Install-Module -Name Az.KeyVault".'
        }
        Import-Module -Name Az.KeyVault

        Write-Host("Starting the parameter validation process.")
        $classicResourceId = ${ClassicResourceReferenceId}.split("/")
        $frontDoorName = $classicResourceId[-1]
        $subId = $classicResourceId[2]
        $sku = ${SkuName}.ToString().ToLower()

        $context = Get-AzContext
        $localSubId = $context.Subscription.Id

        # If the ${SubscriptionId} is equal to localSubId, meaning user don't provide the SubscriptionId Parameter in the command.
        if ((${SubscriptionId} -ne $localSubId) -and (${SubscriptionId} -ne $subId)) {
            Write-Host("SubscriptionId provided is: '${SubscriptionId}")
            throw "The value of subscriptionId: '$subId' of the classic cdn in ClassicResourceReferenceId is different from the Subscription parameter provided."
        }
        
        if ($subId -ne $localSubId)
        {
            Write-Host("The subscription of classic cdn located is different from local subscription. Now set the value of subscription as: '$subId'")
            Set-AzContext -Subscription $subId
        }

        try {
            $frontDoorInfos = Get-AzFrontDoorFrontendEndpoint -ResourceGroupName ${ResourceGroupName} -FrontDoorName $frontDoorName
        } catch {
            throw "FrontDoorName: '$frontDoorName' dose not exist in the resource group: '${ResourceGroupName}'."
        }

        # Validate the parameter
        ValidateInputType
        ValidateWafPolicies
        ValidateIdentityType

        # 1. Validate whether the front door has waf policy
        #    If associated with waf policy, then waf parameter should be typed.
        # 2. Validate whether the profile has BYOC
        #    If associated with BYOC, then MSIIdentity parameter should be typed.
        
        # MigrationWebApplicationFirewallMapping parameter should only requires waf Mapping per waf instance, not the waf-endpoint association count!
        $allPoliciesWithWAF = New-Object System.Collections.Generic.HashSet[string]
        $allPoliciesWithVault = New-Object System.Collections.Generic.HashSet[string]
        foreach ($info in $frontDoorInfos) {
            $wafInfo = $info.WebApplicationFirewallPolicyLink
            if ($wafInfo) {
                $allPoliciesWithWAF.Add($wafInfo.ToLower())  | Out-Null
            }
            if ($info.Vault) {
                $vaultNameInfo = $info.Vault.split("/")[-1]
                $allPoliciesWithVault.Add($vaultNameInfo.ToLower()) | Out-Null
            }
        }

        Write-Debug("WAF linked to the frontdoor: $allPoliciesWithWAF")
        Write-Debug("Key vault name used for the frontdoor: $allPoliciesWithVault")

        if (${MigrationWebApplicationFirewallMapping}.count -ne $allPoliciesWithWAF.count) {
            throw "MigrationWebApplicationFirewallMapping parameter instance should be equal to the number of WAF policy instance in the profile."
        }

        if (($PSBoundParameters.ContainsKey('IdentityType')) -ne ($allPoliciesWithVault.count -gt 0)) {
            throw "MSIIdentity should be associated if the front door has Customer Certificates. If not, remove MSIIdentity parameter."
        }
        Write-Host("The parameters have been successfully validated.")

        # Deal with Waf policy
        if ($PSBoundParameters.ContainsKey('MigrationWebApplicationFirewallMapping')) {
            Write-Host("Starting to configure WAF policy upgrades.")

            $hasManagedRule = $false
            $wafPolicies = $PSBoundParameters.MigrationWebApplicationFirewallMapping
            foreach ($policy in $wafPolicies) {
                # ToDo: allPoliciesWithWAF use map
                if ($allPoliciesWithWAF -NotContains $policy.MigratedFromId) {
                    throw "WAF policy: '$migrateFromId' does not exist in the profile. WAF policy provided should exist in the profile."
                }
                # Validate the Sku argument, if a managed waf associated, then the profile only can migrated to Premium tier. 
                $migrateFromWafPreperty = GetMigrateWafProperty -MigrateWafResourceId $policy.MigratedFromId
                if ($migrateFromWafPreperty.ManagedRules) {
                    $hasManagedRule = $true
                    if (($sku -ne "premium_azurefrontdoor")) {
                        throw "The AFD (classic) instance has managed WAF rules associated, and it can only be migrated to Premium tier. If you want to migrate to Standard tier, please remove the association on AFD (classic) and migrate afterwards."
                    }
                }
            }
           
            # Validate whether MigratedToId policy already exists in the subsrciption; 
            foreach ($policy in $wafPolicies) {
                $migrateToWafId = $policy.MigratedToId
                $migrateToWafArray = $policy.MigratedToId.split("/")
                try {
                    $existed = Get-AzFrontDoorWafPolicy -ResourceGroupName $migrateToWafArray[4] -Name $migrateToWafArray[8] -ErrorAction Stop
                }
                catch {
                    if ($migrateToWafArray[4] -ne ${ResourceGroupName}) {
                        throw "The copied new WAF policy should to be created in the same resource group with the classic front door's: '${ResourceGroupName}'."
                    }
                    $migrateFromWafPreperty = GetMigrateWafProperty -MigrateWafResourceId $policy.MigratedFromId
                    CreateNewWafPolicy -ResourceGroupName $migrateToWafArray[4] -Name $migrateToWafArray[8] -WafProperty $migrateFromWafPreperty -ManagedRuleMigrateFromWaf $hasManagedRule
                }
                if ($existed -and $hasManagedRule) { 
                    if ((!$existed.ManagedRules) -and ($existed.Sku.ToLower() -ne "premium_azurefrontdoor")) {
                        throw "Please check parameter migrateToId: '$migrateToWafId'. The AFD (classic) instance has managed WAF rules associated, and it can only be migrated to Premium tier."
                    }
                }
            }
            Write-Host("WAF policy upgrades have been configured successfully.")
        }

        # Create AFDx Profile
        # If create AfdX profile firstly, then an error ("Invalid migrated to waf reference.") will be thrown if the migrated-To-WAF is supposed to created. (not exists in current subscription)
        Write-Host("Your new Front Door profile is being created. Please wait until the process has finished completely. This may take several minutes.")
        $null = $PSBoundParameters.Remove('IdentityType')
        $null = $PSBoundParameters.Remove('IdentityUserAssignedIdentity')
        # # Deal with difference between PS5 and PS7.
        # No need to add this parameters here, cx may add this parameter when using this command.
        # $PSBoundParameters.Add('ErrorAction', 'Stop')

        # Upgrade subcriptionId
        $PSBoundParameters['SubscriptionId'] =  $subId
        Az.Cdn.internal\Move-AzCdnProfile @PSBoundParameters

        Write-Host("Your new Front Door profile with the configuration has been successfully created.")
        
        # Deal with MSI parameter
        # if ($PSBoundParameters.ContainsKey('IdentityType')) {
        if ($allPoliciesWithVault.count -gt 0) {
            Write-Host("Starting to enable managed identity.")

            # Waiting for results of profile created return
            Start-Sleep(20)

            # 1. Enable MSI: get "principalId" from RP
            $commandArgs = @{ ResourceGroupName = ${ResourceGroupName}; Name = ${ProfileName}; IdentityType = ${IdentityType}; ErrorAction = 'Stop'}
            if ($indentityType -ne "systemassigned") {
                $commandArgs.Add('IdentityUserAssignedIdentity', ${IdentityUserAssignedIdentity})
            }
            
            $enableMSISuccessMessage = 'Enabling managed identity succeeded.'
            $enableMSIRetryMessage = 'Retrying to enable managed identity...'
            $enableMSIErrorMessage = "Enableing managed identity failed."
            $profileIdentity = RetryCommand -Command 'Update-AzFrontDoorCdnProfile' -CommandArgs $commandArgs -RetryTimes 6 -SecondsDelay 20 -SuccessMessage $enableMSISuccessMessage -RetryMessage $enableMSIRetryMessage -ErrorMessage $enableMSIErrorMessage
            $identity = [System.Collections.ArrayList]@()
            foreach ($id in $profileIdentity.IdentityUserAssignedIdentity.Values.PrincipalId) {
                if ($id) {
                    $identity.Add($id) | Out-Null
                }
            }

            if ($profileIdentity.IdentityPrincipalId){
                $identity.Add($profileIdentity.IdentityPrincipalId) | Out-Null
            }

            # Waiting for MSI granted access...
            Start-Sleep(20)
            Write-Host("Starting to grant managed identity to key vault.")
            foreach ($vault in $allPoliciesWithVault) {
                foreach ($principal in $identity) {
                    $grantAccessSuccessMessage = 'Granting managed identity to key vault succeeded.'
                    $grantAccessRetryMessage = 'Retrying to grant managed identity to key vault...'
                    $grantAccessErrorMessage = 'Granting managed identity to key vault failed.'

                    $commandInfo = @{ VaultName = $vault; ObjectId = $principal; PermissionsToSecrets = 'Get'; PermissionsToCertificates = 'Get'; ErrorAction = 'Stop'; BypassObjectIdValidation = $true}

                    # Set-AzKeyVaultAccessPolicy -VaultName $vault -ObjectId $principal -PermissionsToSecrets Get -PermissionsToCertificates Get
                    # Adding the parameter `-BypassObjectIdValidation` to bypass the validation when using pipeline to do migration, the type of `-BypassObjectIdValidation` is 'SwitchParameter'.
                    RetryCommand -Command 'Set-AzKeyVaultAccessPolicy' -CommandArgs $commandInfo -RetryTimes 6 -SecondsDelay 20 -SuccessMessage $grantAccessSuccessMessage -RetryMessage $grantAccessRetryMessage -ErrorMessage $grantAccessErrorMessage
                }
            }

            Write-Host("Your have successfully granted managed identity to key vault.")
        }

        Write-Host("The change need to be committed after this.")
    }
}

function ValidateInputType {
    $validateResourceIdReg = "^/subscriptions/[A-Fa-f0-9]{8}(?:-[A-Fa-f0-9]{4}){3}-[A-Fa-f0-9]{12}/resourcegroups/(?<resourceGroupName>[^/]+)/providers/microsoft.network/frontdoors/(?<frontDoorName>[^/]+)$"
    if (${ClassicResourceReferenceId} -notmatch $validateResourceIdReg) {
        throw "The format of ClassicResourceReferenceId: '${ClassicResourceReferenceId}', supposed to be like $validateResourceIdReg"
    }

    # $subscriptionId = $classicResourceId[2]
    # if (${SubscriptionId} -ne $subscriptionId)
    # {
    #     throw "Subscription parameter:${SubscriptionId}, should be in the same subscriptionId in ClassicResourceReferenceId..."
    # }
    $resourceGroup = $classicResourceId[4]
    if (${ResourceGroupName} -ne $resourceGroup) {
        throw "ResourceGroupName parameter: ${ResourceGroupName},  should be in the same resourceGroup in ClassicResourceReferenceId..."
    }

    if (${ProfileName} -notmatch '^[a-zA-Z0-9]+(-*[a-zA-Z0-9])*$') {
        throw "The value must begin with a letter or number, and may contain only letters, numbers or hyphens. It must end with a letter or number..."
    }

    if (${ProfileName}.Length -gt 260)
    {
        throw "Maximum 
         ProfileName property is: 260."
    }
    
    # Check if the profile already exists in the resourceGroup
    
    try {
        $existedProfile = Get-AzFrontDoorCdnProfile -ResourceGroupName $resourceGroup -Name ${ProfileName} -ErrorAction Stop
    } catch {
        Write-debug("Validation of the parameter 'ProfileName' was successful.")
    }

    if ($existedProfile) {
        throw "The profile name: '${ProfileName}' is already in use. Please use a new profile name."
    }

    if (($sku -ne "standard_azurefrontdoor") -and ($sku -ne "premium_azurefrontdoor"))
    {
        throw "'$sku' + is not a valid Sku. Only Standard_AzureFrontDoor and Premium_AzureFrontDoor Skus are allowed."
    }
}

function ValidateIdentityType {
    if (${IdentityType}) {
        $identityTypeArray =  ${IdentityType}.ToString().split(",")
        if (($identityTypeArray.Count -gt 2)) {
            throw "The IdentityType is invalid. The supported types are 'SystemAssigned,UserAssigned' when the front door has Customer Certificates during migration."
        }
        foreach($identity in $identityTypeArray) {
            $id = $identity.Trim().ToLower()
            if (($id -ne "userassigned") -and ($id -ne "systemassigned")) {
                throw "The IdentityType is invalid. The supported types are 'SystemAssigned,UserAssigned' when the front door has Customer Certificates during migration."
            }
            if ($id -eq "userassigned") {
                if (${IdentityUserAssignedIdentity}.count -eq 0) {
                    throw "Identities should not be empty or null to be assigned when using User Assigned type."
                }
            }
        }
    }
}

function ValidateWafPolicies{
    if (${MigrationWebApplicationFirewallMapping}.count -gt 0) {
        $wafPolicies = ${MigrationWebApplicationFirewallMapping}
        $theSubId = $wafPolicies[0].MigratedFromId.split("/")[2] 
        
        $validateWafIdReg = '/subscriptions/[A-Fa-f0-9]{8}(?:-[A-Fa-f0-9]{4}){3}-[A-Fa-f0-9]{12}/resourceGroups/(?<resourceGroupName>[^/]+/providers/Microsoft.Network/frontdoorWebApplicationFirewallPolicies/*'
        $migrationFromError = "The format of the WAF MigrateFromId should be like '$validateWafIdReg'."
        $migrationToError = "The format of the WAF MigrateToId should be like '$validateWafIdReg'."

        # Validate the format of the waf policy and the migrateFrom.Id whether exists in the profile.
        $validateWafIdReg = "^/subscriptions/[A-Fa-f0-9]{8}(?:-[A-Fa-f0-9]{4}){3}-[A-Fa-f0-9]{12}/resourcegroups/(?<resourceGroupName>[^/]+)/providers/microsoft.network/frontdoorwebapplicationfirewallpolicies/(?<policyName>[^/]+)$"
        foreach ($policy in $wafPolicies) {
            # add validation to check the migrateFrom and migrateTo cannot be null.
            if (-not $policy.MigratedFromId -or -not $policy.MigratedToId) {
                throw 'MigratedFrom and MigratedTo properties cannot be empty'
            }
            
            if ($policy.MigratedFromId.ToLower() -notmatch $validateWafIdReg) {
                throw $migrationFromError
            }
            if ($policy.MigratedToId.ToLower() -notmatch $validateWafIdReg) {
                throw $migrationToError
            }

            $migrateToSub = $policy.MigratedToId.split("/")[2]
            $migrateToName = $policy.MigratedToId.split("/")[8]
            if ($migrateToSub -ne $theSubId) {
                throw "The subscription of existing or created WAF policy should be in the same subscription as the classic AFD WAF policy's."
            }
            if ($migrateToName -notmatch '(^[a-zA-Z]+)\w+$') {
                throw "The WAF policy name must begin with a letter, and may only contain numbers and letters."
            }

            if ($migrateToName.Length -gt 260)
            {
                throw "Maximum WAF policy name property is: 260."
            }
        }
    }
}

# Get the property of waf policy associated with classic Afd
function GetMigrateWafProperty {
    param (
        [string]$MigrateWafResourceId
    )

    return Get-AzFrontDoorWafPolicy -ResourceGroupName $MigrateWafResourceId.split("/")[4] -Name $MigrateWafResourceId.split("/")[8]
}


# Corresponding to "Copy to a new waf policy"
function CreateNewWafPolicy {
    param (
        [string]$ResourceGroupName,
        [string]$Name,
        [Microsoft.Azure.Commands.FrontDoor.Models.PSTrackedResource]$WafProperty,
        [bool]$ManagedRuleMigrateFromWaf
    )

    # $sku = ${SkuName}.ToLower()
    if ($sku -eq "premium_azurefrontdoor") {
        $sku = "premium_azurefrontdoor"
    } elseif ($ManagedRuleMigrateFromWaf) {
        $sku = "premium_azurefrontdoor"
    } else {
        $sku = "standard_azurefrontdoor"
    }

    # Remove the null/empty property
    $validatedWafProperty = ValidateMigrationWafPolicyProperty -WafProperty $WafProperty

    # New a waf policy, copied from the Migrtae
    New-AzFrontDoorWafPolicy -ResourceGroupName $ResourceGroupName -Name $Name -Sku $sku @validatedWafProperty  | Out-Null
}

# Validate the property of a waf policy
function ValidateMigrationWafPolicyProperty {
    param (
        [Microsoft.Azure.Commands.FrontDoor.Models.PSTrackedResource]$WafProperty
    )

    $wafHash = @{}
    if ($WafProperty.PolicyEnabledState) {
        $wafHash.Add('EnabledState', $WafProperty.PolicyEnabledState)
    } 
    if ($WafProperty.PolicyMode) {
        $wafHash.Add('Mode', $WafProperty.PolicyMode)
    }
    if ($WafProperty.CustomRules) {
        $wafHash.Add('Customrule', $WafProperty.CustomRules)
    }
    if ($WafProperty.ManagedRules) {
        $wafHash.Add('ManagedRule', $WafProperty.ManagedRules)
    }
    if ($WafProperty.RedirectUrl) {
        $wafHash.Add('RedirectUrl', $WafProperty.RedirectUrl)
    }
    if ($WafProperty.CustomBlockResponseStatusCode) {
        $wafHash.Add('CustomBlockResponseStatusCode', $WafProperty.CustomBlockResponseStatusCode)
    }
    if ($WafProperty.CustomBlockResponseBody) {
        $wafHash.Add('CustomBlockResponseBody', $WafProperty.CustomBlockResponseBody)
    }
    if ($WafProperty.RequestBodyCheck) {
        $wafHash.Add('RequestBodyCheck', $WafProperty.RequestBodyCheck)
    }
    
    return $wafHash
}

function RetryCommand {
    param (
        [string]$Command,
        [hashtable]$CommandArgs, 
        [int]$RetryTimes,
        [int]$SecondsDelay,
        [string]$SuccessMessage,
        [string]$RetryMessage,
        [string]$ErrorMessage
    )

    $retryCount = 0
    $completed = $false

    while (-not $completed) {
        try {
            & $Command @CommandArgs
            Write-Host ("{0}" -f $SuccessMessage)
            $completed = $true
            return $res
        } 
        catch {
            if ($retryCount -ge $RetryTimes) {
                Write-Host ("{0}" -f $ErrorMessage)
                Write-Debug ("Command [{0}] failed the maximum number of {1} times." -f $Command, $retryCount)
                throw
            } else {
                Write-Host ("{0}" -f $RetryMessage)
                Write-Debug ("Command [{0}] loading..." -f $command)
                Start-Sleep $SecondsDelay
                $retryCount++
            }
        }
    }
}