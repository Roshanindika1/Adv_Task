using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MARS_ADV_Task.Pages
{
    internal class Managelistings : Commondriver
    {
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > a:nth-child(3)")]
        public IWebElement manageListings { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(2) > i")]
        public IWebElement editButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(1) > i")]
        public IWebElement detailBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-detail-section > div.ui.container > div > div:nth-child(1) > div > div > div > div")]
        public IWebElement actualTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-detail-section > div.ui.container > div > div:nth-child(2) > div.ten.wide.column > div.ui.fluid.card > div.content > div:nth-child(5) > div > div > div:nth-child(4) > div.ui.list > div > div > div.description > span:nth-child(3)")]
        public IWebElement actualSkillexchange { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input")]
        public IWebElement tagsBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input")]
        public IWebElement skillExchangeTag { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button")]
        public IWebElement saveButton { get; set; }



        public void EditSkillfunction()
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > a:nth-child(3)", 2);

            manageListings.Click();

            Wait.WaitForclicable(driver, "CssSelector", "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(2) > i", 2);
            editButton.Click();

            Wait.WaitForvisible(driver, "Name", "title", 2);
            titleBox.Clear();
            titleBox.SendKeys("Test Analyst");

            jse.ExecuteScript("window.scrollBy(0,500)");

            tagsBox.Click();
            tagsBox.SendKeys(Keys.Backspace);
            tagsBox.SendKeys("Python");
            tagsBox.SendKeys(Keys.Enter);

            jse.ExecuteScript("window.scrollBy(0,800)");

            skillExchangeTag.Click();
            skillExchangeTag.SendKeys(Keys.Backspace);
            skillExchangeTag.SendKeys("Database");
            skillExchangeTag.SendKeys(Keys.Enter);

            saveButton.Click();

        }

      

            [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i")]
            public IWebElement deleteBtn { get; set; }

            public void DeleteSkillsFunction()
            {
                Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > a:nth-child(3)", 2);
                manageListings.Click();

                Wait.WaitForvisible(driver, "CssSelector", "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i", 2);
                deleteBtn.Click();

                IWebElement deleteWindowbtn = driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div.actions > button.ui.icon.positive.right.labeled.button"));
                Wait.WaitForvisible(driver, "CssSelector", "body > div.ui.page.modals.dimmer.transition.visible.active > div > div.actions > button.ui.icon.positive.right.labeled.button", 2);
                deleteWindowbtn.Click();

            }
        

        public string GetEditedSkill(IWebDriver driver)
        {
            Wait.WaitForclicable(driver, "CssSelector", "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(1) > i", 2);
            detailBtn.Click();

            Wait.WaitForvisible(driver, "CssSelector", "#service-detail-section > div.ui.container > div > div:nth-child(1) > div > div > div > div", 2);
            return actualTitle.Text;

        }

        public string GetEditedSkillExchange(IWebDriver driver)
        {
            Wait.WaitForvisible(driver, "CssSelector", "#service-detail-section > div.ui.container > div > div:nth-child(2) > div.ten.wide.column > div.ui.fluid.card > div.content > div:nth-child(5) > div > div > div:nth-child(4) > div.ui.list > div > div > div.description > span:nth-child(3)", 2);
            return actualSkillexchange.Text;
        }

    }
}

