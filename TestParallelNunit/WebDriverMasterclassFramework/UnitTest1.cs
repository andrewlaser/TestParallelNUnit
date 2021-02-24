using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebDriverMasterclassFramework
{
    [Parallelizable(ParallelScope.All)]
    public class UnitTest1 : TestBase
    {
        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/");
            StartPage startPage = new StartPage(Driver);
            startPage.Search("Complicated Page");
            Thread.Sleep(1000);
            startPage.OpenLink("Complicated Page");
            ComplicatedPage complicatedPage = new ComplicatedPage(Driver);
        }

        [Test]
        public void Test3()
        {
            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/");
            StartPage startPage = new StartPage(Driver);
            startPage.OpenLink("Automation Exercises");
            AutomationExercises automationExercises = new AutomationExercises(Driver);
        }

        [Test]
        public void TestMethod4()
        {
            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/");
            StartPage startPage = new StartPage(Driver);
            startPage.OpenLink("Automation Exercises");
            AutomationExercises automationExercises = new AutomationExercises(Driver);

            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/complicated-page/");
            ComplicatedPage complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.ClickCoursesLink();
            CoursesPage coursesPage = new CoursesPage(Driver);


        }

    }
}