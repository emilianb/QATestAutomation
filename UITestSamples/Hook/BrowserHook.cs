namespace UITestSamples.Hook
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using TechTalk.SpecFlow;

    [Binding]
    public static class BrowserHook
    {
        [BeforeScenario]
        public static void StartBrowser()
        {
            // retrieve the current scenario context
            var context = ScenarioContext.Current;

            // create a new driver instance
            var driver = new ChromeDriver();
            // set the period the driver should try to find an element before throwing an error
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // store the driver in the current scenario context
            context.Set(driver, "Driver");
        }

        [AfterScenario]
        public static void StopBrowser()
        {
            // retrieve context
            var context = ScenarioContext.Current;

            // retrieve the driver from the current scenario context
            var driver = context.Get<IWebDriver>("Driver");

            // close all windows and the browser
            driver.Quit();
        }
    }
}
