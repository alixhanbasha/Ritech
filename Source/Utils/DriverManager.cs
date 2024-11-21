
using OpenQA.Selenium.Appium;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Utils
{

    public class DriverManager
    {

        private static AppiumDriver _driver;

        public static void CreateDriver()
        {
            if (_driver == null)
            {
                // Just the Android driver for now, however
                // if this was a real project we could also
                // add an if/switch statement here for other drivers as well
                _driver = AutomationDrivers.Android();
            }
        }

        public static AppiumDriver GetDriver()
        {
            if (_driver == null) CreateDriver();
            return _driver;
        }

        public static void Restart()
        {
            _driver.TerminateApp("com.wdiodemoapp");
            Thread.Sleep(500); // added this hard coded 500 ms wait just in case
            _driver.ActivateApp("com.wdiodemoapp");
        }

        public static void QuitDriver()
        {
            _driver?.Quit();
            _driver = null;
        }

    }

}