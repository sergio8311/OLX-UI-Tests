using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OLX_UI_Tests.Pages
{
    public class TopNavigationPage
    {
        [FindsBy(How = How.Id, Using = "headerLogo")]
        private IWebElement homeLink;

        [FindsBy(How = How.Id, Using = "topLoginLink")]
        private IWebElement logInLink;

        [FindsBy(How = How.Id, Using = "postNewAdLink")]
        private IWebElement addPostLink;


        public void Home()
        {
            homeLink.Click();
        }

        public void LogIn()
        {
            logInLink.Click();
        }

        public void AddPost()
        {
            addPostLink.Click();
        }
    }
}