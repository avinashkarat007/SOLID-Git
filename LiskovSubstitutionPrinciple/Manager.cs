using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Manager : Employee
    {
        public override void CalculateHourPerRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        // Simulate the reviewing process.
        public void GenerateperformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct reportee's performance");
        }
    }
}
