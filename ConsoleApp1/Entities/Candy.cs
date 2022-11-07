using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Entities
{
    internal class Candy : Products
    {
        public double SugarAmountInGrams { get; set; }

        public override string? ToString()
        {
            return $"{Name} with {SugarAmountInGrams}g of sugar. Cost {Price} Euro";
        }
    }
}
