using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class CEO : Employee
    {

        public override void CalculateHourPerRate(int rank)
        {
            decimal baseAmount = 1505M;

            Salary = baseAmount * rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new Exception("The CEO has no manager");
        }

        // Simulate the reviewing process.
        public void GenerateperformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct reportee's performance");
        }


        public void FireSomeone()
        {
            Console.WriteLine("I'm firing someone!");
        }
    }
}
