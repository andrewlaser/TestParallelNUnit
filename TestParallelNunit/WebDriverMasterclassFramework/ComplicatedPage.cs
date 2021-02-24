using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace WebDriverMasterclassFramework
{
    public class ComplicatedPage : PageBase
    {
        public ComplicatedPage(IWebDriver driver) : base(driver)
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ElementIsVisible(By.Id("comments")));
            Assert.AreEqual("Complicated Page - Ultimate QA", Driver.Title);
        }

        public void Dummy()
        {

        }

        public void Open()
        {
            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/complicated-page/");
        }

        public void ClickCoursesLink()
        {
            Driver.FindElement(By.LinkText("Courses")).Click();
        }
    }
}
