using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using DataTable = System.Data.DataTable;

namespace MARS_ADV_Task.Pages
{
    internal class Loginpage : Commondriver
    
    {
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement passWord { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement loginButton { get; set; }

        public void Loginsteps()
        {
            readCredential();
            loginButton.Click();
        }

        public void readCredential()
        {

            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();
            int i = 2;
            
            Wait.WaitForvisible(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 4);
            emailAddress.SendKeys(dt.Rows[i][0].ToString());
            passWord.SendKeys(dt.Rows[i][1].ToString());
           
        }
    }
}