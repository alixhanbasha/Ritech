using System.Diagnostics;
using NUnit.Framework;
using Ritech.Components;
using Ritech.Utils;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Actions
{
    // the navigation action class
    // anything that can be done by the navbar
    // should be put here
    public class NavigationActions : CommonActions
    {

        private NavigationComponent NavBar;

        public NavigationActions(NavigationComponent navBar)
        {
            NavBar = navBar;
        }

        public bool EnsureIsDisplayedProperly()
        {
            Assert.True(NavBar.NavigationContainer.Displayed);
            Console.WriteLine("Navbar: '{0}'", NavBar.NavigationContainer.Text);
            Assert.True(NavBar.NavigationItemCalled(NavIdentifiers.HOME).Displayed);
            Assert.True(NavBar.NavigationItemCalled(NavIdentifiers.WEBVIEW).Displayed);
            Assert.True(NavBar.NavigationItemCalled(NavIdentifiers.LOGIN).Displayed);
            Assert.True(NavBar.NavigationItemCalled(NavIdentifiers.FORMS).Displayed);
            Assert.True(NavBar.NavigationItemCalled(NavIdentifiers.SWIPE).Displayed);
            Assert.True(NavBar.NavigationItemCalled(NavIdentifiers.DRAG).Displayed);
            Trace.WriteLine("The Navigation component is present and displayed properly.");
            return true;
        }

        public void NavigateTo(string PageName)
        {
            NavBar.NavigationItemCalled(PageName).Click();
        }
    }
}