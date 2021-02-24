using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace WebDriverMasterclassFramework
{
    public class StartPage : PageBase
    {
        private By _searchFieldLocator = By.XPath("//input[@class='et_pb_s']");

        public StartPage(IWebDriver driver) : base(driver)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            IWebElement banner = wait.Until(ElementIsVisible(By.XPath("//span[@class='et_pb_image_wrap']")));
        }

        public void Search(string txt)
        {
            //Driver.FindElement(By.Id("et_top_search")).Click();
            Actions actions = new Actions(Driver);
            actions.Click(Driver.FindElement(_searchFieldLocator)).Perform();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            IWebElement searchField = wait.Until(ElementIsVisible(_searchFieldLocator));
            searchField.SendKeys(txt + Keys.Enter);
        }

        public void OpenLink(string txt)
        {
            Driver.FindElement(By.LinkText(txt)).Click();
        }

    }
}