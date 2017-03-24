using System.IO;
using System.Threading;
using NUnit.Framework;
using OLX_UI_Tests.Pages;

namespace OLX_UI_Tests.TestCases
{
    [TestFixture]
    public class AddNewPost:TestBase
    {
        [Test]
        public void AddNewPostTest()
        {
            var email = "g.drive.test.serg@gmail.com";
            var password = "GoogleDriveVerificationTest";

            
            Pages.Pages.AddPost.Goto();
            Pages.Pages.Login.LoginToApp(email, password);
            Pages.Pages.AddPost.ClickToOtherChildCategry();

            //Assert.IsTrue(Pages.Pages.Home.IsAt());
        }
         
    }
}