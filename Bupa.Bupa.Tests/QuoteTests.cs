using Bupa.Bupa.Tests.Pages;
using Bupa.Bupa.Tests.Pages.QuotePages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bupa.Tests
{
    [TestClass]
    public class QuoteTests
    {
        private HomePage homePage;
        private QuoteYourNamePage quoteYourNamePage;

        private IWebDriver driver;

        private const string url = "https://www.bupa.co.uk/";

        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            quoteYourNamePage = new QuoteYourNamePage(driver);
        }

        [TestMethod]
        public void Quote_GetAQuote_ShouldRedirectToQuoteYourNamePage()
        {

            homePage.GoToUrl(url);
            homePage.AcceptCookieButtonClick();

        
            if(homePage.HasGetAQuoteButton == true)
            {
            homePage.GetAQuoteButtonClick();
            }
        }
    }
}
