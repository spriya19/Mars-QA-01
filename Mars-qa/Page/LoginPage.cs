using Mars_qa.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_qa.Page
{
    public class LoginPage : CommonDriver
    {
        public void loginsteps(IWebDriver driver)
        {
            //Launch portal
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();

            //sign in Valid Credential
            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinButton.Click();
            IWebElement emailaddressTextbox = driver.FindElement(By.Name("email"));
            emailaddressTextbox.SendKeys("spriyak86@gmail.com");
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("121212");
            IWebElement remembermeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            remembermeCheckbox.Click();
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
