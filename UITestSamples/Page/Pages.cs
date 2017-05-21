namespace UITestSamples.Page
{
    using OpenQA.Selenium;
    using System;
    using TechTalk.SpecFlow;

    public static  class Pages
    {
        public static T Get<T>()
        {
            T page;

            // retrieve current scenarion context
            var context = ScenarioContext.Current;
            // compute type of requested page
            var typeOfPage = typeof(T);

            // if the page instance is in scenario context return it from there
            if (context.TryGetValue(typeOfPage.FullName, out page)) return page;

            // retrieve driver from context
            var driver = context.Get<IWebDriver>("Driver");

            // create page instance
            page = (T)Activator.CreateInstance(typeof(T), driver);

            // store page instance into scenario context
            context.Set(page, typeOfPage.FullName);

            return page;
        }

        public static void Set<T>(T page)
        {
            // retrieve current scenarion context
            var context = ScenarioContext.Current;
            // compute type of requested page
            var typeOfPage = typeof(T);

            // store page instance into scenario context
            context.Set(page, typeOfPage.FullName);
        }
    }
}
