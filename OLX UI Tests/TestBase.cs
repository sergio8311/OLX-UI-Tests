using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OLX_UI_Tests
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public static void Initialize()
        {
            Browser.Initialize();
        }

        [TearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

    }
}
