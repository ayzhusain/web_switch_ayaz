using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace Webapp123
{
    [Binding]
    public class NewUserSteps
    {
        IWebDriver driver = null;
        [Given(@"You are on the reguser page")]
        public void GivenYouAreOnTheReguserPage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:8397/reguser.html");
        }
        [Given(@"You are on the login page")]
        public void GivenYouAreOnTheLoginPage()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:8397/Login.html");
        }


        [When(@"fill in your user name")]
        public void WhenFillInYourUserName()
        {
            driver.FindElement(By.Id("username")).SendKeys("Marita");
        }
        
        [When(@"fill in your password")]
        public void WhenFillInYourPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("Admin");
        }

        [When(@"fill in email")]
        public void WhenFillInEmail()
        {
            driver.FindElement(By.Id("email")).SendKeys("email@email.com");
        }
        

        [When(@"click on register")]
        public void WhenClickOnRegister()
        {
            driver.FindElement(By.Id("regbutton")).Click();
        }
        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            driver.FindElement(By.Id("login")).Click();
        }


        [Then(@"registered should appare")]
        public void ThenRegisteredShouldAppare()
        {
            Assert.True(driver.Title == "Login", "Login");
        }        
        [Then(@"Welcome user should appare")]
        public void ThenWelcomeUserShouldAppare()
        {
            Assert.True(driver.Title == "Login", "Login");
        }
    }
}
