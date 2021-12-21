using Bupa.Bupa.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bupa.Bupa.Tests
{
    [TestClass]
    public class HomePageTests
    {
        private HomePage homePage;
        private IWebDriver driver;

        private const string url = "https://www.bupa.co.uk/";

        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);

        }

        [TestMethod]
        public void Navigate_AcceptCookies_ShouldHealthLinkClickable()
        {
            homePage.GoToUrl(url);

            homePage.AcceptCookieButtonClick();

            homePage.HealthLinkHover();

            Assert.IsTrue(homePage.IsHealthMenuActive);

            //homePage.GetAQuoteButtonClick();
        }

        [TestCleanup]
        public void Cleanup() => homePage.CleanUp();
        /*{
            homePage.CleanUp();
        }*/
    }
}
