using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> additionalPlanetList = new List<string>() { "Saturn", "Jupiter" };
            planetList.AddRange(additionalPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            Console.WriteLine("These are all the planets in order");

            foreach (string planet in planetList)
            {
                if (planet != "Pluto")
                {
                    Console.WriteLine(planet);
                }
            }

            Console.WriteLine("Pluto is not a planet remove from list.");
            planetList.Remove("Pluto");

            Console.WriteLine("These are all the planets in order");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("These planets are 'rocky' planets");

            foreach (string rockyPlanet in rockyPlanets)
            {
                Console.WriteLine(rockyPlanet);
            }

            Console.ReadKey();
        }
    }
}
