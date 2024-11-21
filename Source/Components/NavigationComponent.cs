
using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Ritech.Actions;
using Ritech.Utils;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Components
{

    public class NavigationComponent
    {

        private NavigationActions _actions;
        public NavigationActions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new NavigationActions(this);
                    return _actions;
                }
                return _actions;
            }
        }

        public AppiumElement NavigationContainer => CustomActions.FindElement(
            By.XPath("//android.widget.FrameLayout[@resource-id='android:id/content']/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.View")
        );

        // Instead of definig each item directly
        // just pass in the name of the page you want to go to
        public AppiumElement NavigationItemCalled(string Text)
        {
            return CustomActions.FindElement(By.XPath("//android.widget.TextView[@text='" + Text + "']")); ;
        }

    }
}