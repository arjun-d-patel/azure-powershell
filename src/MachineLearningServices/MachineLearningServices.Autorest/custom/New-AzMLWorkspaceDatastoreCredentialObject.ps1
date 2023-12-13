
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
Create an in-memory object for CertificateDatastoreCredentials.
.Description
Create an in-memory object for CertificateDatastoreCredentials.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20231001.CertificateDatastoreCredentials
.Link
https://learn.microsoft.com/powershell/module/az.MachineLearningServices/new-AzMLWorkspaceDatastoreCredentialObject
#>
function New-AzMLWorkspaceDatastoreCredentialObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20231001.CertificateDatastoreCredentials')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Authority URL used for authentication.")]
        [string]
        $AuthorityUrl,
        [Parameter(Mandatory, HelpMessage="[Required] Service principal client ID.")]
        [string]
        $ClientId,
        [Parameter(HelpMessage="Resource the service principal has access to.")]
        [string]
        $ResourceUrl,
        [Parameter(Mandatory, HelpMessage="[Required] ID of the tenant to which the service principal belongs.")]
        [string]
        $TenantId,
        [Parameter(Mandatory, HelpMessage="[Required] Thumbprint of the certificate used for authentication.")]
        [string]
        $Thumbprint,
        [Parameter(Mandatory, HelpMessage="[Required] Service principal certificate.")]
        [string]
        $Certificate
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20231001.CertificateDatastoreCredentials]::New()
        $Object.CredentialsType = 'Certificate'
        $Secret = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20231001.CertificateDatastoreSecrets]::New()
        $Secret.SecretsType = 'Certificate'
        if ($PSBoundParameters.ContainsKey('AuthorityUrl')) {
            $Object.AuthorityUrl = $AuthorityUrl
        }
        if ($PSBoundParameters.ContainsKey('ClientId')) {
            $Object.ClientId = $ClientId
        }
        if ($PSBoundParameters.ContainsKey('ResourceUrl')) {
            $Object.ResourceUrl = $ResourceUrl
        }
        if ($PSBoundParameters.ContainsKey('Secret')) {
            $Object.Secret = $Secret
        }
        if ($PSBoundParameters.ContainsKey('TenantId')) {
            $Object.TenantId = $TenantId
        }
        if ($PSBoundParameters.ContainsKey('Thumbprint')) {
            $Object.Thumbprint = $Thumbprint
        }
        if ($PSBoundParameters.ContainsKey('Certificate')) {
            $Secret.Certificate = $Secret
        }
        $Object.Secret = $Secret
        return $Object
    }
}

