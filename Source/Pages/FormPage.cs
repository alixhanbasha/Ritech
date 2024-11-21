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
    public class FormPage
    {

        private FormActions _actions;

        public FormActions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new FormActions(this);
                    return _actions;
                }
                return _actions;
            }
        }

        public AppiumElement FormHeader => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@text='Form components']")
        );

        public AppiumElement FormContainer => CustomActions.FindElement(
            By.XPath("//android.widget.ScrollView[@content-desc='Forms-screen']/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]")
        );

        public AppiumElement InputField => CustomActions.FindElement(
            By.XPath("//android.widget.EditText[@content-desc='text-input']")
        );

        public AppiumElement InputMirror => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@content-desc='input-text-result']")
        );

        public AppiumElement Switch => CustomActions.FindElement(
            By.XPath("//android.widget.Switch[@content-desc='switch']")
        );

        public AppiumElement SubmitButton => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@text='Active']")
        );

        public DropdownComponent Dropdown = new DropdownComponent();

        public NativeAlertComponent AlertPopup = new NativeAlertComponent();

        public NavigationComponent NavigationBar = new NavigationComponent();
    }
}