using System;
using System.Collections.Generic;
using OpenSkiJumping.Hills;
using OpenSkiJumping.Utils;

namespace OpenSkiJumping.Jumping
{

    public class AerodynamicData
    {
        Func<float, float, float> liftFuncs;
        Func<float, float, float> dragFuncs;

        public static AerodynamicData Default = new AerodynamicData
        {
            dragFuncs = OsjMath.LayeredPolynom(new List<Func<float, float>> {
            OsjMath.Polynom(7.13930584e-09f, -4.86916560e-07f,  9.85309773e-06f,  3.23040989e-05f, 1.91812821e-03f),
            OsjMath.Polynom(3.66633351e-09f, -2.34230285e-07f,  4.50039083e-06f,  3.85009610e-05f, 2.34706577e-03f),
            OsjMath.Polynom(3.73053720e-09f, -2.28396222e-07f,  4.22335616e-06f,  2.92699562e-05f, 2.62993645e-03f)}),
            liftFuncs = OsjMath.LayeredPolynom(new List<Func<float, float>> {
            OsjMath.Polynom(1.95611501e-09f, -1.44381458e-07f,  4.18388915e-07f,  2.29621116e-04f, 9.35123746e-04f),
            OsjMath.Polynom(2.98181827e-10f,  1.20986867e-07f, -1.18859121e-05f,  3.85682167e-04f, 1.13329320e-03f),
            OsjMath.Polynom(2.37250831e-09f, -1.20722051e-07f, -2.43958197e-06f,  2.53610327e-04f, 1.29030435e-03f)})
        };
    }


    public class Simulator
    {
        public HillProfile hillProfile;
        public Simulator(HillProfile hillProfile)
        {

        }
    }
}