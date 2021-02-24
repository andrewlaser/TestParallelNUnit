using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace WebDriverMasterclassFramework
{
    public class CoursesPage : PageBase
    {
        public CoursesPage(IWebDriver driver) : base(driver)
        {
            WebDriverWait  wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(d => d.Title == "Ultimate QA");
            Assert.AreEqual("Ultimate QA", Driver.Title);
        }
    }
}