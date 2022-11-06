using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Repostitory
{
    internal class CandyR1
    {
        private Servicing Service = new Servicing();
        public static List<Candy> Candies { get; set; }

        public CandyR1()
        {
            Candies = Service.ReadCandies();
        }
    }
}
