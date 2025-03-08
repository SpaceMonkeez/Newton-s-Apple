using System;

using System.Collections.Generic;

using UnityEngine;



namespace KSP2NBodySimulation

{

    public static class GravitationalCalculations

    {

        private const float G = 6.67430e-11f; // Gravitational constant (N·m²/kg²)



        // Update the gravitational forces on all celestial bodies

        public static void UpdateGravityForces(List<CelestialBody> bodies)

        {

            foreach (var body in bodies)

            {

                body.Acceleration = Vector3.zero;  // Reset acceleration

            }



            for (int i = 0; i < bodies.Count; i++)

            {
                CelestialBody body = bodies[i];
                foreach (var otherBody in bodies)

                {

                    if (body == otherBody) continue; // Don't calculate force on itself



                    // Calculate gravitational force using Newton's law of gravitation

                    Vector3 direction = otherBody.Position - body.Position;

                    float distance = direction.magnitude;

                    float forceMagnitude = (G * body.Mass * otherBody.Mass) / (distance * distance);



                    // Calculate the acceleration produced by this force

                    body.Acceleration += direction.normalized * forceMagnitude / body.Mass;

                }



                // Update the body's velocity and position

                body.Velocity += body.Acceleration * Time.fixedDeltaTime;

                body.Position += body.Velocity * Time.fixedDeltaTime;

            }

        }

    }

}