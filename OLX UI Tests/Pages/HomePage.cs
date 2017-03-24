namespace OLX_UI_Tests.Pages
{
    public class HomePage
    {
        public void Goto()
        {
            Pages.TopNavigation.Home();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Доска объявлений OLX, раньше Slando: сайт частных объявлений в Украине - купля/продажа б/у товаров на OLX.ua");
        }
    }
}