using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitySpace;

namespace _07._02._2023_lbConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.AddDistrict("malynovskiy");
            city.AddDistrict("prymorskiy");
            city.AddDistrict("kyivskiy");
            city.PrintDistricts();
            city.DeleteDistrict(1);
            city.PrintDistricts();
            Console.ReadKey();
        }
    }
}
