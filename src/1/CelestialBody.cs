using UnityEngine;



namespace KSP2NBodySimulation

{

    public class CelestialBody

    {

        public string Name { get; set; }

        public Vector3 Position { get; set; }

        public Vector3 Velocity { get; set; }

        public Vector3 Acceleration { get; set; }

        public float Mass { get; set; }

        public float Radius { get; set; }



        // Constructor for a celestial body

        public CelestialBody(string name, Vector3 position, Vector3 velocity, float mass, float radius)

        {

            Name = name;

            Position = position;

            Velocity = velocity;

            Mass = mass;

            Radius = radius;

            Acceleration = Vector3.zero;

        }

    }

}

