using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class ManagerModified : BaseEmployee, IManager
    {
        public override void CalculateHourPerRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        public void GenerateperformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct reportee's performance");
        }
    }
}
