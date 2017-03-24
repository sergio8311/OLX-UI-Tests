using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OLX_UI_Tests.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.XPath, Using = "//div[1]/section/div/div/ul/li[1]/div/form/fieldset/div[1]/div/input[@id='userEmail']")]
        [CacheLookup]
        private IWebElement emailTextField;

        [FindsBy(How = How.XPath, Using = "//section/div/div/ul/li[1]/div/form/fieldset/div[2]/div/input[@id='userPass']")]
        [CacheLookup]
        private IWebElement passwordTextField;

        [FindsBy(How = How.XPath, Using = "//section/div/div/ul/li[1]/div/form/fieldset/button[@id='se_userLogin']")]
        [CacheLookup]
        private IWebElement logInButton;

        public void LoginToApp(string email, string password)
        {
            emailTextField.SendKeys(email);
            passwordTextField.SendKeys(password);

            logInButton.Click();
        }
    }
}