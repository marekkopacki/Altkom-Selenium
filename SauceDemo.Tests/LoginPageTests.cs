using SauceDemo.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests
{
    [TestClass]
    public class LoginPageTests
    {
        private readonly IWebDriver driver;

        private const string url = "https://www.saucedemo.com/";

        private LoginPage loginPage;
        private ProductPage productPage;

        public LoginPageTests()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);
        }
        [TestInitialize]
        public void Setup()
        {
            //Arrange
            loginPage = new LoginPage(driver);
            productPage = new ProductPage(driver);
        }

        [TestMethod]
        public void Login_WithValidUsernameAndPassword_ShouldTitleProductPageDisplayed()
        {
            // Arrange
            /*LoginPage loginPage = new LoginPage(driver);
            ProductPage productPage = new ProductPage(driver);*/

            // Act
            loginPage.Login("standard_user", "secret_sauce");
            loginPage.LoginButtonClick();

            // Assert // *1 porównuje tytuł strony z wartością która driver pobiera do stringa w productpage
            Assert.AreEqual("Swag Labs", productPage.title);
        }

        [TestMethod]
        public void Login_LockedOutUser_ShouldErrorMassagesDisplayed()
        {
            //Arrange
            /*LoginPage loginPage = new LoginPage(driver);*/

            //Act
            loginPage.Login("locked_out_user", "secret_sauce");
            loginPage.LoginButtonClick();

            //Assert
            Assert.IsTrue(loginPage.HasErrorMassage);
        }

        [TestCleanup]

        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
