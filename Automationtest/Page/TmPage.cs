using Automationtest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace Automationtest.Page
{
    class TmPage
    {
       

        public  void createRecord(IWebDriver driver)
        {
           
            // Create Time and Material Record
            // Goto TM Page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            IWebElement TimeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeOption.Click();

            
            // Click on create   new button
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewButton.Click();

            // Select material from Typecode Dropdown
            IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            TypecodeDropdown.Click();

            IWebElement MaterialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            MaterialOption.Click();

            // Identify the code textbox and input a code
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("Renu");

            // Identify the description textbox and input a descrition
            IWebElement DescriptionTexbox = driver.FindElement(By.Id("Description"));
            DescriptionTexbox.SendKeys("Renu");

            // Identify the Price Per Unit textbox and input a Price Per Unit
            IWebElement PriceTage = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PriceTage.Click();
            IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
            PriceTextbox.SendKeys("13");

            // Click Save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            
            wait.waittovisibility(driver, "xPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // click on go to last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            wait.waittovisibility(driver, "xPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 2);
         

            // check if record create is present in the table and has expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            actualCode.Click();

            if (actualCode.Text == "Renu")
            {
                Console.WriteLine("Material record created sucessfully,Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed.");
            }
        }

        public void editRecord(IWebDriver driver)
        {
            Console.WriteLine("Edit Record Function Called");

            try
            {
                wait.waittovisibility(driver, "xPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

                // click on go to last page button
                IWebElement gotoLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                gotoLastPageButton1.Click();

                // click on edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]/a[1]"));
                editButton.Click();

                IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
                TypecodeDropdown.Click();
                wait.waitByClick(driver, "xPath", "//*[@id='TypeCode_listbox']/li[1]", 2);


                IWebElement MaterialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                MaterialOption.Click();
                wait.waitByClick(driver, "Id", "Description", 2);



                // Identify the description textbox and input a descrition
                IWebElement DescriptionTexbox = driver.FindElement(By.Id("Description"));
                DescriptionTexbox.Clear();
                DescriptionTexbox.SendKeys("AutomationTesting");

                // Identify the Price Per Unit textbox and input a Price Per Unit
                IWebElement PriceTage = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                PriceTage.Click();

                IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
                PriceTextbox.Clear();
                PriceTage.Click();

                PriceTextbox.SendKeys("104");

                // Click Save button
                IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
                SaveButton.Click();
                wait.waittovisibility(driver, "xPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);



                //Go to the last page
                IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                gotoLastPageButton.Click();
                wait.waitByClick(driver, "xPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 2);



                // check if record create is present in the table and has expected value
                IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                actualCode.Click();
                IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
                
                Assert.That(actualCode.Text == "Renu", "Actual Code and Expected code do not match");
                Assert.That(actualTypeCode.Text == "M", "Actual TypeCode and Expected TypeCode do not match");
                Assert.That(actualDescription.Text == "AutomationTesting", "Actual Description and Expected Descriptiondo not match");
                Assert.That(actualPrice.Text == "$104.00", "Actual Price and Expected Price do not match");



                /* if (actualCode.Text == "Renu")
                 {
                     Assert.Pass("Material record Updated  sucessfully,Test Passed");
                 }
                 else
                 {
                     Assert.Fail("Update Test Failed.");
                 }*/

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }


        }


        public void deleteRecord(IWebDriver driver)
        {
            wait.waittovisibility(driver, "xPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // click on go to last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
           // wait.waitByClick(driver, "xPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]/a[2]", 2);
            Thread.Sleep(3000);


            // click on delete button
            try
            {
                IWebElement delButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]/a[2]"));
                delButton.Click();
                IAlert al = driver.SwitchTo().Alert();
                al.Accept();
               
               
            }
            catch (Exception ex)
            {
              Assert.Fail(ex.Message + "Record not deleted");
            }
           
            Assert.Pass("Record Deleted Successfully");
            driver.Navigate().Refresh();


        }
    }
}
