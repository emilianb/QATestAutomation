$ProjectDir = (Get-Item -Path ".\" -Verbose).FullName
$FeatureDir = "$ProjectDir\Specification"
$OutputDir = "$ProjectDir\Documentation"
$LinkResultsDir = "$ProjectDir\TestResult"
$PackagesDir = "$ProjectDir\..\packages"

$Pickles = "$PackagesDir\Pickles.CommandLine.2.15.0\tools\pickles.exe"

& $Pickles --feature-directory:$FeatureDir --output-directory:$OutputDir --link-results-file:$LinkResultsDir\FluentUITestSamples.nunit.xml --test-results-format=nunit3 --documentation-format=dhtml
