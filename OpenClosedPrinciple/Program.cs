using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee john = new Employee(1, "John");

            // EmployeeIntermediate john = new EmployeeIntermediate(1, "John", "Permanant");

            PermanentEmployee john = new PermanentEmployee { ID = 1, Name = "John"};

            Console.WriteLine("*********** Bonus Details ***************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine($" Employee {john.ToString()} , Bonus : {john.CalculateBonus(350000)}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
