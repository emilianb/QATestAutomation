namespace FluentUITestSamples.Hook
{
    using FluentAutomation;
    using System.Diagnostics;
    using TechTalk.SpecFlow;

    [Binding]
    public static class BrowserHook
    {
        [BeforeScenario]
        public static void StartBrowser()
        {
            var browsers = new[] { SeleniumWebDriver.Browser.Chrome };
            SeleniumWebDriver.Bootstrap(browsers);
        }

        [BeforeTestRun]
        public static void StopBrowser()
        {
            // this will kill the chromedriver so it won't hang in case of errors
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Kill();
            }
        }
    }
}
