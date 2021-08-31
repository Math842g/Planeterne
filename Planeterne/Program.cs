using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Program
    {
        //opagve 2
        static void Main(string[] args)
        {
            Planet merkur = new Planet { PlanetName = "Merkur", Mass = 0.330f, Diameter = 4897, Density = 5427, Gravity = 3.7f, RotationPeriod = 1407.6f,
                LengthOfDay = 4222.6f, DistanceFromSun = 57.9f, OrbitalPeriod = 88, OrbitalVelocity = 47.4f, Meantemperature = 167, NumberOfMoons = 0, RingSystems = false };
            Planet venus = new Planet { PlanetName = "Venus", Mass = 4.87f, Diameter = 12104f, Density = 5243, Gravity = 8.9f, RotationPeriod = -5832.5f,
                LengthOfDay = 2802f, DistanceFromSun = 108.2f, OrbitalPeriod = 224.7f, OrbitalVelocity = 35, Meantemperature = 464, NumberOfMoons = 0, RingSystems = false };
            Planet earth = new Planet { PlanetName = "Earth", Mass = 5.97f, Diameter = 12756f, Density = 5514, Gravity = 9.8f, RotationPeriod = 23.9f
                , LengthOfDay = 24, DistanceFromSun = 149.6f, OrbitalPeriod = 365.2f, OrbitalVelocity = 29.8f, Meantemperature = 15, NumberOfMoons = 1, RingSystems = false };
            Planet mars = new Planet { PlanetName = "Mars", Mass = 0.642f, Diameter = 6792, Density = 3933, Gravity = 3.7f, RotationPeriod = 24.6f,
                LengthOfDay = 24.7f, DistanceFromSun = 227.9f, OrbitalPeriod = 687, OrbitalVelocity = 24.1f, Meantemperature = -65, NumberOfMoons = 2, RingSystems = false };
            Planet jupiter = new Planet { PlanetName = "Jupiter", Mass = 1898, Diameter = 142984f, Density = 1326, Gravity = 23.1f, RotationPeriod = 9.9f,
                LengthOfDay = 9.9f, DistanceFromSun = 778.6f, OrbitalPeriod = 4331, OrbitalVelocity = 131, Meantemperature = -110, NumberOfMoons = 67, RingSystems = true };
            Planet saturn = new Planet { PlanetName = "Saturn", Mass = 568, Diameter = 130536f, Density = 687, Gravity = 9, RotationPeriod = 10.7f,
                LengthOfDay = 10.7f, DistanceFromSun = 1433.5f, OrbitalPeriod = 10.747f, OrbitalVelocity = 9.7f, Meantemperature = -140, NumberOfMoons = 62, RingSystems = true };
            Planet uranus = new Planet { PlanetName = "Uranus", Mass = 86.8f, Diameter = 51118f, Density = 1271, Gravity = 8.7f, RotationPeriod = -17.2f, 
                LengthOfDay = 17.2f, DistanceFromSun = 2872.5f, OrbitalPeriod = 30.589f, OrbitalVelocity = 6.8f, Meantemperature = -195, NumberOfMoons = 27, RingSystems = true };
            Planet neptune = new Planet { PlanetName = "Neptune", Mass = 102f, Diameter = 49528f, Density = 1638, Gravity = 11f, RotationPeriod = 16.1f, 
                LengthOfDay = 16.1f, DistanceFromSun = 4495.1f, OrbitalPeriod = 59.8f, OrbitalVelocity = 5.4f, Meantemperature = -200, NumberOfMoons = 14, RingSystems = true };
            Planet pluto = new Planet { PlanetName = "Pluto", Mass = 0.0146f, Diameter = 2370, Density = 2095, Gravity = 0.7f, RotationPeriod = -153.3f, 
                LengthOfDay = 153.3f, DistanceFromSun = 5906.4f, OrbitalPeriod = 90.56f, OrbitalVelocity = 4.7f, Meantemperature = -225, NumberOfMoons = 5, RingSystems = false };

            List<Planet> planets = new List<Planet>();
            planets.Add(merkur);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);
            //opgave 3
            foreach (Planet p in planets)
            {
                Console.WriteLine("3. " + p.PlanetName);
            }
            //opgave 4
            planets.Insert(1, venus);
            //opgave 5
            foreach (Planet p in planets)
            {
                Console.WriteLine("5. " + p.PlanetName);
            }
            //opgave 6
            planets.Remove(pluto);
            //opgave 7
            foreach (Planet p in planets)
            {
                Console.WriteLine("7. " + p.PlanetName);
            }
            //opgave 8
            planets.Add(pluto);
            //opgave 9
            Console.WriteLine("9." + planets.Count());
            //opgave 10
            List<Planet> planets1 = new List<Planet>();
            
            foreach(Planet p in planets)
            {
                if(p.Meantemperature < 0)
                {
                    planets1.Add(p);
                }
            }
            foreach(Planet p in planets1)
            {
                Console.WriteLine("10. " + p.PlanetName);
            }
            //opgave 11
            List<Planet> planets2 = new List<Planet>();

            foreach (Planet p in planets)
            {
                if (p.Diameter > 10000 && p.Diameter < 50000)
                {
                    planets2.Add(p);
                }
            }
            foreach(Planet p in planets2)
            {
                Console.WriteLine("11. " + p.PlanetName);
            }

            Console.ReadKey();
            //opgave 12
            planets.Clear();
        }
    }
}
