using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace kazameza
{
    public partial class excelDownload : Form
    {
        public excelDownload()
        {
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            IWebDriver d = new ChromeDriver(@"E:\");
            d.Url = "https://sell.souq.com/";
            //d.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(5));
            // d..Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            System.Threading.Thread.Sleep(2000);
            d.FindElement(By.ClassName("a-button-inner")).Click();
            System.Threading.Thread.Sleep(2000);
            d.FindElement(By.Id("email")).SendKeys("rehab.romantic@gmail.com");
            d.FindElement(By.ClassName("a-button-text")).SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(2000);
            d.FindElement(By.Id("continue")).Click();
            System.Threading.Thread.Sleep(2000);


            d.FindElement(By.Id("ap_password")).SendKeys("Rehab2020");
            d.FindElement(By.ClassName("a-button-input")).SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(3000);
            d.FindElements(By.ClassName("fa-parent"))[0].Click();
            d.FindElement(By.XPath(".//*[@id='nav']/li[2]/ul/li[1]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            d.FindElement(By.XPath(".//*[@id='tab-all']/span")).Click();
            System.Threading.Thread.Sleep(2000);
            d.FindElement(By.XPath(".//*[@id='table-inventory']/thead/tr[1]/th[1]/label/span[2]")).Click();
            d.FindElement(By.XPath(".//*[@id='table-inventory']/thead/tr[2]/th/a[1]/span[1]")).Click();
            d.FindElement(By.XPath(".//*[@id='main']/section/div[2]/div[4]/div[1]/div/div/div[2]/div/div[1]/div/div[1]/div/a/i[2]")).Click();

        }
    }
}
