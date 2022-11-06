using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Entities
{
    internal class Meat : Products
    {
        public double Protein { get; set; }

        public override string? ToString()
        {
            return $"{Name} with {Protein}g of protein. Cost{Price}";
        }
    }
}
