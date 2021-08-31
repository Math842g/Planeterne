using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Planet
    {
        //opgave 1
        private string planetName;
        private float mass;
        private float diameter;
        private float density;
        private float gravity;
        private float rotationPeriod;
        private float lengthOfDay;
        private float distanceFromSun;
        private float orbitalPeriod;
        private float orbitalVelcity;
        private float meanTemperature;
        private float numberOfMoons;
        private bool ringSystems;
        public Planet()
        {

        }
        public string PlanetName
        {
            get
            {
                return planetName;
            }
            set
            {
                planetName = value;
            }
        }
        public float Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public float Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public float Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }
        public float Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }
        public float RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                rotationPeriod = value;
            }
        }
        public float LengthOfDay
        {
            get
            {
                return lengthOfDay;
            }
            set
            {
                lengthOfDay = value;
            }
        }
        public float DistanceFromSun
        {
            get
            {
                return distanceFromSun;
            }
            set
            {
                distanceFromSun = value;
            }
        }
        public float OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }
            set
            {
                orbitalPeriod = value;
            }
        }
        public float OrbitalVelocity
        {
            get
            {
                return orbitalVelcity;
            }
            set
            {
                orbitalVelcity = value;
            }
        }
        public float Meantemperature
        {
            get
            {
                return meanTemperature;
            }
            set
            {
                meanTemperature = value;
            }
        }
        public float NumberOfMoons
        {
            get
            {
                return numberOfMoons;
            }
            set
            {
                numberOfMoons = value;
            }
        }
        public bool RingSystems
        {
            get
            {
                return ringSystems;
            }
            set
            {
                ringSystems = value;
            }
        }


    }
}
