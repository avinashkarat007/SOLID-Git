using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Employee()
        {
                
        }

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public decimal CalculateBonus(decimal salary)
        {
            return salary * .3M;
        }

        public override string ToString()
        {
            return $"ID : {this.ID}  Name : {this.Name}";
        }
    }
}
