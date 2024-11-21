using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Ritech.Actions;
using Ritech.Components;
using Ritech.Utils;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Pages
{
    /*
     * This class represents the "Home" page (the one that the user sees when the app is opened).
     * It has elements unique to itself, common components and actions.
     */
    public class StartPage
    {
        // does FormActions
        private HomePageActions _actions;
        public HomePageActions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new HomePageActions(this);
                    return _actions;
                }
                return _actions;
            }
        }

        // start StartPage unique elements
        public AppiumElement StartScreen => CustomActions.FindElement(
            By.XPath("//android.widget.ScrollView[@content-desc='Home-screen']/android.view.ViewGroup")
        );

        public AppiumElement WelcomePicture => CustomActions.FindElement(
            By.XPath("//android.widget.ScrollView[@content-desc='Home-screen']/android.view.ViewGroup/android.widget.ImageView[1]")
        );

        public AppiumElement Header => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@text='WEBDRIVER']")
        );

        public AppiumElement Support => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@text=\"Support\"]")
        );
        // end StartPage unique elements

        // start StartPage components
        public NavigationComponent NavigationBar = new NavigationComponent();
        // end StartPage components

    }
}
