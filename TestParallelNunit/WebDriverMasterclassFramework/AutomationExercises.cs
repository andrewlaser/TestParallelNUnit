using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace WebDriverMasterclassFramework
{
    public class AutomationExercises : PageBase
    {
        private By _searchFieldLocator = By.XPath("//input[@class='et_pb_s']");

        public AutomationExercises(IWebDriver driver) : base(driver)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.Title == "Automation Practice - Ultimate QA");
            Assert.AreEqual("Automation Practice - Ultimate QA", Driver.Title);
            IWebElement banner = wait.Until(ElementIsVisible(By.LinkText("About")));
        }

        public void OpenLink(string txt)
        {
            Driver.FindElement(By.LinkText(txt)).Click();
        }

    }
}