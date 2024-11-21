/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
using Ritech.Pages;
using TechTalk.SpecFlow;

namespace Ritech.Steps
{

    [Binding]
    public class LoginSteps
    {
        private readonly LoginFormPage _LoginFormPage = new LoginFormPage();


        private readonly ScenarioContext _ScenarioContext;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _ScenarioContext = scenarioContext;
        }

        private void setupLogin()
        {
            _LoginFormPage.Actions.EnsureIsDisplayedProperly();
            _LoginFormPage.Actions.GotoLoginTab();
            _LoginFormPage.LoginFormComponent.Actions.EnsureIsDisplayedProperly();
        }


        [When(@"(.*) enters the correct credentials")]
        public void actorEntersCorrectCredentials(String Actor)
        {
            setupLogin();
            _LoginFormPage.LoginFormComponent.Actions
                .TypeEmail("qatester@test.com")
                .TypePassword("12345678")
                .PressLoginButton();
        }

        [When(@"(.*) enters a malformed email address")]
        public void actorEntersMalformedEmail(String Actor)
        {
            setupLogin();
            _LoginFormPage.LoginFormComponent.Actions
                .TypeEmail("invalid-email")
                .TypePassword("12345678")
                .PressLoginButton();
        }

        [When(@"(.*) enters an insecure password")]
        public void actorEntersInsecurePassword(String Actor)
        {
            setupLogin();
            _LoginFormPage.LoginFormComponent.Actions
                .TypeEmail("qatester@test.com")
                .TypePassword("1234")
                .PressLoginButton();
        }

        [When(@"(.*) enters invalid credentials")]
        public void actorEntersInvalidCredentials(String Actor)
        {
            setupLogin();
            _LoginFormPage.LoginFormComponent.Actions
                .TypeEmail("invalid-email")
                .TypePassword("1234")
                .PressLoginButton();
        }

        [When(@"(.*) enters empty credentials")]
        public void actorEntersEmptyCredentials(String Actor)
        {
            setupLogin();
            _LoginFormPage.LoginFormComponent.Actions
                .PressLoginButton();
        }

        [Then(@"(.*) will see a success alert")]
        public void actorCanSeeASuccessAlertPopup(String Actor)
        {
            _LoginFormPage.AlertPopup.Actions.EnsureIsDisplayedProperly();
            _LoginFormPage.AlertPopup.Actions
                .EnsureAlertTitleIs("Success")
                .EnsureAlertMessageIs("You are logged in!")
                .ClosePopup();
        }

        [Then("^(.*) will see the \"(.*)\" message$")]
        public void actorCanSeeTheErrorMessage(String Actor, String Message)
        {
            _LoginFormPage.Actions.EnsureErrorIsDisplayed(Message);
        }

    }
}