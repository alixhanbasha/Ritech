using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Ritech.Components;
using Ritech.Utils;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Pages
{
    public class StartPage : Page
    {
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

        public NavigationComponent NavigationBar = new NavigationComponent();

        public bool EnsureIsDisplayed()
        {
            CustomActions.WaitUntilDisplayed(StartScreen);
            Assert.True(StartScreen.Displayed);
            Assert.True(NavigationBar.Actions.EnsureIsDisplayedProperly());

            Trace.WriteLine("The start page is properly displayed.");
            return true;
        }
    }
}
