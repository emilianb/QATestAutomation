namespace FluentUITestSamples.Hook
{
    using TechTalk.SpecFlow;

    public static class BrowserHook
    {
        [BeforeScenario]
        public static void StartBrowser()
        {
        }

        [AfterScenario]
        public static void StopBrowser()
        {
        }
    }
}
