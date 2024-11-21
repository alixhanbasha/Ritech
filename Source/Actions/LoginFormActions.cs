/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
using System.Diagnostics;
using NUnit.Framework;
using Ritech.Pages;
using Ritech.Utils;

namespace Ritech.Actions
{
    public class LoginFormActions : CommonActions
    {

        private LoginFormPage _loginPage;

        public LoginFormActions(LoginFormPage formPage)
        {
            _loginPage = formPage;
        }

        public LoginFormActions GotoLoginTab(){
            _loginPage.LoginTrigger.Click();
            return this;
        }

        public LoginFormActions GotoSignupTab(){
            _loginPage.SignupTrigger.Click();
            return this;
        }

        public LoginFormActions EnsureErrorIsDisplayed(string Error)
        {
            Assert.True(_loginPage.FindErrorMessage(Error).Displayed);
            return this;
        }

        public bool EnsureIsDisplayedProperly()
        {
            CustomActions.WaitUntilDisplayed(_loginPage.FormHeader);
            Assert.True(_loginPage.LoginTrigger.Displayed);
            Assert.True(_loginPage.SignupTrigger.Displayed);

            Trace.WriteLine("The form page is present and displayed properly.");
            return true;
        }

    }
}