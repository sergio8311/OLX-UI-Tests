
using NUnit.Framework;

namespace OLX_UI_Tests.TestCases
{
    [TestFixture]
    public class AddNewPost:TestBase
    {
        [Test]
        public void AddNewPostTest()
        {
            var email = "sergey8311@gmail.com";
            var password = "19831107";
            var title = "Test Post";
            var description =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            var name = "First Last";
            var location = "Киев, Киевская область, Дарницкий";
            var price = "100";
            var expectedMessage = "Ваше объявление принято";


            Pages.Pages.AddPost.Goto();
            Pages.Pages.Login.LoginToApp(email, password);
            Pages.Pages.AddPost.FillInPostForm(title, description, location, price, name);
            Pages.Pages.AddPost.ClickToFreePostOption();
            Pages.Pages.AddPost.ClcikToSubmitButton();
            Assert.AreEqual( expectedMessage, Pages.Pages.Confirm.ConfirmMessage(), "The post does not published");            
        }
         
    }
}