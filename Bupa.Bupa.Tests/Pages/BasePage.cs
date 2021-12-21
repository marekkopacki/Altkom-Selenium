using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bupa.Tests.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;
        protected WebDriverWait wait;
        public string title => driver.Title;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public void GoToUrl(string url) => driver.Navigate().GoToUrl(url);

        public string Title => driver.Title;
        
        /*public void GetTitle(string title)
        {
            bool HasPageTitle => wait.Until(driver => driver.Title);           
        }*/

        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
