/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
using System.Diagnostics;
using NUnit.Framework;
using Ritech.Components;
using Ritech.Utils;

namespace Ritech.Actions
{
    /*
    * Actions related to the alert popups
    */
    public class NativeAlertActions : CommonActions
    {

        private NativeAlertComponent _nativeAlert;

        public NativeAlertActions(NativeAlertComponent alert)
        {
            _nativeAlert = alert;
        }

        public NativeAlertActions EnsureAlertTitleIs(String Title)
        {
            Assert.True(_nativeAlert.AlertTitle.Text.Equals(Title));
            return this;
        }

        public NativeAlertActions EnsureAlertMessageIs(String Message)
        {
            Assert.True(_nativeAlert.AlertMessage.Text.Equals(Message));
            return this;
        }

        public NativeAlertActions ClosePopup()
        {
            _nativeAlert.OkButton.Click();
            return this;
        }

        public bool EnsureIsDisplayedProperly()
        {
            CustomActions.WaitUntilDisplayed(_nativeAlert.AlertContainer);
            Assert.True(_nativeAlert.AlertTitle.Displayed);
            Assert.True(_nativeAlert.AlertMessage.Displayed);
            Assert.True(_nativeAlert.OkButton.Displayed);

            Trace.WriteLine("The native alert popup is present and displayed properly.");
            return true;
        }

    }
}