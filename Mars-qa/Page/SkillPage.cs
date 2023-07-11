using Mars_qa.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_qa.Page
{
    public class SkillPage : CommonDriver
    {
        private static IWebElement editIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        private static IWebElement skillTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private static IWebElement LevelTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement updatedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement updatedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
        private static IWebElement deletedSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement deletedLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));


        public void selectTab()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='second']")).Click();

        }
        public void addNewBtn()
        {

            Thread.Sleep(1000);

            // xpath of html table
            var elemTable = driver.FindElement(By.XPath("//table[@class='ui fixed table']"));
           // deleteIcon.Click();

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));

            Console.WriteLine("Length of the table rows +++  " + lstTrElem.Count);
            Thread.Sleep(500);
            if (lstTrElem.Count == 9)
            {
                for (int i = lstTrElem.Count; i >= 1; i--)
                {
                    driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / section[2] / div[1] / div[1] / div[1] / div[3] / form[1] / div[2] / div[1] / div[2] / div[1] / table[1] / tbody[1] / tr[1] / td[3] / span[2] / i[1]")).Click();

                    driver.Navigate().Refresh();
                    Thread.Sleep(3000);
                    Console.WriteLine("Record deleted " + i);
                }
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();


            }
            else
            {
                driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();
                Thread.Sleep(1000);

            }


        }
        public void fillTextField(String skill)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(skill);

        }
        public void selectValue(String skilllevel)
        {
            Thread.Sleep(1000);
            IWebElement skillLevel = driver.FindElement(By.Name("level"));
            SelectElement SelectLevel = new SelectElement(skillLevel);
            SelectLevel.SelectByValue(skilllevel);
        }
        public void levelAddBtn()
        {
            driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(1000);
        }
        public void updateSkill(string skill, string level)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='second']")).Click();

            Thread.Sleep(2000);
            editIcon.Click();
            skillTextbox.Clear();
            skillTextbox.SendKeys(skill);
            LevelTextbox.Click();
            LevelTextbox.SendKeys(level);
            updateButton.Click();

        }
        public string getVerifyUpdateSkill()
        {
            Thread.Sleep(2000);
            return updatedSkill.Text;
        }
        public string getVerifyUpdateLevel()
        {
            Thread.Sleep(2000);
            return updatedLevel.Text;
        }
        public void deleteSkill(string skill, string level)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[@data-tab='second']")).Click();
            Thread.Sleep(2000);
            // Find all rows in the table                                          
            IReadOnlyCollection<IWebElement> rows = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr"));
            Thread.Sleep(2000);

            foreach (IWebElement row in rows)
            {
                // Get the text of the first column (language column) in the row
                IWebElement skillElement = row.FindElement(By.XPath("./td[1]"));
                IWebElement skillLevel = row.FindElement(By.XPath("./td[2]"));
                string skillText = skillElement.Text;
                string skillLevelText = skillLevel.Text;
                Thread.Sleep(2000);

                // Check if the language matches the provided text
                if (skillText.Equals(skill, StringComparison.OrdinalIgnoreCase) && skillLevelText.Equals(level, StringComparison.OrdinalIgnoreCase))
                {
                    // Find and click the delete icon in the row
                    IWebElement deleteIcon = row.FindElement(By.XPath("./td[3]/span[2]/i"));
                    // Thread.Sleep(2000);
                    deleteIcon.Click();
                    Thread.Sleep(2000);
                    break;
                }
            }

        }
        public string getVerifyDeleteSkill()
        {
            Thread.Sleep(2000);
            return deletedSkill.Text;
        }
        public string getVerifyDeleteLevel()
        {
            Thread.Sleep(2000);
            return deletedLevel.Text;
        }


    }
}
