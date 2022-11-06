using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Entities
{
    internal class Vegetables : Products 
    {
        public double Fiber { get; set; }

        public override string? ToString()
        {
            return $"Vegerable {Name} with {Fiber}g of fibers. Cost{Price}";
        }
    }
}
