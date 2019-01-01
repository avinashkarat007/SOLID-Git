using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Employee 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee Manager { get; set; }

        public decimal Salary{ get; set; }

        // This method assigns a manager to an employee
        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        }


        public virtual void CalculateHourPerRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
