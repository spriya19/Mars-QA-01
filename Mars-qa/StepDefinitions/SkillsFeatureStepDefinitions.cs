using Mars_qa.Page;
using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V112.Runtime;
using System;
using System.Reflection.Emit;
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
            skillsPageObj.inputKeys1(driver); 
            skillsPageObj.inputKeys2(driver);
        }

        [Then(@"Skills have been Successfully Created")]
        public void ThenSkillsHaveBeenSuccessfullyCreated()
        {
            SkillsPage skillspageObj = new SkillsPage();
            string skill1Textbox = skillspageObj.getInputKey1(driver);
            string skill2Textbox = skillspageObj.getInputKey2(driver);

            Assert.AreEqual("API", skill1Textbox, "Actual skill1Textbox and Expected skill1Textbox do not match");
            Assert.AreEqual("Java", skill2Textbox, "Actual skill2Textbox and Expected skill2Textbox do not match");

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
            string deleteOption = skillspageObj.getDeleteLevel(driver);

            Assert.AreEqual(skill, deleteInput, "Actual detele input and Expected delete input do not match ");
            Assert.AreEqual(level, deleteOption, "Actual detele option and Expected delete option do not match");

        }





    }
}
