using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class HourlyEmployee : Employee
    {
        //Variables for this class
        private decimal _hourlyRate;
        private decimal _hoursPerWeek;

        //Properties
        //Properties don't have to be a direct relationship to a single variable.
        //Here I am using 2 variables to get the value for a single property.
        public decimal WeeklySalary
        {
            get
            {
                return this._hourlyRate * this._hoursPerWeek;
            }

        }

        public override string ToString()
        {
            //Use the weekly salary property declaration above to make up this ToString.
            //This way it will return the same string as Salary Employee even though
            //this employee is hourly.
            return base.ToString() + " " + this.WeeklySalary;
        }

        //Implement the abstract method declared in Employee
        public override decimal GetYearlySalary()
        {
            return this.WeeklySalary * 52;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this.WeeklySalary;
        }

        //Constructors
        //Take in all five parameters that make up a hourly employee.  Send the first
        //three parameter to the base constrcutor since it knows how to do the assignments
        //for me.   Then I just have to do the two remaining variables.
        public HourlyEmployee(string firstName, string lastName, DateTime startDate, decimal hourlyRate, decimal hoursPerWeek) : base(firstName, lastName, startDate)
        {
            this._hourlyRate = hourlyRate;
            this._hoursPerWeek = hoursPerWeek;
        }
    }
}
