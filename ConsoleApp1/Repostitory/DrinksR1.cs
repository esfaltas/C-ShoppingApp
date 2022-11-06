using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Repostitory
{
    internal class DrinksR1
    {
        private Servicing Service = new Servicing();
        public static List<Drinks> Drinks { get; set; }

        public DrinksR1()
        {
            Drinks = Service.ReadDrinks();
        }
    }
}
