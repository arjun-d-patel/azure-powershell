
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
Create an in-memory object for ProfileLogScrubbing.
.Description
Create an in-memory object for ProfileLogScrubbing.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240501Preview.ProfileLogScrubbing
.Link
https://learn.microsoft.com/powershell/module/Az.Cdn/new-AzFrontDoorCdnProfileLogScrubbingObject
#>
function New-AzFrontDoorCdnProfileLogScrubbingObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240501Preview.ProfileLogScrubbing')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="List of log scrubbing rules applied to the Azure Front Door profile logs.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240501Preview.IProfileScrubbingRules[]]
        $ScrubbingRule,
        [Parameter(HelpMessage="State of the log scrubbing config. Default value is Enabled.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState]
        $State
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240501Preview.ProfileLogScrubbing]::New()

        if ($PSBoundParameters.ContainsKey('ScrubbingRule')) {
            $Object.ScrubbingRule = $ScrubbingRule
        }
        if ($PSBoundParameters.ContainsKey('State')) {
            $Object.State = $State
        }
        return $Object
    }
}

