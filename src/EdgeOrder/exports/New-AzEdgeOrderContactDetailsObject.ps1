
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
Create an in-memory object for ContactDetails.
.Description
Create an in-memory object for ContactDetails.
.Example
$contactDetail = New-AzEdgeOrderContactDetailsObject -ContactName ContactName -EmailList @("emailId") -Phone Phone

ContactName    : random
EmailList      : {"emailId"}
Mobile         :
Phone          : 1234567890
PhoneExtension :

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetails
.Link
https://learn.microsoft.com/powershell/module/az.EdgeOrder/new-AzEdgeOrderContactDetailsObject
#>
function New-AzEdgeOrderContactDetailsObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetails])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String]
    # Contact name of the person.
    ${ContactName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String[]]
    # List of Email-ids to be notified about job progress.
    ${EmailList},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String]
    # Phone number of the contact person.
    ${Phone},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String]
    # Mobile number of the contact person.
    ${Mobile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Category('Body')]
    [System.String]
    # Phone extension number of the contact person.
    ${PhoneExtension}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.EdgeOrder.custom\New-AzEdgeOrderContactDetailsObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
