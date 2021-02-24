using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebDriverMasterclassFramework
{
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class TestBase
    {
        protected readonly Helper _helper = new Helper();
        protected IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = _helper.GetChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
            Driver = null;
        }

    }
}
