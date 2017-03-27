using System.Security.Cryptography.X509Certificates;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OLX_UI_Tests.Pages
{
    public class PaymentPage
    {

        [FindsBy(How = How.CssSelector, Using = "input[value='topads_7']")]
        public IWebElement addPostToTopCheckbox;

        [FindsBy(How = How.Id, Using = "submit-without-promotion")]
        public IWebElement addPostWithoutPromotionButton;

        public void ClickToAddPostToTopChecbox()
        {
            Thread.Sleep(2000);
            addPostToTopCheckbox.Click();
        }

        public void ClickToAddPostWitoutPromotion()
        {
            addPostWithoutPromotionButton.Submit();
        }
    }
}