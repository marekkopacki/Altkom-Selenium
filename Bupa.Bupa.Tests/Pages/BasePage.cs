using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bupa.Tests.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        public string title => driver.Title;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
