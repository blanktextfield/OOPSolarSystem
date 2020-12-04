using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SystemTotalMass
{
    class Program
    {
        public class Planet
        {
            string name;
            int mass;
            public Planet(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
                Console.WriteLine($"Planet {name} created");
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }


        }
        static void Main(string[] args)
        {
            ReadFromSolarSystem();
        }

        public static void ReadFromSolarSystem()
        {
            string filePath = @"C:\Users\mammu\samples";
            string fileName = @"SolarSystem.txt";

            List<Planet> SolarSystem = new List<Planet>();

            List<string> linesFromFile = File.ReadAllLines(Path.Combine(Path.Combine(filePath, fileName))).ToList();

            foreach (string line in linesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Planet newPlanet = new Planet(tempArray[0], Int32.Parse(tempArray[1]));
                SolarSystem.Add(newPlanet);
            }

            Console.WriteLine("Your Solar system: ");
            int total = 0;

            foreach (Planet item in SolarSystem)
            {
                Console.WriteLine($"{item.Name}; Mass: {item.Mass}");
                total += item.Mass;
            }
            Console.WriteLine($"Your solar system total mass: {total} units ");

        }
    }
}
