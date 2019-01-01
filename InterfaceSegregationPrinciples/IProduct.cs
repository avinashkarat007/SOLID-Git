using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciples
{
    public interface IProduct
    {
        int ID { get; set; }

        string Color { get; set; }

        int Price { get; set; }

        int WaistSize { get; set; }

        int NumberOfPockets { get; set; }
    }
}
