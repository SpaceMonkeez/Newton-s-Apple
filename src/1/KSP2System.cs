using System.Collections.Generic;

using UnityEngine;



public static class KSP2System

{

    public static double GravitationalConstant = 6.67430e-11;  // Universal gravitational constant in m^3 kg^-1 s^-2



    public static CelestialBody Sun = new CelestialBody(

        "Sun", 1.989e30, 696340000, new Vector3(0, 0, 0), new Vector3(0, 0, 0)

    );



    // Kerbin and its moon, Mun

    public static CelestialBody Kerbin = new CelestialBody(

        "Kerbin", 5.2915158e22, 600000, new Vector3(1359984000, 0, 0), new Vector3(0, 924000, 0), Sun

    );

    public static CelestialBody Mun = new CelestialBody(

        "Mun", 1.623e20, 200000, new Vector3(1371984000, 0, 0), new Vector3(0, 1000, 0), Kerbin

    );



    // Duna and its moon, Ike

    public static CelestialBody Duna = new CelestialBody(

        "Duna", 4.515e23, 320000, new Vector3(2.0e9, 0, 0), new Vector3(0, 1500, 0), Sun

    );

    public static CelestialBody Ike = new CelestialBody(

        "Ike", 1.8e21, 130000, new Vector3(2.3e9, 0, 0), new Vector3(0, 1000, 0), Duna

    );



    // Eve and its moon, Gilly

    public static CelestialBody Eve = new CelestialBody(

        "Eve", 6.686e23, 500000, new Vector3(1.1e9, 0, 0), new Vector3(0, 1800, 0), Sun

    );

    public static CelestialBody Gilly = new CelestialBody(

        "Gilly", 4.8e19, 13000, new Vector3(1.2e9, 0, 0), new Vector3(0, 2000, 0), Eve

    );



    // Jool and its moons (including Laythe, Vall, Tylo, Bop, and Pol)

    public static CelestialBody Jool = new CelestialBody(

        "Jool", 4.233e24, 600000, new Vector3(2.8e9, 0, 0), new Vector3(0, 1300, 0), Sun

    );

    public static CelestialBody Laythe = new CelestialBody(

        "Laythe", 1.07e23, 500000, new Vector3(3.3e9, 0, 0), new Vector3(0, 2500, 0), Jool

    );

    public static CelestialBody Vall = new CelestialBody(

        "Vall", 1.4e22, 200000, new Vector3(3.5e9, 0, 0), new Vector3(0, 2300, 0), Jool

    );

    public static CelestialBody Tylo = new CelestialBody(

        "Tylo", 4.2e23, 600000, new Vector3(4.0e9, 0, 0), new Vector3(0, 1800, 0), Jool

    );

    public static CelestialBody Bop = new CelestialBody(

        "Bop", 1.2e20, 25000, new Vector3(4.5e9, 0, 0), new Vector3(0, 3500, 0), Jool

    );

    public static CelestialBody Pol = new CelestialBody(

        "Pol", 6.0e18, 10000, new Vector3(4.8e9, 0, 0), new Vector3(0, 4500, 0), Jool

    );



    // Moho

    public static CelestialBody Moho = new CelestialBody(

        "Moho", 2.0e23, 250000, new Vector3(5.7e8, 0, 0), new Vector3(0, 2400, 0), Sun

    );



    // Dres

    public static CelestialBody Dres = new CelestialBody(

        "Dres", 2.0e22, 139000, new Vector3(2.9e9, 0, 0), new Vector3(0, 1100, 0), Sun

    );



    // Eeloo

    public static CelestialBody Eeloo = new CelestialBody(

        "Eeloo", 6.0e21, 200000, new Vector3(10.3e9, 0, 0), new Vector3(0, 700, 0), Sun

    );



    // List of all celestial bodies in the system

    public static List<CelestialBody> AllBodies = new List<CelestialBody>

    {

        Sun,

        Kerbin,

        Mun,

        Duna,

        Ike,

        Eve,

        Gilly,

        Jool,

        Laythe,

        Vall,

        Tylo,

        Bop,

        Pol,

        Moho,

        Dres,

        Eeloo

    };

}