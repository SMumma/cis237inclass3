using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary.Tests
{
    [TestClass()]
    public class SalaryEmployeeTests
    {
        [TestMethod()]
        public void NameAndSalaryTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime (2016, 10, 10), 400m);

            string expected = "David Barnes $400.00";
            //Act
            string actual = salaryEmployee.NameAndSalary();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 400m);

            string expected = "David Barnes 400";
            //Act
            string actual = salaryEmployee.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        public void GetAllEmployeeInformationTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 400m);

            string expected = "David Barnes 0 400";
            //Act
            string actual = salaryEmployee.GetAllEmployeeInformation();
            //Assert
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod()]
        public void GetYearlySalaryTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 400m);

            decimal expected = 20800m;
            //Act
            decimal actual = salaryEmployee.GetYearlySalary();
            //Assert
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod()]
        public void SalaryEmployeeTest()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 400m);

            string expected = "David Barnes $400.00";
            //Act
            string actual = salaryEmployee.NameAndSalary();
            //Assert
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod()]
        public void SalaryEmployeeTest1()
        {
            //Arrange
            SalaryEmployee salaryEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 400m);

            SalaryEmployee salaryEmployee2 = salaryEmployee;
            //Assert
            Assert.AreEqual(salaryEmployee, salaryEmployee2);
        }
    }
}