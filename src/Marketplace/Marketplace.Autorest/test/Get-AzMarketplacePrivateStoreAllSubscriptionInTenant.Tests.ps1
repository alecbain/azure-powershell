if(($null -eq $TestName) -or ($TestName -contains 'Get-AzMarketplacePrivateStoreAllSubscriptionInTenant'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzMarketplacePrivateStoreAllSubscriptionInTenant.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzMarketplacePrivateStoreAllSubscriptionInTenant' {
    It 'Fetch' {
        $response = Get-AzMarketplacePrivateStoreAllSubscriptionInTenant -PrivateStoreId a260d38c-96cf-492d-a340-404d0c4b3ad6
        $response | Should -Not -Be $null
        $response.value.Count | Should -BeGreaterThan 0
    }
}
