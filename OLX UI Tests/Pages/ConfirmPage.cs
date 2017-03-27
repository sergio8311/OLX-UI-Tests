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
                Browser.Driver.FindElement(By.CssSelector("p[class='xxx-large lheight24']")).Text.NullSafeToString();
                   
            return confirmMessage;
        }        
    }
}