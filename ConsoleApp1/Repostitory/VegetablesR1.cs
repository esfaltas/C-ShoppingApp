using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Repostitory
{
    internal class VegetablesR1
    {
        private Servicing Service = new Servicing();
        public static List<Vegetables> Vegetables { get; set; }

        public VegetablesR1()
        {
            Vegetables = Service.ReadVegetables();
        }
    }
}
