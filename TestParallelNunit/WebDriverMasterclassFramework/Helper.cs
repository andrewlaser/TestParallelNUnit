using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverMasterclassFramework
{
    public class Helper
    {
        public IWebDriver GetChromeDriver()
        {
            string outputDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outputDir);
        }

        public void Highlight(IWebDriver driver, By locator)
        {
            IWebElement element = driver.FindElement(locator);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(@"arguments[0].setAttribute('style', 'background-color:#00FF00')", element);

        }

    }
}

