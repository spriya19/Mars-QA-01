using Mars_qa.Page;
using Mars_qa.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_qa.StepDefinitions
{

    [Binding]
    public class LanguageandskillFeatureStepDefinitions : CommonDriver
    {

        [Given(@"User has successfullly logged into the Mar_qa Project")]
        public void GivenUserHasSuccessfulllyLoggedIntoTheMar_QaProject()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            //Login page object identified and defined
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.loginsteps(driver);

        }

        [When(@"Create a language into user profile")]
        public void WhenCreateALanguageIntoUserProfile()
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.addLanguage(driver);
            languagePageObj.inputKeys(driver);
        }
        [Then(@"Language have been Successfully Created")]
        public void ThenLanguageHaveBeenSuccessfullyCreated()
        {
            LanguagePage languagePageObj = new LanguagePage();
            string language1Textbox = languagePageObj.getInputKey1(driver);
            string language2Textbox = languagePageObj.getInputKey2(driver);
            string language3Textbox = languagePageObj.getInputKey3(driver);
            string language4Textbox = languagePageObj.getInputKey4(driver);


            Assert.AreEqual("Spanish", language1Textbox, "Actual Language and expected Language do not match");
            Assert.AreEqual("Tamil", language2Textbox, "Actual Language and expected Language do not match");
            Assert.AreEqual("Malayalam", language3Textbox, "Actual Language and expected Language do not match");
            Assert.AreEqual("Hindi", language4Textbox, "Actual Language and expected Language do not match");

        }
        [Given(@"I update '([^']*)'and'([^']*)' an Existing language and levels record")]

        public void GivenIUpdateAndAnExistingLanguageAndLevelsRecord(string Language, string Level)
        {
            LanguagePage languagepageObj = new LanguagePage();
            languagepageObj.editedlastLanguage(driver, Language, Level);

        }
        [Then(@"The record should be updated '([^']*)'and '([^']*)'")]
        public void ThenTheRecordsShouldBeUpdatedAnd(string language, string level)
        {
            LanguagePage languagepageObj = new LanguagePage();
            string editlanguage1Input = languagepageObj.GeteditInput(driver);
            string editlevel1Option = languagepageObj.GeteditlevelOption(driver);

            Assert.AreEqual(language, editlanguage1Input, "Actual editlanguageInpu and Expected editlanguageInput do not match");
            Assert.AreEqual(level, editlevel1Option, "Actual editlevelOption and Expected editleveloption do not match");

        }

        [Given(@"I Delete '([^']*)' and '([^']*)'an Existing language and levels recod")]
        public void GivenIDeleteAndAnExistingLanguageAndLevelsRecod(string Language, string Level)
        {
            LanguagePage langpageObj = new LanguagePage();
            langpageObj.deleteLanguage(driver,Language,Level);
        }
        [Then(@"The recors should be Deleted '([^']*)' and '([^']*)'")]
        public void ThenTheRecorsShouldBeDeletedAnd(string Language, string Level)
        {
            LanguagePage languagepageObj = new LanguagePage();
            string deleteInput = languagepageObj.getDeleteLanguage(driver);

            Assert.AreEqual(Language, deleteInput, "Actual deleteInput and Expected DeleteInput");
        }
        /*[AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }*/
        
    }
}
