if(($null -eq $TestName) -or ($TestName -contains 'Update-AzSpringAppDeployment'))
{
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzSpringAppDeployment.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Update-AzSpringAppDeployment' {
    It 'UpdateExpanded' {
        $deploy = Update-AzSpringAppDeployment -ResourceGroupName $env.resourceGroup -ServiceName $env.standardSpringName01 -AppName $env.appGateway -Name $env.greenDeploymentName
    }

    It 'UpdateViaIdentityExpanded' {
        $deploy = Get-AzSpringAppDeployment -ResourceGroupName $env.resourceGroup -ServiceName $env.standardSpringName01 -AppName $env.appGateway -Name $env.greenDeploymentName
        Update-AzSpringAppDeployment -InputObject $deploy    
    }
}
