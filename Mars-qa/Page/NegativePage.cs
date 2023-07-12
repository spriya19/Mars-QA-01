using Mars_qa.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Configuration.AppConfig;
using NUnit.Framework;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace Mars_qa.Page
{
    public class NegativePage : CommonDriver
    {
        private static IWebElement addnewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addlanguageTextbox => driver.FindElement(By.Name("name"));
        private static IWebElement languageLevelOption => driver.FindElement(By.Name("level"));
        private static IWebElement addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement newLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private static IWebElement newLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        private static IWebElement editIcon => driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private static IWebElement getLanguageTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement getLevelTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement updatedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement updatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
        public void AddLanguage(string language, string level)
        {

            addnewButton.Click();
            addlanguageTextbox.SendKeys(language);
            languageLevelOption.SendKeys(level);
            addButton.Click();
            Thread.Sleep(3000);
            //get the text of the message element
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);

            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            //Verify the expected message text
            string expectedMessage1 = language + " has been updated to your languages";
            string expectedMessage2 = "Please enter language and level";
            string expectedMessage3 = "This language is already added to your language list.";

            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));

        }
        public string GetVerifyLanguageAdd()
        {
            return newLanguage.Text;
        }
        public string GetVerifyLevelAdd()
        {
            return newLevel.Text;
        }

        public void updateLanguage(string language, string level)
        {
            Thread.Sleep(2000);
            editIcon.Click();
            getLanguageTextbox.Clear();
            getLanguageTextbox.SendKeys(language);
            getLevelTextbox.Click();
            getLevelTextbox.SendKeys(level);
            Thread.Sleep(2000);
            updateButton.Click();
            Thread.Sleep(2000);
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Thread.Sleep(2000);
            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            //Verify the expected message text
            /*string expectedMessage1 = language + " has been updated to your languages";
            string expectedMessage2 = "Please enter language and level";
            string expectedMessage3 = "This language is already added to your language list.";

            Assert.That(actualMessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3));*/
        }
    
        public string getVerifyUpdateLanguage()
        {
            Thread.Sleep(2000);
            return updatedLanguage.Text;
        }
        public string getVerifyUpdateLevel()
        {
            Thread.Sleep(2000);
            return updatedLevel.Text;
        }
        

    }
}
