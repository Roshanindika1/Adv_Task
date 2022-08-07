using OpenQA.Selenium;


namespace MARS_ADV_Task.Utilities
{
    public class Commondriver
    {
        public static IWebDriver driver;

    }

    public class Driver
    {
        public static IWebDriver driver;

        public IWebDriver _driver;

        public Driver(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}
