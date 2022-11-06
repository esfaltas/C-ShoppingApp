using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Repostitory
{
    internal class MeatR1
    {
        private Servicing Service = new Servicing();
        public static List<Meat> Meats;

        public MeatR1()
        {
            Meats = Service.ReadMeats();
        }
    }
}
