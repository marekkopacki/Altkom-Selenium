using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;

namespace SauceDemo.Tests.Pages
{
    public class ProductPage : BasePage
    {
        //protected readonly IWebDriver driver;

        public ProductPage(IWebDriver driver) : base(driver)
        {
           // this.driver = driver;
        }

        //dirver pobiera tytuł do stringa i w testach porównuje z wartością ze strony *1
        //public string TitleProductPage => driver.Title;

        public new string title => driver.Title;

        //public bool HasTitleProductPage => TitleProductPage == "Swag Labs";

        //Assert.AreEqual("Swag Labs", driver);
    }
}
