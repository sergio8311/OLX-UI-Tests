using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OLX_UI_Tests.Pages
{
    public class AddPostPage
    {
        [FindsBy(How = How.Id, Using = "add-title")]
        private IWebElement titleTextField;

        [FindsBy(How = How.Id, Using = "targetrenderSelect1-0")]
        private IWebElement categoryDropDown;

        [FindsBy(How = How.Id, Using = "cat-36")]
        [CacheLookup]
        private IWebElement childCategoryButton;

        [FindsBy(How = How.CssSelector, Using = "a[data-category='71']")]
        [CacheLookup]
        private IWebElement otherChildGoodsSubCategoryButton;

        [FindsBy(How = How.Id, Using = "add-description")]
        private IWebElement descriptionTextField;

        [FindsBy(How = How.Id, Using = "mapAddress")]
        public IWebElement mapAddressField;

        [FindsBy(How = How.Id, Using = "add-person")]
        public IWebElement nameTextField;

        [FindsBy(How = How.CssSelector, Using = "input[value='Опубликовать']")]
        public IWebElement nextButton;

        [FindsBy(How = How.Id, Using = "autosuggest-geo-ul")]
        public IWebElement autoSuggestedLocation;

        [FindsBy(How = How.Id, Using = "parameter-free")]
        public IWebElement priceFree;

        [FindsBy(How = How.CssSelector, Using = "input[name='data[param_price][1]']")]
        public IWebElement priceTextField ;

        [FindsBy(How = How.Id, Using = "targetparam13")]
        [CacheLookup]
        public IWebElement conditionDropdown;

        [FindsBy(How = How.XPath, Using = "//*[@id='targetparam13']/dd/ul/li[2]/a")]
        [CacheLookup]
        public IWebElement usedConditionOption;

        [FindsBy(How = How.Id, Using = "targetid_private_business")]
        public IWebElement businessOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='targetid_private_business']/dd/ul/li[2]/a")]
        public IWebElement privateBusinessOption;

        [FindsBy(How = How.CssSelector, Using = "label[for='paypack3']")]
        public IWebElement freePostOption;

 
        public void ClickToFreePostOption()
        {
            freePostOption.Click();
        }

        public void ClickToUsedCondition()
        {
            conditionDropdown.Click();
            usedConditionOption.Click();
        }

        public void ClickToPrivateBusinessOption()
        {
            businessOption.Click();
            privateBusinessOption.Click();
        }

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

        public void ClcikToNextButton()
        {
            nextButton.Submit();            
        }

        public void SelectFreePrice()
        {
            priceFree.Click();
        }

        public void ClearAddressField()
        {
            mapAddressField.Clear();
        }

        public void FillInPostForm(string title, string description, string price, string location)
        {
            ClearAddressField();
            titleTextField.SendKeys(title);
            ClickToOtherChildCategry();
            descriptionTextField.SendKeys(description);                  
            mapAddressField.SendKeys(location);
            autoSuggestedLocation.Click();
            priceTextField.SendKeys(price);
            //Commented in case if more than one post was published
            //nameTextField.SendKeys(name);
            ClickToUsedCondition();
            ClickToPrivateBusinessOption();         
        }

    }
}