using Automationtest.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationtest.Page
{
    internal class TMHome
    {
        public void  GoToTMHomePage(IWebDriver driver)
        {
            // Goto TM Page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            wait.waitByClick(driver, "xPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            IWebElement TimeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeOption.Click();

        }

        public void GotoEmployeePage(IWebDriver driver)
        {

        }
    }
}
