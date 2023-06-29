using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_qa.Page
{
    public class LanguagePage : CommonDriver
    {
        public void addLanguage(IWebDriver driver)
        {
           
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Language']//following-sibling::th[@class='right aligned']/div[text()='Add New']",7);
           //create new record
            IWebElement addnewButton = driver.FindElement(By.XPath("//th[text()='Language']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnewButton.Click();
        }
        public void inputKeys1(IWebDriver driver) 
        {
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys("Spanish");
            Thread.Sleep(2000);
            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.SendKeys("Basic");
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
        }
        public void inputKeys2(IWebDriver driver) 
        {
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Language']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnewButton = driver.FindElement(By.XPath("//th[text()='Language']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnewButton.Click();
            IWebElement languageTextbox = driver.FindElement(By.Name("name"));
            languageTextbox.SendKeys("Tamil");
            Thread.Sleep(2000);
            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.SendKeys("Native/Billingual");
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
        }
        public string getInputKey1(IWebDriver driver) 
        {
            IWebElement language1Textbox = driver.FindElement(By.XPath("//td[normalize-space()='Spanish']"));
           return language1Textbox.Text;

        }
        public string getInputKey2(IWebDriver driver) 
        {
            IWebElement language2Textbox = driver.FindElement(By.XPath("//td[normalize-space()='Tamil']"));
            return language2Textbox.Text;

        }
        public void editedlastLanguage(IWebDriver driver, string language ,string level)
        {
            //Click the edit Icon
            IWebElement editedIcon = driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            editedIcon.Click();

            IWebElement editlanguageInput = driver.FindElement(By.Name("name"));
            editlanguageInput.Clear();
            editlanguageInput.SendKeys(language);
            IWebElement editlevelOption = driver.FindElement(By.Name("level"));
            editlevelOption.SendKeys(level);
            IWebElement updateLanguages = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateLanguages.Click();
            Thread.Sleep(3000);

        }
        public string GeteditlanguageInput(IWebDriver driver)
        {
            IWebElement editlanguageInput = driver.FindElement(By.XPath("//td[normalize-space()='Spanish']"));
            return editlanguageInput.Text;
        }
        public string GeteditlevelOption(IWebDriver driver)
        {
            IWebElement editlevelOption = driver.FindElement(By.XPath("//td[normalize-space()='Basic']"));
            return editlevelOption.Text;
        }
        public void deleteLanguage(IWebDriver driver)
        {
            IWebElement deleteIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteIcon.Click();
        }
        public string getDeleteLanguage(IWebDriver driver)
        {
            IWebElement deletedInput = driver.FindElement(By.XPath("//td[normalize-space()='Spanish']"));
            return deletedInput.Text;
        }
        public string getDeleteLevel(IWebDriver driver)
        {
            IWebElement deleteOption = driver.FindElement(By.XPath("//td[normalize-space()='Basic']"));
            return deleteOption.Text;
        }
    }
}
        


    

