using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace SeleniumTask
{
    class SitePage
    {
        [FindsBy(How = How.Id, Using = "menu_admin_viewAdminModule")]
        public IWebElement viewModuleAdmin { get; set; }
        [FindsBy(How = How.Id, Using = "menu_admin_Job")]
        public IWebElement menuAdminJob { get; set; }
        [FindsBy(How = How.Id, Using = "menu_admin_viewJobTitleList")]
        public IWebElement viewJobTitleList { get; set; }
        public void goToJobTitles()
        {
            //driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();
            //driver.FindElement(By.Id("menu_admin_Job")).Click();
            //driver.FindElement(By.Id("menu_admin_viewJobTitleList")).Click();
            viewModuleAdmin.Click();
            menuAdminJob.Click();
            viewJobTitleList.Click();
        }
    }
}
