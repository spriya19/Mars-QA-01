using Mars_qa.Page;
using Mars_qa.Utilities;
using MarsQASpecFlowProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Mars_qa.StepDefinitions
{
    [Binding]
    public class LanguagesFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj;
        LanguagePage languagePageObj;

        public LanguagesFeatureStepDefinitions()
        {
            loginPageObj = new LoginPage();
            languagePageObj = new LanguagePage();
        }

       [Given(@"I successfullly logged into the Mar_qa Project")]
        public void GivenISuccessfulllyLoggedIntoTheMar_QaProject()
        {
            loginPageObj.navigateSteps();
            loginPageObj.loginSteps();

        }

        [When(@"Create a language into user profile '([^']*)' and '([^']*)'")]
        public void WhenCreateALanguageIntoUserProfileAnd(string language, string languagelevel)
        {
            languagePageObj.selectTab();
            languagePageObj.addNewBtn();
            languagePageObj.fillTextField( language);
            languagePageObj.selectValue( languagelevel);
            languagePageObj.levelAddBtn();
        }

        [Then(@"The new record created '([^']*)' and '([^']*)' Successfully Created")]
        public void ThenTheNewRecordCreatedAndSuccessfullyCreated(string language, string languageLevel)
        {
            IWebElement addedMsg = driver.FindElement(By.XPath("//div[contains(text(),'has been added to your languages')]"));

            Assert.IsTrue(addedMsg.Text.Contains(language + " has been added to your languages"));


        }
        [When(@"I update '([^']*)'and'([^']*)' an Existing language and levels record")]
        public void WhenIUpdateAndAnExistingLanguageAndLevelsRecord(string language, string level)
        {
            languagePageObj.updateLanguage(language,level);
            
        }
        [Then(@"The record should be updated '([^']*)'and '([^']*)'")]
        public void ThenTheRecordShouldBeUpdatedAnd(string language, string level)
        {
            string updatedLanguage = languagePageObj.getVerifyUpdateLanguage();
            string updatedLevel = languagePageObj.getVerifyUpdateLevel();
            Assert.AreEqual(language, updatedLanguage, "Actual language and expected language do not match");
            Assert.AreEqual(level, updatedLevel, "Actual level and expected level do not match");

        }
        [When(@"I delete '([^']*)' and '([^']*)' an Existing language and levels Record")]
        public void WhenIDeleteAndAnExistingLanguageAndLevelsRecord(string language, string level)
        {
            languagePageObj.deleteLanguage( language, level);
        }
        [Then(@"The record should be deleted '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeDeletedAnd(string language, string level)
        {
            string deletedLanguage = languagePageObj.getVerifyDeleteLanguage();
            string deletedLevel = languagePageObj.getVerifyDeleteLevel();
            Assert.AreNotEqual(language, deletedLanguage, "Actual language and expected language do not match");
            Assert.AreNotEqual(level, deletedLevel, "Actual level and expected level do not match");

        }


    }
}
