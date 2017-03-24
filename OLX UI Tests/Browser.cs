using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OLX_UI_Tests
{
    public static class Browser
    {
        private static string baseUrl = "https://www.olx.ua";
        private static IWebDriver webDriver = new ChromeDriver();

        public static void Initialize()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}