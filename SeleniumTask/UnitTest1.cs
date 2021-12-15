using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace SeleniumTask
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.log_in("Admin", "admin123");
            var sitepage = new SitePage();
            PageFactory.InitElements(driver, sitepage);
            sitepage.goToJobTitles();
            var jobsPage = new JobTitlePage();
            PageFactory.InitElements(driver, jobsPage);
            jobsPage.buttonAdd.Click();
            var addingEditing = new AddPage();
            PageFactory.InitElements(driver, addingEditing);
            addingEditing.addJob("Game Designer", "Student Game Designer", "This is note");
            int numberOfAddedJob = jobsPage.checkJob("Game Designer", "Student Game Designer") - 1;
            Assert.IsFalse(numberOfAddedJob == -1, "isfalse==-1");
            jobsPage.clickOnJob(numberOfAddedJob);
            addingEditing.modifyJobDescription("Intern Game Designer");
            Assert.IsFalse(jobsPage.check_description_changes(numberOfAddedJob, "Intern Game Designer") == false);
            jobsPage.deleteJob(numberOfAddedJob);
            driver.FindElement(By.Id("dialogDeleteBtn")).Click();
            Assert.IsTrue(jobsPage.checkJob("Game Designer", "Student Game Designer") == -1);
            System.Threading.Thread.Sleep(2000);
            driver.Quit();
        }
    }
}