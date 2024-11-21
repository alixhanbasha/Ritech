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

        private LoginFormPage _formPage;

        public LoginFormActions(LoginFormPage formPage)
        {
            _formPage = formPage;
        }

        public LoginFormActions GotoLoginTab(){
            _formPage.LoginTrigger.Click();
            return this;
        }

        public LoginFormActions GotoSignupTab(){
            _formPage.SignupTrigger.Click();
            return this;
        }

        public LoginFormActions EnsureErrorIsDisplayed(string Error)
        {
            Assert.True(_formPage.FindErrorMessage(Error).Displayed);
            return this;
        }

        public bool EnsureIsDisplayedProperly()
        {
            CustomActions.WaitUntilDisplayed(_formPage.FormHeader);
            Assert.True(_formPage.LoginTrigger.Displayed);
            Assert.True(_formPage.SignupTrigger.Displayed);

            Trace.WriteLine("The form page is present and displayed properly.");
            return true;
        }

    }
}