using System.Diagnostics;
using NUnit.Framework;
using Ritech.Pages;
using Ritech.Utils;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Actions
{

    /*
    * Actions related to the "Form" page can do
    */
    public class HomePageActions : CommonActions
    {

        private readonly StartPage _page;

        public HomePageActions(StartPage page)
        {
            _page = page;
        }

        public bool EnsureIsDisplayedProperly()
        {
            CustomActions.WaitUntilDisplayed(_page.StartScreen);
            Assert.True(_page.StartScreen.Displayed);
            Assert.True(_page.NavigationBar.Actions.EnsureIsDisplayedProperly());

            Trace.WriteLine("The start page is properly displayed.");
            return true;
        }
    }
}