using Mars_qa.Page;
using Mars_qa.Utilities;
using MarsQASpecFlowProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Mars_qa.StepDefinitions
{
    [Binding]
    public class SkillsFeatureStepDefinitions:CommonDriver
    {
        LoginPage loginPageObj;
        SkillPage skillPageObj;
        public SkillsFeatureStepDefinitions()
        {
            loginPageObj = new LoginPage();
            skillPageObj = new SkillPage();
        }

        [Given(@"User successfullly logged into the Mar_qa Project")]
        public void GivenUserSuccessfulllyLoggedIntoTheMar_QaProject()
        {
            loginPageObj.navigateSteps();
            loginPageObj.loginSteps();

        }

        [When(@"Create a Skills into user profile '([^']*)' and '([^']*)'")]
        public void WhenCreateASkillsIntoUserProfileAnd(string skill, string skilllevel)
        {
            skillPageObj.selectTab();
            skillPageObj.addNewBtn();
            skillPageObj.fillTextField(skill);
            skillPageObj.selectValue(skilllevel);
            skillPageObj.levelAddBtn();

        }

        [Then(@"The new skill created '([^']*)' and '([^']*)' Successfully Created")]
        public void ThenTheNewSkillCreatedAndSuccessfullyCreated(string skill, string skillLevel)
        {
            IWebElement addedMsg = driver.FindElement(By.XPath("//div[contains(text(),'has been added to your skills')]"));

            Assert.IsTrue(addedMsg.Text.Contains(skill + " has been added to your skills"));

        }
        [When(@"I update '([^']*)' and '([^']*)' an Existing skills and levels")]
        public void WhenIUpdateAndAnExistingSkillsAndLevels(string skill, string level)
        {
            skillPageObj.updateSkill(skill, level);

        }
        [Then(@"The record should be updated '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeUpdatedAnd(string skill, string level)
        {
            string updatedSkill = skillPageObj.getVerifyUpdateSkill();
            string updatedLevel = skillPageObj.getVerifyUpdateLevel();
            Assert.AreEqual(skill, updatedSkill, "Actual skill and expected skill do not match");
            Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");
        }
        [When(@"I delete '([^']*)' and '([^']*)' an Existing skill and level")]
        public void WhenIDeleteAndAnExistingSkillAndLevel(string skill, string level)
        {
            skillPageObj.deleteSkill(skill, level);
        }
        [Then(@"The Existing record should be deleted '([^']*)' and '([^']*)'")]
        public void ThenTheExistingRecordShouldBeDeletedAnd(string skill, string level)
        {
            string deleteSkill = skillPageObj.getVerifyDeleteSkill();
            string deleteLevel = skillPageObj.getVerifyDeleteLevel();
            Assert.AreNotEqual(skill, deleteSkill, "Actual skill and expected skill do not match");
            Assert.AreNotEqual(level, deleteLevel, "Actual level and expected level do not match");
        }



    }
}
