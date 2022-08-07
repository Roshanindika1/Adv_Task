using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Data;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class ManagePassword : Commondriver
    {
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span")]
        public IWebElement hiNameElm { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/span/div/a[2]")]
        public IWebElement chngPW { get; set; }

        [FindsBy(How = How.Name, Using = "oldPassword")]
        public IWebElement oldPW { get; set; }

        [FindsBy(How = How.Name, Using = "newPassword")]
        public IWebElement newPW { get; set; }

        [FindsBy(How = How.Name, Using = "confirmPassword")]
        public IWebElement confirmPw { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.ui.page.modals.dimmer.transition.visible.active > div > div.content > form > div:nth-child(4) > button")]
        public IWebElement saveBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/a")]
        public IWebElement errormsg { get; set; }

    //    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]
   //     public IWebElement errormsg2 { get; set; }


        public void ChangePassword()
        {
            jse.ExecuteScript("window.scrollBy(0,-200)");

            Wait.WaitForvisible(driver, "CssSelector", "/html/body/div[1]/a", 2);
            errormsg.Click();
          //  errormsg2.Click();
            Thread.Sleep(3000);

            Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span", 2);
            hiNameElm.Click();
            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/div[1]/div[2]/div/span/div/a[2]", 2);
            chngPW.Click();
                        
            readCredentialPW();
            saveBtn.Click();
        }

        public void readCredentialPW()
        {
            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();
            int i = 2;

            Wait.WaitForvisible(driver, "Name", "oldPassword", 4);
            oldPW.SendKeys(dt.Rows[i][1].ToString());
            newPW.SendKeys(dt.Rows[i+1][1].ToString());
            confirmPw.SendKeys(dt.Rows[i + 1][1].ToString());
        }


        //Get the New password
        public string GetNewpassword(IWebDriver driver)
        {
            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();
            int i = 2;

            return dt.Rows[i + 1][1].ToString();
        }
    }
}

