using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests.Pages
{
    public class LoginPage : BasePage
    {
        //public readonly IWebDriver driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            //this.driver = driver;
        }

        public IWebElement UserNameField => driver.FindElement(By.Id("user-name"));
        public IWebElement PasswordField => driver.FindElement(By.Id("password"));
        public IWebElement ButtonLogin => driver.FindElement(By.Id("login-button"));
        //public IWebElement ErrorMassage => driver.FindElement(By.CssSelector("#login_button_container > div > form > div.error-message-container.error"));
        public IWebElement ErrorMassage => driver.FindElement(By.XPath("//h3[@data-test='error']"));
        public bool HasErrorMassage => ErrorMassage.Displayed;

        public void Login(string username, string password)
        {
            UserNameField.SendKeys(username);
            PasswordField.SendKeys(password);
        }



        public void LoginButtonClick()
        {
            ButtonClick("login-button");
        }
    }


}

