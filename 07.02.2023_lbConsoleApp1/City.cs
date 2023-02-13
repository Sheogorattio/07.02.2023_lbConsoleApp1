using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySpace
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }
        public int Code { get; set; }
        public int Population { get; set; }

        private string[] Districts = new string[0];

        public void AddDistrict(string name)
        {
            string[] _districts = new string[Districts.Length + 1];
            for (int i = 0; i < Districts.Length; i++)
            {
                _districts[i] = Districts[i];
            }
            _districts[_districts.Length - 1] = name;
            Districts = new string[_districts.Length];
            for (int i = 0; i < Districts.Length; i++)
            {
                Districts[i] = _districts[i];
            }
        }

        public void PrintDistricts()
        {
            foreach (var district in Districts)
            {
                if (district == null) continue;
                Console.WriteLine(district);
            }
        }

        public string GetDistrict(int index)
        {
            return Districts[index];
        }

        public void DeleteDistrict(int index)
        {
            Districts[index] = null;
        }

        public static int operator +(City city, int people)
        {
            city.Population += people;
            return city.Population;
        }

        public static int operator -(City city, int people)
        {
            city.Population -= people;
            return city.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }
    }
}
