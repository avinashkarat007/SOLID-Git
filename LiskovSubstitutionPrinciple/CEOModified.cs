using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class CEOModified : BaseEmployee, IManager
    {
        public override void CalculateHourPerRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

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
