using System.Collections.Generic;

using UnityEngine;

using BepInEx;  // For BepInEx modding functionality

using SpaceWarp;  // For KSP2-specific modding support

using SpaceWarp.UI;  // For UI components like buttons, windows, etc.



namespace KSP2NBodySimulation

{

    [BepInPlugin("com.yourname.ksp2nbody", "KSP2 N-body Simulation", "1.0.0")]

    public class ModMain : BaseUnityPlugin

    {

        private List<CelestialBody> celestialBodies;



        // This method runs when the mod is first loaded

        private void Start()

        {

            // Initialize celestial bodies with masses, positions, velocities, and other properties

            celestialBodies = KSP2System.AllBodies;

            Logger.LogInfo("N-body simulation initialized!");



            // Create UI Button for triggering gravity simulation

            CreateGravitySimulationButton();

        }



        // Create a UI button using SpaceWarp UI

        private void CreateGravitySimulationButton()

        {

            // Define the button's position and size

            var gravityButton = new SpaceWarp.UI.Button("Start Gravity Simulation", new Rect(100, 100, 200, 50));



            // Define the action to occur when the button is clicked

            gravityButton.OnClick += () =>

            {

                Logger.LogInfo("Gravity Simulation Started");

                // Start the simulation

                StartGravitySimulation();

            };

        }



        // Start the gravity simulation

        private void StartGravitySimulation()

        {

            // Update gravitational forces every fixed update

            GravitationalCalculations.UpdateGravityForces(celestialBodies);

        }



        // FixedUpdate is called on every fixed time step, ideal for physics calculations

        private void FixedUpdate()

        {

            // Continuously update gravity forces each frame

            GravitationalCalculations.UpdateGravityForces(celestialBodies);

            // Log celestial body information like position and velocity

            LogCelestialBodyInfo();

        }



        // Log details about the celestial bodies

        private void LogCelestialBodyInfo()

        {

            foreach (var body in celestialBodies)

            {

                // Log position, velocity, and acceleration for each celestial body

                Logger.LogInfo($"{body.Name} - Position: {body.Position}, Velocity: {body.Velocity}, Acceleration: {body.Acceleration}");

            }

        }

    }

}