
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
            var password = "123456";
            var title = "Test Post";
            var description =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

            //Commented if more than one post was added
            //Also location, name paremeters removed from Pages.Pages.AddPost.FillInPostForm() method
            //var name = "First Last";
            var location = "Киев, Киевская область, Дарницкий";
            var price = "100";
            var expectedMessage = "Ваше объявление принято";


            Pages.Pages.AddPost.Goto();
            Pages.Pages.Login.LoginToApp(email, password);
            Pages.Pages.AddPost.FillInPostForm(title, description, price, location);
            Pages.Pages.AddPost.ClickToFreePostOption();
            Pages.Pages.AddPost.ClcikToNextButton();
            //Pages.Pages.Payment.ClickToAddPostToTopChecbox();
            //Pages.Pages.Payment.ClickToAddPostWitoutPromotion();
            Assert.AreEqual( expectedMessage, Pages.Pages.Confirm.ConfirmMessage(), "The post does not published");            
        }       
    }
}