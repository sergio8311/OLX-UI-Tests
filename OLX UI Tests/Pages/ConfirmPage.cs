using System;
using System.Linq;
using OpenQA.Selenium;

namespace OLX_UI_Tests.Pages
{
    public class ConfirmPage
    {      
        public string ConfirmMessage()
        {
            String confirmMessage =
                Browser.Driver.FindElements(By.CssSelector("div[class='clr margintop10 info successbox tcenter br3']"))
                    .FirstOrDefault(r => r.Text.Contains("Ваше объявление принято")).NullSafeToString();
            return confirmMessage;
        }       
    }
}