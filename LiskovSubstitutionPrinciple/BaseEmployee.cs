﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public virtual void CalculateHourPerRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
