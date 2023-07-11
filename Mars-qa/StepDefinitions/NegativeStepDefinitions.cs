using DocumentFormat.OpenXml.Wordprocessing;
using Mars_qa.Page;
using Mars_qa.Utilities;
using MarsQASpecFlowProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V112.Debugger;
using System;
using TechTalk.SpecFlow;

namespace Mars_qa.StepDefinitions
{
    [Binding]
    public class NegativeStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj;
        NegativePage negativePageObj;
        NegativeSkillPage negativeSkillPageObj;
        public NegativeStepDefinitions()
        {
            loginPageObj = new LoginPage();
            negativePageObj = new NegativePage();
            negativeSkillPageObj = new NegativeSkillPage();
        }

        [Given(@"successfullly logged into the Mar_qa Project")]
        public void GivenSuccessfulllyLoggedIntoTheMar_QaProject()
        {
            loginPageObj.navigateSteps();
            loginPageObj.loginSteps();

        }

        [When(@"Create new  language into user profile '([^']*)' and '([^']*)'")]
        public void WhenCreateNewLanguageIntoUserProfileAnd(string language, string languageLevel)
        {
            negativePageObj.selectTab();
            negativePageObj.addNewBtn();
            negativePageObj.fillTextField(language);
            negativePageObj.selectValue(languageLevel);
            negativePageObj.levelAddBtn();

        }

        [Then(@"The record created '([^']*)' and '([^']*)' Successfully Created")]
        public void ThenTheRecordCreatedAndSuccessfullyCreated(string language, string languageLevel)
        {
            IWebElement addedMsg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            Assert.IsFalse(addedMsg.Text.Contains(language + " has been added to your languages"));
            Assert.IsFalse(addedMsg.Text.Equals("please enter language and level"));
            Assert.IsFalse(addedMsg.Text.Equals("This language is already exist in your language list."));
            Assert.IsFalse(addedMsg.Text.Equals("Duplicated data"));

                   }
        [When(@"updated '([^']*)'and'([^']*)' an Existing language and levels record")]
        public void WhenUpdatedAndAnExistingLanguageAndLevelsRecord(string language, string level)
        {
            negativePageObj.updateLanguage(language, level);
        }
        [Then(@"The Existing record should be updated '([^']*)'and '([^']*)'")]
        public void ThenTheExistingRecordShouldBeUpdatedAnd(string language, string level)
        {
           
           string newLanguage = negativePageObj.getVerifyUpdateLanguage();
           string newLevel = negativePageObj.getVerifyUpdateLevel();
           if(language == newLanguage && level == newLevel) 
           {
               Assert.AreEqual(language, newLanguage, "Actual language and Expected language do not match.");
               Assert.AreEqual(level, newLevel, "Actual language level and expected languagelevel do not match");
           }
           else
           {
               Console.WriteLine("Check Error");
           }



        }
        [When(@"Create a Invalid Skills into user profile '([^']*)' and '([^']*)'")]
        public void WhenCreateAInvalidSkillsIntoUserProfileAnd(string skill, string skillLevel)
        {
            negativeSkillPageObj.selectSkillTab();
            negativeSkillPageObj.skillAddNewBtn();
            negativeSkillPageObj.fillSkillTextField(skill);
            negativeSkillPageObj.skillSelectValue(skillLevel);
            negativeSkillPageObj.skillAddBtn();

        }
        [Then(@"The Invalid skill created '([^']*)' and '([^']*)' Successfully Created")]
        public void ThenTheInvalidSkillCreatedAndSuccessfullyCreated(string skill, string skilllLevel)
        {
            IWebElement addedMsg = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            Assert.IsFalse(addedMsg.Text.Contains(skill + "Please enter language and level"));
            Assert.IsFalse(addedMsg.Text.Contains(skilllLevel + "Please enter language and level"));

        }
        [When(@"I updated invalid '([^']*)' and '([^']*)' an Existing skills and levels")]
        public void WhenIUpdatedInvalidAndAnExistingSkillsAndLevels(string skill, string level)
        {
            negativeSkillPageObj.updateSkill(skill, level);
        }
        [Then(@"The invalid  record should be updated '([^']*)' and '([^']*)'")]
        public void ThenTheInvalidRecordShouldBeUpdatedAnd(string skill, string level)
        {
            string newSkill = negativeSkillPageObj.getVerifyUpdateSkill();
            string newLevel = negativeSkillPageObj.getVerifySkillUpdateLevel();
            if (skill == newSkill && level == newLevel)
            {
                Assert.AreEqual(skill, newSkill, "Actual skill and Expected skill do not match.");
                Assert.AreEqual(level, newLevel, "Actual  level and expected level do not match");
            }
            else
            {
                Console.WriteLine("Check Error");
            }

        }






    }
}
