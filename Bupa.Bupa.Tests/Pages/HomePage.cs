using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Bupa.Tests.Pages
{
    public class HomePage : BasePage        //ctrl + . na BasePage i robi konstruktor
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement AcceptCookiesButton => driver.FindElement(By.)
    }
}
