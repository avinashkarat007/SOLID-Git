using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciples.Refactored
{
    public class BaseballCap : IProduct , IHat
    {
        public int ID { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public int HatSize { get; set; }
    }
}
