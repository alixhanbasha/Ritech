using System.Diagnostics;
using TechTalk.SpecFlow;
using Ritech.Utils;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.Enums;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void SetUp()
        {
            // Parser.Default.ParseArguments<Options>(Environment.GetCommandLineArgs());
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;

            DriverManager.CreateDriver();
        }

        /*
         * After a test case is done
         * restart the app, and make sure to wait 
         * until it's launched
         */
        [AfterScenario]
        public static void ResetAppState()
        {
            DriverManager.Restart();
            var wait = new WebDriverWait(DriverManager.GetDriver(), TimeSpan.FromSeconds(60));
            wait.Until(el => DriverManager.GetDriver().GetAppState("com.wdiodemoapp").Equals(AppState.RunningInForeground));
        }

        [AfterTestRun]
        public static void TearDown()
        {
            DriverManager.QuitDriver();
        }
    }
}
