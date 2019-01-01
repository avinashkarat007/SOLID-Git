using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public abstract class EmployeeFinal
    {
        public int ID { get; set; }

        public string Name { get; set; }


        protected EmployeeFinal()
        {

        }

        protected EmployeeFinal(int id, string name)
        {
            ID = id;
            Name = name;
        }

        // Defined new abstract method.
        public abstract decimal CalculateBonus(decimal salary);
        
        public override string ToString()
        {
            return $"ID : {this.ID}  Name : {this.Name}";
        }
    }


    public class PermanentEmployee : EmployeeFinal
    {
        public PermanentEmployee()
        {
            
        }

        public PermanentEmployee(int id, string name): base(id,name)
        {

        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .25M;
        }
    }
}
