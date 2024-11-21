/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
using OpenQA.Selenium.Appium.Interactions;
using Ritech.Pages;
using Ritech.Utils;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace Ritech.Steps
{

    [Binding]
    public class FormSteps
    {
        private readonly FormPage _formPage = new FormPage();


        private readonly ScenarioContext _ScenarioContext;

        public FormSteps(ScenarioContext scenarioContext)
        {
            _ScenarioContext = scenarioContext;
        }


        [When(@"(.*) wants to fill in the form with details")]
        public void actorWantsToFillInSomeInfo(String Actor)
        {
            _formPage.NavigationBar.Actions.NavigateTo(NavIdentifiers.FORMS);
            _formPage.Actions.EnsureIsDisplayedProperly();
            _formPage.Actions.HasInput("Hello, World!")
                .TriggerSwitch();
        }

        [Then("(.*) selects \"(.*)\" from the dropdown")]
        public void actorSelectsSomethingFromTheDropdown(String Actor, String Option){
            _formPage.Dropdown.Actions
                .Open()
                .Select(Option);
        }

        [Then("(.*) submits the form")]
        public void actorSubitsTheForm(String Actor){
            _formPage.Actions.Submit();
            _formPage.AlertPopup.Actions.EnsureIsDisplayedProperly();
            _formPage.AlertPopup.Actions
                .EnsureAlertTitleIs("This button is")
                .EnsureAlertMessageIs("This button is active")
                .ClosePopup();
        }

    }
}