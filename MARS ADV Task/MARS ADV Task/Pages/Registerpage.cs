using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Data;


namespace MARS_ADV_Task.Pages
{
    internal class Registerpage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[1]/input")]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[2]/input")]
        public IWebElement lastName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[3]/input")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[4]/input")]
        public IWebElement passWord { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[5]/input")]
        public IWebElement passWordConfirm { get; set; }

        [FindsBy(How=How.XPath, Using = "/html/body/div[2]/div/div/form/div[6]/div/div/input")]
        public IWebElement chkBox { get; set; }

        [FindsBy(How = How.Id, Using = "submit-btn")]
        public IWebElement joinBtn { get; set; }

        public void Registersteps()
        {
            readCredentialRegister();
            joinBtn.Click();
        }

        public void readCredentialRegister()
        {

            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();
            int i = 2;

            firstName.SendKeys(dt.Rows[i][2].ToString());
            lastName.SendKeys(dt.Rows[i][3].ToString());
            emailAddress.SendKeys(dt.Rows[i][0].ToString());
            passWord.SendKeys(dt.Rows[i][1].ToString());
            passWordConfirm.SendKeys(dt.Rows[i][1].ToString());
            chkBox.Click();

        }
    }
}