using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Bupa.Bupa.Tests.Pages.QuotePages
{
    public class QuoteYourNamePage : BasePage
    {
        public QuoteYourNamePage(IWebDriver driver) : base(driver)
        {
        }

        IWebElement YourTitleField => driver.FindElement(By.Id("Prospect_ApplicantDetails_TitleCode"));

        IWebElement FirstNameField => driver.FindElement(By.Id("Prospect_ApplicantDetails_FirstName"));

        IWebElement LastNameField => driver.FindElement(By.Id("Prospect_ApplicantDetails_LastName"));

        IWebElement NextButton => driver.FindElement(By.ClassName("btn btn-primary submit-btn proceed-btn noborder btn-mob-block bg-color-light-blue"));

        //private SelectElement TitleCodeField => driver.FindElement(By.Id("Prospect_ApplicantDetails_TitleCode")).AsSelectElement();
        IWebElement MrTitle => driver.FindElement(By.XPath("//*[@id=\"Prospect_ApplicantDetails_TitleCode\"]/option[2]"));

        public void ChooseYourTitle()
        {
            YourTitleField.Click();
            MrTitle.Click();
        }
        
        public void FillYourName(string firstName, string lastName)
        {
            FirstNameField.SendKeys(firstName);
            LastNameField.SendKeys(lastName);
        }



        public enum TitleCodes
        {
            Mr = 36,
            Miss = 35,
            Mrs = 37,
            Ms = 38,
            Dr = 15,
            Professor = 43,
            Reverend = 46
        }
    }
}
