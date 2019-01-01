﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}
