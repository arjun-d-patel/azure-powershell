
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
Create an in-memory object for QuotaBaseProperties.
.Description
Create an in-memory object for QuotaBaseProperties.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.QuotaBaseProperties
.Link
https://learn.microsoft.com/powershell/module/az.MLWorkspace/new-AzMLWorkspaceQuotaPropertiesObject
#>
function New-AzMLWorkspaceQuotaPropertiesObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.QuotaBaseProperties')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Specifies the resource ID.")]
        [string]
        $Id,
        [Parameter(HelpMessage="The maximum permitted quota of the resource.")]
        [long]
        $Limit,
        [Parameter(HelpMessage="Specifies the resource type.")]
        [string]
        $Type,
        [Parameter(HelpMessage="An enum describing the unit of quota measurement.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.QuotaUnit])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.QuotaUnit]
        $Unit
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.QuotaBaseProperties]::New()

        if ($PSBoundParameters.ContainsKey('Id')) {
            $Object.Id = $Id
        }
        if ($PSBoundParameters.ContainsKey('Limit')) {
            $Object.Limit = $Limit
        }
        if ($PSBoundParameters.ContainsKey('Type')) {
            $Object.Type = $Type
        }
        if ($PSBoundParameters.ContainsKey('Unit')) {
            $Object.Unit = $Unit
        }
        return $Object
    }
}

