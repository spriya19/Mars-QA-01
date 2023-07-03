using Mars_qa.Page;
using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_qa.StepDefinitions
{
    [Binding]
    public class SkillsFeatureStepDefinitions :CommonDriver

    {
        [Given(@"User has successfully logged into the Mar_qa application")]
        public void GivenUserHasSuccessfullyLoggedIntoTheMar_QaApplication()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            //Login page object identified and defined
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.loginsteps(driver);
        }

        [When(@"Create skills in the user profile")]
        public void WhenCreateSkillsInTheUserProfile()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.addSkills(driver);
            skillsPageObj.inputKeys(driver); 
        }

        [Then(@"Skills have been Successfully Created")]
        public void ThenSkillsHaveBeenSuccessfullyCreated()
        {
            SkillsPage skillspageObj = new SkillsPage();
            string skill1Textbox = skillspageObj.getInputKey1(driver);
            string skill2Textbox = skillspageObj.getInputKey2(driver);
            string skill3Textbox = skillspageObj.getInputKey3(driver);
            string skill4Textbox = skillspageObj.getInputKey4(driver);
            string skill5Textbox = skillspageObj.getInputKey5(driver);
            string skill6Textbox = skillspageObj.getInputKey6(driver);
            string skill7Textbox = skillspageObj.getInputKey7(driver);

            Assert.AreEqual("API", skill1Textbox, "Actual skill1Textbox and Expected skill1Textbox do not match");
            Assert.AreEqual("Java", skill2Textbox, "Actual skill2Textbox and Expected skill2Textbox do not match");
            Assert.AreEqual("Python", skill3Textbox, "Actual skill2Textbox and Expected skill2Textbox do not match");
            Assert.AreEqual("123!@#", skill4Textbox, "Actual skill2Textbox and Expected skill2Textbox do not match");
            Assert.AreEqual("C++", skill5Textbox, "Actual skill2Textbox and Expected skill2Textbox do not match");
            Assert.AreEqual("QWERTY", skill6Textbox, "Actual skill2Textbox and Expected skill2Textbox do not match");
            Assert.AreEqual("Postman", skill7Textbox, "Actual skill2Textbox and Expected skill2Textbox do not match");
        }
        [When(@"I update '([^']*)' and '([^']*)' anExisting skills and levels")]
        public void WhenIUpdateAndAnExistingSkillsAndLevels(string skill, string level)
        {
            SkillsPage skillPageObj = new SkillsPage();
            skillPageObj. editSkillInput(driver, skill, level);

        }
        [Then(@"The record should be updated '([^']*)' and '([^']*)'")]
        
        public void ThenTheRecordShouldBeUpdatedAnd(string skill, string level)
        {
           SkillsPage skillpageObj= new SkillsPage();
            string editSkillInput = skillpageObj.GeteditSkillInput(driver);
            string editlevelOption = skillpageObj.GeteditlevelOption(driver);

            Assert.AreEqual(skill, editSkillInput, "Actual editskillinput and Expected editskillInput do not match");
            Assert.AreEqual(level, editlevelOption, "Actual editlevelOption and Expected editleveloption do not match");
        }
        [When(@"I delete '([^']*)' and '([^']*)' an Existing skills and levels")]
        public void WhenIDeleteAndAnExistingSkillsAndLevels(string skill, string level)
        {
            SkillsPage skillspageObj = new SkillsPage();
            skillspageObj.deleteSkill(driver);
        }
        [Then(@"The record should be deleted '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeDeletedAnd(string skill, string level)
        {
            SkillsPage skillspageObj = new SkillsPage();
            string deleteInput = skillspageObj.getDeleteSkill(driver);

            Assert.AreEqual(skill, deleteInput, "Actual detele input and Expected delete input do not match ");
        }
        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
        
    }
}
