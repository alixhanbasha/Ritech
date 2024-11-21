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
    * The "dropdown" menu component. 
    * This app only has one, but in a real life webapp/app
    * chancer are this component can be reused in many places
    */
    public class DropdownComponent
    {
        // does DropdownComponentActions
        private DropdownComponentActions _actions;

        public DropdownComponentActions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new DropdownComponentActions(this);
                    return _actions;
                }
                return _actions;
            }
        }

        public AppiumElement DropdownTrigger => CustomActions.FindElement(
            By.XPath("//android.widget.EditText[@resource-id='text_input']")
        );

        public AppiumElement DropdownContainer => CustomActions.FindElement(
            By.XPath("//android.widget.ListView[@resource-id='com.wdiodemoapp:id/select_dialog_listview']")
        );

        public AppiumElement DropdownItemWithText(string Message)
        {
            return CustomActions.FindElement(
                By.XPath("//android.widget.CheckedTextView[@resource-id='android:id/text1' and @text='" + Message + "']")
            );
        }
    }

}