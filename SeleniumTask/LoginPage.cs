using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace SeleniumTask
{
    class LoginPage
    {
        [FindsBy(How = How.Id, Using = "txtUsername")]
        public IWebElement login { get; set; }
        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement password { get; set; }
        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement buttonLogin { get; set; }
        public void log_in(string name, string pass)
        {
            //driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            //driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            //driver.FindElement(By.Id("btnLogin")).Click();
            login.SendKeys(name);
            password.SendKeys(pass);
            buttonLogin.Click();
        }
    }
}
