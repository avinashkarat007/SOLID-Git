using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciples
{
    public class Jeans : IProduct
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int WaistSize { get; set; }
        public int NumberOfPockets { get; set; }
    }
}
