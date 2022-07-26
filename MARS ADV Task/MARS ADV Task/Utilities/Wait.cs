﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace MARS_ADV_Task.Utilities
{
    public class Wait : Commondriver
    {
        public static void WaitForclicable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")

            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));

            }

            if (locator == "Name")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));

            }
            if (locator == "LinkText")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locatorValue)));

            }

        }


        public static void WaitForvisible(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }

            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")

            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));

            }
            if (locator == "Name")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locatorValue)));

            }
            if (locator == "LinkText")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locatorValue)));

            }
        }

    }
}
