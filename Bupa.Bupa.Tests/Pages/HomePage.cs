using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Bupa.Bupa.Tests.Pages
{
    public class HomePage : BasePage        //ctrl + . na BasePage i robi konstruktor
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement AcceptCookiesButton => wait.Until(driver => driver.FindElement(By.Id("onetrust-accept-btn-handler")));
        public bool HasAcceptCookieButton => AcceptCookiesButton.Displayed;
        
        public IWebElement GetAQuoteButton => driver.FindElement(By.ClassName("btn-primary-alt "));
        public bool HasGetAQuoteButton => GetAQuoteButton.Displayed;

        public IWebElement HealthLink => driver.FindElement(By.LinkText("Health"));
        public bool HasHealthLink => HealthLink.Enabled;
        public string HealthMenuClass => HealthLink.GetAttribute("class");
        public bool IsHealthMenuActive => wait.Until(driver => HealthMenuClass == "menu-active");
        

        //public void AcceptCookiesButtonClick() => AcceptCookiesButton.Click();

        //public void GetAQuoteButtonClick() => GetAQuoteButton.Click();


        public void AcceptCookieButtonClick()
        {
            AcceptCookiesButton.Click();
        }

        public void GetAQuoteButtonClick()
        {
            GetAQuoteButton.Click();
        }

        public void HealthLinkHover()
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(HealthLink).Perform();
        }
    }
}
