using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace Automationtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Open chrome browser

            

            IWebDriver driver = new ChromeDriver();
               
            // Launch Turnup page
            
            createRecord(driver);

            editRecord(driver);

            deleteRecord(driver);

            
        }

        static void createRecord(IWebDriver driver)
        {
            Console.WriteLine("called");
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // Identify Username Textbox and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //  Identify Password Textbox and enter valid passwprd
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");
            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            //Check if user is logged in sucessfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (hellohari.Text == "Hello hari")
            {
                Console.WriteLine("Login sucessfull,Test Pass");

            }

            else
            {
                Console.WriteLine(" Login failed");
            }

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
            Thread.Sleep(3000);

            // click on go to last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(3000);

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

        static void editRecord(IWebDriver driver)
        {
            Console.WriteLine("Edit Record Function Called");

           /* driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // Identify Username Textbox and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //  Identify Password Textbox and enter valid passwprd
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");
            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            //Check if user is logged in sucessfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (hellohari.Text == "Hello hari")
            {
                Console.WriteLine("Login sucessfull,Test Pass");

            }

            else
            {
                Console.WriteLine(" Login failed");
            }

           // Create Time and Material Record
            // Goto TM Page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            IWebElement TimeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeOption.Click();
            Thread.Sleep(2000);

            // click on go to last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(3000);*/
           

            // click on edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]/a[1]"));
            editButton.Click();

            IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            TypecodeDropdown.Click();
            Thread.Sleep(2000);
            
            IWebElement MaterialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            MaterialOption.Click();
            Thread.Sleep(2000);


            // Identify the description textbox and input a descrition
            IWebElement DescriptionTexbox = driver.FindElement(By.Id("Description"));
            DescriptionTexbox.Clear();
            DescriptionTexbox.SendKeys("AutomationTesting");

            /*// Identify the Price Per Unit textbox and input a Price Per Unit
            IWebElement PriceTage = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PriceTage.Click();

            IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
            PriceTextbox.SendKeys("104");
*/
            // Click Save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(5000);

            //Go to the last page
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(3000);


            // check if record create is present in the table and has expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            actualCode.Click();

            if (actualCode.Text == "Renu")
            {
                Console.WriteLine("Material record Updated  sucessfully,Test Passed");
            }
            else
            {
                Console.WriteLine("Update Test Failed.");
            }

        }


        static void deleteRecord( IWebDriver driver)
        {
            // click on go to last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            Thread.Sleep(3000);


            // click on delete button
            try
            {


                IWebElement delButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]/a[2]"));
                delButton.Click();
                IAlert al = driver.SwitchTo().Alert();
                al.Accept();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Record not deleted");
            }

        }
    }
}
