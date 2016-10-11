using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee sEmployee = new SalaryEmployee("Sue", "Mumma", new DateTime (2014, 10, 31), 537.36m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();
            //Output the SalaryEmployee converted to a string.
            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee2.ToString());

            HourlyEmployee hEmployee = new HourlyEmployee("Joe", "Smith", new DateTime(2013, 10, 01), 12.43m, 36m);
            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetYearlySalary());
            Console.WriteLine(hEmployee.GetAllEmployeeInformation());

            //Declare a new collection
            IEmployeeCollection employeeCollection;

            //Instantiate the collection with the concrete class even though it is going to
            //an interface container
            employeeCollection = new EmployeeCollection();

            //Call the method below to add the employees to the collection
            AddNewEmployees(employeeCollection);
            PrintEmployees(employeeCollection);
        }

        static void AddNewEmployees(IEmployeeCollection employeeCollection)
        {
            employeeCollection.add("James", "Kirk", new DateTime(2016, 10, 31), 650.50m);
            employeeCollection.add("Bob", "Dole", new DateTime(2016, 5, 31), 450.50m, 20);
        }
        static void PrintEmployees(IEmployeeCollection employeeCollection)
        {
            Console.WriteLine(employeeCollection.GetPrintString());
        }
}
    }

