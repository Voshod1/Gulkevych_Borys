using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace SeleniumTask
{
    class JobTitlePage
    {
        [FindsBy(How = How.Id, Using = "btnAdd")]
        public IWebElement buttonAdd { get; set; }
        [FindsBy(How = How.Id, Using = "btnDelete")]
        public IWebElement buttonDell { get; set; }
        [FindsBy(How = How.Id, Using = "resultTable")]
        public IWebElement listOfJobs { get; set; }
        public int checkJob(string name, string description)
        {
            var rows = listOfJobs.FindElements(By.TagName("tr"));
            int i = 0;
            foreach (var row in rows)
            {
                var rowTds = row.FindElements(By.TagName("td"));
                i++;
                if (rowTds.Count > 1)
                {
                    var data = rowTds[1].Text;
                    if ((data == name) && (rowTds[2].Text == description))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public bool check_description_changes(int i, string description)
        {
            bool result = false;
            var rows = listOfJobs.FindElements(By.TagName("tr"));
            var data = rows[i];
            if (data.FindElements(By.TagName("td"))[2].Text == description)
            {
                result = true;
            }
            return result;
        }
        public void clickOnJob(int i)
        {
            var rows = listOfJobs.FindElements(By.TagName("tr"));
            var rowWithOurJob = rows[i];
            var rob = rowWithOurJob.FindElements(By.TagName("td"));
            rob[1].FindElement(By.TagName("a")).Click();
        }
        public void deleteJob(int i)
        {
            var rows = listOfJobs.FindElements(By.TagName("tr"));
            var data = rows[i];
            data.FindElements(By.TagName("td"))[0].Click();
            buttonDell.Click();
        }
    }
}
