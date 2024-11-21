
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Utils
{
    public class AutomationDrivers
    {

        // Different options here
        private static Uri _ServerUri = new Uri(Environment.GetEnvironmentVariable("APPIUM_HOST") ?? "http://127.0.0.1:4723/");

        public static AppiumDriver Android()
        {
            var DriverOptions = new AppiumOptions()
            {
                AutomationName = AutomationName.AndroidUIAutomator2,
                PlatformName = "Android",
                DeviceName = "Android Emulator",
                App = "wdio.apk",
            };
            DriverOptions.AddAdditionalAppiumOption("appium:appWaitForLaunch", true);

            return new AndroidDriver(_ServerUri, DriverOptions, TimeSpan.FromSeconds(60));
        }

        // In a real life project, this would also be implemented!
        public static AppiumOptions IOS()
        {
            throw new NotImplementedException();
        }

    }

}