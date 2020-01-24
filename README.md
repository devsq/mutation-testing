# mutation-testing
More information about stryker cen be found at:
https://stryker-mutator.io/stryker-net/index

## Install stryker 
dotnet tool install -g dotnet-stryker

### navigate to the root of test folder
cd DevSquare.MutationTesting.Tests

### run striker with html report and progress
dotnet stryker --reporters "['html', 'progress']"
