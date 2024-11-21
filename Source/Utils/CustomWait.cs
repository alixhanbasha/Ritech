using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Utils
{
    public class CustomActions
    {

        private static readonly WebDriverWait _waiter = new WebDriverWait(
            DriverManager.GetDriver(),
            TimeSpan.FromSeconds(30)
        );

        public static AppiumElement WaitUntilDisplayed(AppiumElement element)
        {
            var driver = DriverManager.GetDriver();

            // if element is already displayed, then just return it
            if (element.Displayed) return element;

            // otherwise, wait for 30 sedonds
            // until the element is found
            _waiter.Until(el => element.Displayed);

            return element;
        }

        public static AppiumElement FindElement(By Locator)
        {
            _waiter.Until(el => el.FindElement(Locator).Displayed);
            return DriverManager.GetDriver().FindElement(Locator);
        }

        public static List<AppiumElement> FindElements(By Locator)
        {
            _waiter.Until(el => el.FindElements(Locator).ToList().ElementAt(0).Displayed);
            return DriverManager.GetDriver().FindElements(Locator).ToList();
        }

    }
}