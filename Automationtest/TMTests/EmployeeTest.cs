using Automationtest.Page;
using Automationtest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationtest.TMTests
{
     [TestFixture]
     [Parallelizable]
     internal class EmployeeTest :CommonDriver
    {

       

        [Test, Order(1), Description("This will create new records in Employee page")]
        public void TC001_CreateEmployeePage()
        {
            TMHome homepage = new TMHome();
            homepage.GotoEmployeePage(driver);

            EmployeePage  EmployeeCreate = new EmployeePage();
            EmployeeCreate.CreateEmployee(driver);
        }

        [Test, Order(2), Description("This will Edit  records of Employee page")]
        public void TC002_EditEmployee()
        {
            TMHome homepage = new TMHome();
            homepage.GotoEmployeePage(driver);

            EmployeePage EmployeeEdit = new EmployeePage();
            EmployeeEdit.EditEmployee(driver);
        }

        [Test, Order(3), Description("This will Delete  records")]
        public void TC003_DeleteEmployee()
        {
            TMHome homepage = new TMHome();
            homepage.GotoEmployeePage(driver);

            EmployeePage EmployeeDelete= new EmployeePage();
            EmployeeDelete.DeleteEmployee(driver);

        }

       


    }
}
