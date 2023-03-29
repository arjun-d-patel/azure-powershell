$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzContainerGroupRegularPriority.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzContainerGroupRegularPriority' {
    It 'Creates a container group with Regular Priority using latest nginx image' {
        $container = New-AzContainerInstanceObject -Name $env.containerInstanceName -Image $env.image -RequestCpu 1 -RequestMemoryInGb 1.5
        $containerGroup = New-AzContainerGroup -ResourceGroupName $env.resourceGroupName -Name $env.regularPriorityContainerGroupName -Location $env.location -Container $container -OsType $env.osType -RestartPolicy $env.restartPolicy -Priority $env.regularPriority

        $containerGroup | Should -Not -Be $null
        $containerGroup.Name | Should -Be $env.regularPriorityContainerGroupName
        $containerGroup.Location | Should -Be $env.location
        
        $containerGroup.Container | Should -Not -Be $null
        $containerGroup.Container.Count | Should -Be 1
        $containerGroup.Container[0].Name | Should -Be $env.containerInstanceName
        $containerGroup.Container[0].Image | Should -Be $env.image
        $containerGroup.Container[0].RequestCpu | Should -Be 1
        $containerGroup.Container[0].RequestMemoryInGb | Should -Be 1.5

        $containerGroup.OSType | Should -Be $env.osType
        $containerGroup.RestartPolicy | Should -Be $env.restartPolicy
        $containerGroup.Priority | Should -Be $env.regularPriority
    }
}
