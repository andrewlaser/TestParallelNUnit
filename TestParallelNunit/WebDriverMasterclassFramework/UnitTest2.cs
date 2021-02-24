using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebDriverMasterclassFramework
{
    [Parallelizable(ParallelScope.All)]
    public class UnitTest2 : TestBase
    {
        [Test]
        public void CTestMethod1()
        {
            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/complicated-page/");
            ComplicatedPage complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.ClickCoursesLink();
            CoursesPage coursesPage = new CoursesPage(Driver);

            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/complicated-page/");
            complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.ClickCoursesLink();
            coursesPage = new CoursesPage(Driver);

        }
        [Test]
        public void ATest2()
        {
            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/");
            StartPage startPage = new StartPage(Driver);
            startPage.Search("Complicated Page");
            Thread.Sleep(1000);
            startPage.OpenLink("Complicated Page");
            ComplicatedPage complicatedPage = new ComplicatedPage(Driver);

            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/");
            startPage = new StartPage(Driver);
            startPage.OpenLink("Automation Exercises");
            AutomationExercises automationExercises = new AutomationExercises(Driver);

        }

        [Test]
        public void BTest3()
        {
            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/");
            StartPage startPage = new StartPage(Driver);
            Thread.Sleep(1000);
            startPage.OpenLink("Automation Exercises");
            AutomationExercises automationExercises = new AutomationExercises(Driver);

            Driver.Navigate().GoToUrl(@"https://ultimateqa.com/complicated-page/");
            ComplicatedPage complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.ClickCoursesLink();
            CoursesPage coursesPage = new CoursesPage(Driver);

        }
    }
}