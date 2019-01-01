using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciples.Refactored
{
    public interface IPants
    {
        int WaistSize { get; set; }

        int NumberOfPockets { get; set; }
    }
}
