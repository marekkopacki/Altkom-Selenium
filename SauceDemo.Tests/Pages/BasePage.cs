using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;       // protected - dopuszcza do klasy jedynie swoje dzieci. Nie ma dostępu z zewnątrz z innej klasy.
        public string title => driver.Title;

        //public IWebElement button;

        public void ButtonClick(string buttonName)
        {
            IWebElement button = driver.FindElement(By.Id(buttonName));

            button.Click();
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
