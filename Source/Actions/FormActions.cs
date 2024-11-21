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
    public class FormActions : CommonActions
    {

        private FormPage _formPage;

        public FormActions(FormPage formPage)
        {
            _formPage = formPage;
        }

        public FormActions HasInput(String Input){
            _formPage.InputField.SendKeys(Input);
            Assert.True(_formPage.InputMirror.Text.Equals(Input)); // make sure that we see the same text
            return this;
        }

        public FormActions TriggerSwitch(){
            _formPage.Switch.Click();
            return this;
        }

        public FormActions Submit(){
            _formPage.SubmitButton.Click();
            return this;
        }

        public bool EnsureIsDisplayedProperly()
        {
            CustomActions.WaitUntilDisplayed(_formPage.FormHeader);
            Assert.True(_formPage.FormContainer.Displayed);
            Assert.True(_formPage.InputField.Displayed);
            Assert.True(_formPage.InputMirror.Displayed);
            Assert.True(_formPage.Switch.Displayed);
            Assert.True(_formPage.Dropdown.Actions.EnsureIsDisplayedProperly());

            Trace.WriteLine("The form page is present and displayed properly.");
            return true;
        }

    }
}