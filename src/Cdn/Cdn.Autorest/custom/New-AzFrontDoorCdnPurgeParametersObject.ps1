
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
Create an in-memory object for AfdPurgeParameters.
.Description
Create an in-memory object for AfdPurgeParameters.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240501Preview.AfdPurgeParameters
.Link
https://learn.microsoft.com/powershell/module/Az.Cdn/new-AzFrontDoorCdnPurgeParametersObject
#>
function New-AzFrontDoorCdnPurgeParametersObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240501Preview.AfdPurgeParameters')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="The path to the content to be purged. Can describe a file path or a wild card directory.")]
        [string[]]
        $ContentPath,
        [Parameter(HelpMessage="List of domains.")]
        [string[]]
        $Domain
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240501Preview.AfdPurgeParameters]::New()

        if ($PSBoundParameters.ContainsKey('ContentPath')) {
            $Object.ContentPath = $ContentPath
        }
        if ($PSBoundParameters.ContainsKey('Domain')) {
            $Object.Domain = $Domain
        }
        return $Object
    }
}

