using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class EmployeeIntermediate
    {
        public int ID { get; set; }

        public string Name { get; set; }

        // New Property
        public string EmployeeType { get; set; }

        public EmployeeIntermediate()
        {

        }

        public EmployeeIntermediate(int id, string name, string employeeType)
        {
            ID = id;
            Name = name;
            EmployeeType = employeeType;
        }

        public decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanant")
            {
                return salary * .5M;
            }
            else
            {
                return salary * .25M;
            }
        }

        public override string ToString()
        {
            return $"ID : {this.ID}  Name : {this.Name}";
        }
    }
}
