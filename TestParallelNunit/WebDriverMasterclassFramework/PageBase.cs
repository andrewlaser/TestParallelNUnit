using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace WebDriverMasterclassFramework
{
    public class PageBase
    {
        protected readonly IWebDriver Driver;

        public PageBase(IWebDriver driver)
        {
            Driver = driver;
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

        }
    }
}
