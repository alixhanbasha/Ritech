using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;

/*
 * Ritech QA assignement
 * Author: Alixhan Basha - bashaalixhan@gmail.com
 */
namespace Ritech.Utils
{
    /*
     * A place where custom actions live.
     */
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

        // Use this instead of driver.FindElement 
        // since it eliminates flaky tests
        public static AppiumElement FindElement(By Locator)
        {
            _waiter.Until(el => el.FindElement(Locator).Displayed);
            return DriverManager.GetDriver().FindElement(Locator);
        }

        // Same as above, but this one returns a
        // list of elements. Not used in this project
        // but could be useful to have in a real life project
        public static List<AppiumElement> FindElements(By Locator)
        {
            _waiter.Until(el => el.FindElements(Locator).ToList().ElementAt(0).Displayed);
            return DriverManager.GetDriver().FindElements(Locator).ToList();
        }

        // What performs the swipe motion.
        //
        // You need to install the appium 
        // gestures plugin for gestures to work
        private static void PerformSwipe(AppiumElement element, string direction, int percentage = 50)
        {
            Console.WriteLine("Swipe element id: '{0}'", element.Id);
            // Prepare the parameters for the swipe gesture
            var swipeParams = new Dictionary<string, object>
            {
                { "elementId", element.Id },      // Element to perform the swipe on
                { "percentage", percentage },     // Percentage for swipe distance
                { "direction", direction }        // Direction of the swipe ("left", "right", "up", "down")
            };

            // Execute the swipe gesture via JavaScript (Appium gesture: swipe)
            DriverManager.GetDriver().ExecuteScript("gesture: swipe", swipeParams);
        }

        // BEGIN gesture methods
        public static void SwipeLeft(AppiumElement Element)
        {
            PerformSwipe(Element, "left", 100);
        }

        public static void SwipeRight(AppiumElement Element)
        {
            PerformSwipe(Element, "right", 100);
        }

        public static void SwipeUp(AppiumElement Element)
        {
            PerformSwipe(Element, "up", 100);
        }

        public static void SwipeDown(AppiumElement Element)
        {
            PerformSwipe(Element, "up", 100);
        }

        public static void DragAndDrop(AppiumElement Source, AppiumElement Destiantion)
        {
            var dragAndDropParams = new Dictionary<string, object>
            {
                { "sourceId", Source.Id },
                { "destinationId", Destiantion },
            };
            DriverManager.GetDriver().ExecuteScript("gesture: dragAndDrop", dragAndDropParams);
        }
        // END gesture methods

    }
}