using System;
using System.Reflection.Emit;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace OLX_UI_Tests.Pages
{
    public class AddPostPage
    {
        [FindsBy(How = How.Id, Using = "add - title")]
        private IWebElement titleTextField;

        [FindsBy(How = How.Id, Using = "targetrenderSelect1-0")]
        private IWebElement categoryDropDown;

        [FindsBy(How = How.Id, Using = "cat-36")]
        [CacheLookup]
        private IWebElement childCategoryButton;

        [FindsBy(How = How.CssSelector, Using = "a[data-category='71']")]
        [CacheLookup]
        private IWebElement otherChildGoodsSubCategoryButton;





        public void Goto()
        {
            Pages.TopNavigation.AddPost();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Объявление добавляется • OLX.ua");
        }

        public void ClickToOtherChildCategry()
        {
            OpenCategoryDropdown();
            childCategoryButton.Click();
            otherChildGoodsSubCategoryButton.Click();       
        }

        public void OpenCategoryDropdown()
        {
            categoryDropDown.Click();
        }
    }
}