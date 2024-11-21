using Ritech.Pages;
using Ritech.Utils;
using TechTalk.SpecFlow;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Steps
{
    
    [Binding]
    public class StartScreenSteps
    {
        private readonly StartPage _StartPage = new StartPage();


        [Given(@"(.*) is a user of webdriverio app")]
        public void actorIsAUserOfWebdriverioApp(String Actor){
            _StartPage.NavigationBar.Actions.NavigateTo(NavIdentifiers.HOME);
            _StartPage.EnsureIsDisplayed();
        }

        [When(@"(.*) wants to login")]
        public void actorWantsToLogin(String Actor){
            _StartPage.NavigationBar.Actions.NavigateTo(NavIdentifiers.LOGIN);
        }

    }
}