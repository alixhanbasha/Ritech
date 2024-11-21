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
    /*
    * Actions that the dropdown component can do
    */
    public class DropdownComponentActions : CommonActions
    {
        private DropdownComponent _dropdown;

        public DropdownComponentActions(DropdownComponent formPage)
        {
            _dropdown = formPage;
        }

        public DropdownComponentActions Open()
        {
            _dropdown.DropdownTrigger.Click();
            CustomActions.WaitUntilDisplayed(_dropdown.DropdownContainer);
            Assert.True(_dropdown.DropdownContainer.Displayed);
            return this;
        }

        public DropdownComponentActions Select(String Option)
        {
            var option = _dropdown.DropdownItemWithText(Option);
            Assert.True(option.Displayed);
            option.Click();

            return this;
        }

        public bool EnsureIsDisplayedProperly()
        {
            CustomActions.WaitUntilDisplayed(_dropdown.DropdownTrigger);

            Trace.WriteLine("The dropdown component is displayed properly.");
            return true;
        }

    }
}