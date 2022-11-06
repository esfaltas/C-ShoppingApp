using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Entities
{
    internal class Drinks : Products
    {
        public double Liter { get; set; }

        public override string? ToString()
        {
            return $"Drink {Name} with {Liter}ml of calories. Cost{Price}";
        }
    }
}
