$ProjectDir = (Get-Item -Path ".\" -Verbose).FullName
$SourceDir = "$ProjectDir\bin\Debug"
$OutputDir = "$ProjectDir\TestResult"
$PackagesDir = "$ProjectDir\..\packages"

$NUnit = "$PackagesDir\NUnit.ConsoleRunner.3.6.1\tools\nunit3-console.exe"

$TestSamples = (Get-ChildItem $SourceDir -Recurse -Include TestSamples.dll)

& $NUnit --framework:net-4.5 --result:$OutputDir\TestSamples.nunit.xml $TestSamples
