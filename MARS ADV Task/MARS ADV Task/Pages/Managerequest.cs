using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARS_ADV_Task.Pages
{
    internal class Managerequest : Commondriver
    {
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > div.ui.dropdown.link.item")]
        public IWebElement manageRequestTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > div.ui.dropdown.link.item > div > a:nth-child(1)")]
        public IWebElement receiveRequestOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#received-request-section > div.ui.container > h3")]
        public IWebElement textBoxReceiveRqst { get; set; }

        /// 
        
        [FindsBy(How = How.CssSelector, Using = "#received-request-section > section.nav-secondary > div > div.ui.dropdown.link.item > div > a:nth-child(2)")]
        public IWebElement sentRequestOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#received-request-section > div.ui.container > h3")]
        public IWebElement textBoxSentRqst { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#received-request-section > section.nav-secondary > div > div.ui.dropdown.link.item")]
        public IWebElement sentrqstTab { get; set; }

        public void Receiverequest()
        {                                               
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > div.ui.dropdown.link.item", 2);
            manageRequestTab.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > div.ui.dropdown.link.item > div > a:nth-child(1)", 2);
            receiveRequestOption.Click();
            Thread.Sleep(1000);
        }


        public void Sentrequest()
        {                                                
            Wait.WaitForclicable(driver, "CssSelector", "#received-request-section > section.nav-secondary > div > div.ui.dropdown.link.item", 2);
            sentrqstTab.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#received-request-section > section.nav-secondary > div > div.ui.dropdown.link.item > div > a:nth-child(2)", 2);
            sentRequestOption.Click();
            Thread.Sleep(1000);
        }
        public string Getreceiverqst(IWebDriver driver)
        {
            return textBoxReceiveRqst.Text;
        }

        public string Getsentrqst(IWebDriver driver)
        {
            return textBoxSentRqst.Text;
        }

    }
}
