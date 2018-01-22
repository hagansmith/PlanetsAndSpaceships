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
            var planetList = new List<string>() { "Mercury", "Mars" };
            var additionalPlanetList = new List<string>() { "Saturn", "Jupiter" };
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

            var marsCraftList = new List<string>() {"craft1", "craft2", "craft3", "craft4" };
            var earthCraftList = new List<string>() { "craft5", "craft6", "craft7" };

            var spacecraftDictionary = new Dictionary<string, List<string>>
            {
                {"Mars", marsCraftList },
                {"Earth", earthCraftList }
            };

            

            foreach (string planet in planetList)
            {
                foreach (var item in spacecraftDictionary)
                {
                    if (item.Key == planet)
                    {
                        string crafts = "";
                        foreach (var craft in item.Value)
                        {
                            crafts += $"{craft} " ;
                        }
                        Console.WriteLine($"{planet}: {crafts}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
