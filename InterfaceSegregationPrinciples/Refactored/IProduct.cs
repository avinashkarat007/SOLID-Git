using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciples.Refactored
{
    public interface IProduct
    {

        int ID { get; set; }

        string Color { get; set; }

        int Price { get; set; }
    }
}
