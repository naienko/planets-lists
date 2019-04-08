using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
Console.WriteLine("starting list");
foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
Console.WriteLine("step 1");
foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }

            List<string> outerPlanets = new List<string>(){"Uranus", "Neptune"};
Console.WriteLine("step 2");
foreach( string planet in outerPlanets )
        {
            Console.WriteLine(planet);
        }

            planetList.AddRange(outerPlanets);
Console.WriteLine("step 3");
foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
Console.WriteLine("step 4");
foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }

            planetList.Add("Pluto");
Console.WriteLine("step 5");
foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }

            string[] rockyPlanets = planetList.GetRange(0, 3).ToArray();
Console.WriteLine("step 6");
foreach( string planet in rockyPlanets )
        {
            Console.WriteLine(planet);
        }

            planetList.Remove("Pluto");
Console.WriteLine("step 7");
foreach( string planet in planetList )
        {
            Console.WriteLine(planet);
        }
        }
    }
}
