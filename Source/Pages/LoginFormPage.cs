/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Ritech.Actions;
using Ritech.Components;
using Ritech.Utils;

namespace Ritech.Pages
{
    public class LoginFormPage
    {

        private LoginFormActions _actions;

        public LoginFormActions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new LoginFormActions(this);
                    return _actions;
                }
                return _actions;
            }
        }

        public AppiumElement FormHeader => CustomActions.FindElement(
            By.XPath("//android.widget.ScrollView[@content-desc='Login-screen']")
        );

        public AppiumElement LoginTrigger => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@text='Login']")
        );

        public AppiumElement SignupTrigger => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@text='Sign up']")
        );

        public LoginFormComponent LoginFormComponent = new LoginFormComponent();

        public NativeAlertComponent AlertPopup = new NativeAlertComponent();

        public NavigationComponent NavigationBar = new NavigationComponent();

        public AppiumElement FindErrorMessage(string Message)
        {
            return CustomActions.FindElement(By.XPath("//android.widget.TextView[@text='" + Message + "']"));
        }
    }
}