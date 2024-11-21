/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Ritech.Actions;
using Ritech.Utils;

namespace Ritech.Components
{
    /*
    * The Login form-component from the "Login page". 
    */
    public class LoginFormComponent
    {
        // does LoginFormComponentActions
        private LoginFormComponentActions _actions;

        public LoginFormComponentActions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new LoginFormComponentActions(this);
                    return _actions;
                }
                return _actions;
            }
        }


        public AppiumElement LoginForm => CustomActions.FindElement(
            By.XPath("//android.widget.ScrollView[@content-desc='Login-screen']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]")
        );

        public AppiumElement EmailInput => CustomActions.FindElement(
            By.XPath("//android.widget.EditText[@content-desc='input-email']")
        );

        public AppiumElement PasswordInput => CustomActions.FindElement(
            By.XPath("//android.widget.EditText[@content-desc='input-password']")
        );

        public AppiumElement LoginButton => CustomActions.FindElement(
            By.XPath("//android.view.ViewGroup[@content-desc='button-LOGIN']/android.view.ViewGroup")
        );
    }

}