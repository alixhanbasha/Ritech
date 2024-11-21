/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
using System.Diagnostics;
using NUnit.Framework;
using Ritech.Components;
using Ritech.Pages;
using Ritech.Utils;

namespace Ritech.Actions
{
    public class LoginFormComponentActions : CommonActions
    {

        private LoginFormComponent _loginForm;

        public LoginFormComponentActions(LoginFormComponent loginForm)
        {
            _loginForm = loginForm;
        }

        public LoginFormComponentActions TypeEmail(string Email){
            _loginForm.EmailInput.SendKeys(Email);
            return this;
        }

        public LoginFormComponentActions TypePassword(string Password){
            _loginForm.PasswordInput.SendKeys(Password);
            return this;
        }

        public LoginFormComponentActions ClearData(){
            _loginForm.EmailInput.SendKeys("");
            _loginForm.PasswordInput.SendKeys("");
            return this;
        }

        public LoginFormComponentActions PressLoginButton(){
            _loginForm.LoginButton.Click();
            return this;
        }

        public bool EnsureIsDisplayedProperly()
        {
            CustomActions.WaitUntilDisplayed(_loginForm.LoginForm);
            Assert.True(_loginForm.EmailInput.Displayed);
            Assert.True(_loginForm.PasswordInput.Displayed);
            Assert.True(_loginForm.LoginButton.Displayed);

            Trace.WriteLine("The form page is present and displayed properly.");
            return true;
        }

    }
}