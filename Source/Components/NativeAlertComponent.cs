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
    * The Alert popup component 
    */
    public class NativeAlertComponent
    {

        // does NativeAlertActions
        private NativeAlertActions _actions;

        public NativeAlertActions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new NativeAlertActions(this);
                    return _actions;
                }
                return _actions;
            }
        }


        public AppiumElement AlertContainer => CustomActions.FindElement(
            By.XPath("(//android.widget.FrameLayout[@resource-id='android:id/content'] | //android.widget.LinearLayout[@resource-id='android:id/parentPanel'])")
        );

        public AppiumElement AlertTitle => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@resource-id='android:id/alertTitle']")
        );

        public AppiumElement AlertMessage => CustomActions.FindElement(
            By.XPath("//android.widget.TextView[@resource-id='android:id/message']")
        );

        public AppiumElement OkButton => CustomActions.FindElement(
            By.XPath("//android.widget.Button[@resource-id='android:id/button1']")
        );

        public AppiumElement CancelButton => CustomActions.FindElement(
            By.XPath("//android.widget.Button[@resource-id='android:id/button2']")
        );

        public AppiumElement AskMeLaterButton => CustomActions.FindElement(
            By.XPath("//android.widget.Button[@resource-id='android:id/button3']")
        );
    }

}