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

namespace Mars_qa.Page
{
    public class NegativePage : CommonDriver
    {
        private static IWebElement editIcon => driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private static IWebElement getLanguageTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement getLevelTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement updatedLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement updatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement editSkillIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private static IWebElement skillTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement LevelTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement skillUpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement skillUpdated => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement skillUpdatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));

        public void selectTab()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='first']")).Click();

        }
        public void addNewBtn()
        {

            Thread.Sleep(1000);

            // xpath of html table
            var elemTable = driver.FindElement(By.XPath("//table[@class='ui fixed table']"));

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));

            Console.WriteLine("Length of the table rows +++  " + lstTrElem.Count);

            Thread.Sleep(500);

            if (lstTrElem.Count == 6)
            {
                for (int i = lstTrElem.Count; i >= 1; i--)
                {
                    driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / section[2] / div[1] / div[1] / div[1] / div[3] / form[1] / div[2] / div[1] / div[2] / div[1] / table[1] / tbody[1] / tr[1] / td[3] / span[2] / i[1]")).Click();

                    driver.Navigate().Refresh();
                    Thread.Sleep(3000);
                    Console.WriteLine("Record deleted " + i);
                }
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[@class='ui teal button '][normalize-space()='Add New']")).Click();


            }
            else
            {
                driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[@class='ui teal button '][normalize-space()='Add New']")).Click();
                Thread.Sleep(1000);

            }
        }
        public void fillTextField(String language)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(language);

        }

        public void selectValue(String languagelevel)
        {
            Thread.Sleep(1000);
            IWebElement languageLevel = driver.FindElement(By.Name("level"));
            SelectElement SelectLevel = new SelectElement(languageLevel);
            SelectLevel.SelectByValue(languagelevel);

        }
        public void levelAddBtn()
        {
            driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();
            Thread.Sleep(1000);
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

            /*//Verify the expected message text
            string expectedMessage1 = language + " has been updated to your languages";
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
