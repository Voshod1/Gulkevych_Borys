using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace SeleniumTask
{
    class AddPage
    {
        [FindsBy(How = How.Id, Using = "jobTitle_jobTitle")]
        public IWebElement jobTitle { get; set; }
        [FindsBy(How = How.Id, Using = "jobTitle_jobDescription")]
        public IWebElement jobDescription { get; set; }
        [FindsBy(How = How.Id, Using = "jobTitle_note")]
        public IWebElement jobNote { get; set; }
        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement buttonSave { get; set; }
        public void addJob(string title, string description, string note)
        {
            jobTitle.SendKeys(title);
            jobDescription.SendKeys(description);
            jobNote.SendKeys(note);
            buttonSave.Click();
        }
        public void modifyJobDescription(string newNote)
        {
            buttonSave.Click();
            jobDescription.Clear();
            jobDescription.SendKeys(newNote);
            buttonSave.Click();
        }
    }
}
