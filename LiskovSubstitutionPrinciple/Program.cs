using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingMgr = new Manager() {FirstName = "Emma", LastName = "Stone"};
            accountingMgr.CalculateHourPerRate(4);


            // Employee emp = new CEO() {FirstName = "John", LastName = "Mathews"};

            // Here I should be able to replace Employee with manager, since a child should be able to replace its parent withiut any exception!
            // Employee emp = new Manager() {FirstName = "John", LastName = "Mathews"};
            // Employee emp = new CEO() { FirstName = "John", LastName = "Mathews" };
            BaseEmployee emp = new CEOModified() { FirstName = "John", LastName = "Mathews" };

            // emp.AssignManager(accountingMgr);
            emp.CalculateHourPerRate(2);

            Console.WriteLine("{0}'s Salary is {1}/hour",emp.FirstName, emp.Salary);

            Console.ReadLine();

        }
    }
}
