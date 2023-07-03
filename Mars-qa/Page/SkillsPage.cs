using Mars_qa.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Mars_qa.Page
{
    public class SkillsPage : CommonDriver      
    {
        public void addSkills(IWebDriver driver)
        {
            //create new record
            //select skillstab
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsTab.Click();
            Thread.Sleep(2000);
            Wait.WaitToBeExists(driver, "XPath", "//div[@class='ui teal button']", 7);

            IWebElement addnewButton = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addnewButton.Click();

        }
        public void inputKeys(IWebDriver driver)
        {
            IWebElement skill1Textbox = driver.FindElement(By.Name("name"));
            skill1Textbox.SendKeys("API");
            Thread.Sleep(2000);
            IWebElement Level1Dropdown = driver.FindElement(By.Name("level"));
            Level1Dropdown.SendKeys("Intermediate");
            IWebElement add1Button = driver.FindElement(By.XPath("//input[@value='Add']"));
            add1Button.Click();
            Thread.Sleep(3000);
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnewButton = driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnewButton.Click();
            IWebElement skill2Textbox = driver.FindElement(By.Name("name"));
            skill2Textbox.SendKeys("Java");
            Thread.Sleep(2000);
            IWebElement Level2Dropdown = driver.FindElement(By.Name("level"));
            Level2Dropdown.SendKeys("Beginner");
            IWebElement add2Button = driver.FindElement(By.XPath("//input[@value='Add']"));
            add2Button.Click();
            Thread.Sleep(3000);
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnew1Button = driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnew1Button.Click();
            IWebElement skill3Textbox = driver.FindElement(By.Name("name"));
            skill3Textbox.SendKeys("Python");
            Thread.Sleep(2000);
            IWebElement Level3Dropdown = driver.FindElement(By.Name("level"));
            Level3Dropdown.SendKeys("Beginner");
            IWebElement add3Button = driver.FindElement(By.XPath("//input[@value='Add']"));
            add3Button.Click();
            Thread.Sleep(3000);
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnew2Button = driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnew2Button.Click();
            IWebElement skill4Textbox = driver.FindElement(By.Name("name"));
            skill4Textbox.SendKeys("123!@#");
            Thread.Sleep(2000);
            IWebElement Level4Dropdown = driver.FindElement(By.Name("level"));
            Level4Dropdown.SendKeys("Expert");
            IWebElement add4Button = driver.FindElement(By.XPath("//input[@value='Add']"));
            add4Button.Click();
            Thread.Sleep(3000);
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnew3Button = driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnew3Button.Click();
            IWebElement skill5Textbox = driver.FindElement(By.Name("name"));
            skill5Textbox.SendKeys("C++");
            Thread.Sleep(2000);
            IWebElement Level5Dropdown = driver.FindElement(By.Name("level"));
            Level5Dropdown.SendKeys("Beginner");
            IWebElement add5Button = driver.FindElement(By.XPath("//input[@value='Add']"));
            add5Button.Click();
            Thread.Sleep(3000);
            Wait.WaitToBeExists(driver, "XPath", "//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnew4Button = driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnew4Button.Click();
            IWebElement skill6Textbox = driver.FindElement(By.Name("name"));
            skill6Textbox.SendKeys("QWERTY");
            Thread.Sleep(2000);
            IWebElement Level6Dropdown = driver.FindElement(By.Name("level"));
            Level6Dropdown.SendKeys("Intermediate");
            IWebElement add6Button = driver.FindElement(By.XPath("//input[@value='Add']"));
            add6Button.Click();
            Thread.Sleep(3000); Wait.WaitToBeExists(driver, "XPath", "//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']", 7);
            //create new record
            IWebElement addnew5Button = driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[text()='Add New']"));
            addnew5Button.Click();
            IWebElement skill7Textbox = driver.FindElement(By.Name("name"));
            skill7Textbox.SendKeys("Postman");
            Thread.Sleep(2000);
            IWebElement Level7Dropdown = driver.FindElement(By.Name("level"));
            Level7Dropdown.SendKeys("Beginner");
            IWebElement add7Button = driver.FindElement(By.XPath("//input[@value='Add']"));
            add7Button.Click();
            Thread.Sleep(3000);
        }

        public string getInputKey1(IWebDriver driver)
        {
            IWebElement skill1Textbox = driver.FindElement(By.XPath("//td[normalize-space()='API']"));
            return skill1Textbox.Text;

        }
        public string getInputKey2(IWebDriver driver)
        {
            IWebElement skill2Textbox = driver.FindElement(By.XPath("//td[normalize-space()='Java']"));
            return skill2Textbox.Text;
        }
        public string getInputKey3(IWebDriver driver)
        {
            IWebElement skill3Textbox = driver.FindElement(By.XPath("//td[normalize-space()='Python']"));
            return skill3Textbox.Text;
        }
        public string getInputKey4(IWebDriver driver)
        {
            IWebElement skill4Textbox = driver.FindElement(By.XPath("//td[normalize-space()='123!@#']"));
            return skill4Textbox.Text;
        }
        public string getInputKey5(IWebDriver driver)
        {
            IWebElement skill5Textbox = driver.FindElement(By.XPath("//td[normalize-space()='C++']"));
            return skill5Textbox.Text;
        }
        public string getInputKey6(IWebDriver driver)
        {
            IWebElement skill6Textbox = driver.FindElement(By.XPath("//td[normalize-space()='QWERTY']"));
            return skill6Textbox.Text;
        }
        public string getInputKey7(IWebDriver driver)
        {
            IWebElement skill7Textbox = driver.FindElement(By.XPath("//td[normalize-space()='Postman']"));
            return skill7Textbox.Text;
        }
        public void editSkillInput(IWebDriver driver, string skill, string level)
        {
            //select skillstab
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsTab.Click();
            Thread.Sleep(2000);

            //Click the edit Icon
            IWebElement editIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            editIcon.Click();

            IWebElement editSkillInput = driver.FindElement(By.Name("name"));
            editSkillInput.Clear();
            editSkillInput.SendKeys(skill);
            IWebElement editlevelOption = driver.FindElement(By.Name("level"));
            editlevelOption.SendKeys(level);
            IWebElement updateLanguages = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateLanguages.Click();
            Thread.Sleep(3000);
        }
        public string GeteditSkillInput(IWebDriver driver)
        {
            IWebElement editSkillInput = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return editSkillInput.Text;
        }
        public string GeteditlevelOption(IWebDriver driver)
        {
            IWebElement editlevelOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editlevelOption.Text;
        }
        public void deleteSkill(IWebDriver driver)
        {
            //select skillstab
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
            skillsTab.Click();
            Thread.Sleep(2000);

            IWebElement deleteIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteIcon.Click();
        }
        public string getDeleteSkill(IWebDriver driver)
        {
            IWebElement deletedInput = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return deletedInput.Text;
        }
        public string getDeleteLevel(IWebDriver driver)
        {
            IWebElement deletedLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return deletedLevel.Text;
        }


    }
}
