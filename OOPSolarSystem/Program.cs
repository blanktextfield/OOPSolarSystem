using System;
using System.Collections.Generic;
using System.IO;
namespace OOPSolarSystem
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

            }
            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            WriteSolarSystem();
        }
        public static void WriteSolarSystem()
        {
            List<string> solarSystem = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Enter planet:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter mass");
                string mass = Console.ReadLine();

                string line = $"{name}/{mass}";
                solarSystem.Add(line);
            }
            string filePath = @"C:\Users\mammu\samples";
            string fileName = @"SolarSystem.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), solarSystem);
        }

    }
}
