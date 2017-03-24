using System;
using OpenQA.Selenium;

namespace OLX_UI_Tests
{
    public static class Extensions
    {
        public static bool Exists(this IWebElement element)
        {
            try
            {
                var text = element.Text;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

    }
}