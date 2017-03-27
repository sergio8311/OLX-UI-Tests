using OpenQA.Selenium.Support.PageObjects;

namespace OLX_UI_Tests.Pages
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static TopNavigationPage TopNavigation
        {
            get { return GetPage<TopNavigationPage>(); }
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }
        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static AddPostPage AddPost
        {
            get { return GetPage<AddPostPage>(); }
        }

        public static ConfirmPage Confirm
        {
            get { return GetPage<ConfirmPage>(); }
        }

        public static PaymentPage Payment
        {
            get { return GetPage<PaymentPage>(); }
        }
    }
}