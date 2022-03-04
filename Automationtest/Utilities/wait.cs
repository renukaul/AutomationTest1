using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationtest.Utilities
{
    internal class wait
    {
        public static void waitByClick(IWebDriver driver,string locator,string locatorvalue,int sec)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, sec));

            if(locator == "xPath")
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            else if(locator == "Id")
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));



        }

        public static  void waittovisibility(IWebDriver driver, string locator, string locatorvalue, int sec)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, sec));

            if (locator == "xPath")
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
            else if (locator == "Id")
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));

        }
    }
}
