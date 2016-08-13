﻿/**
 * Oddmatics.RozWorld.API.Generic.Velocity -- 2D Vector
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

// This will most likely be moved into an external maths util

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents a vector.
    /// </summary>
    public struct Vector
    {
        /// <summary>
        /// The angle (in radians) of this Vector.
        /// 0 is directly east.
        /// </summary>
        public double Angle { get; private set; }

        /// <summary>
        /// The speed of this Vector.
        /// </summary>
        public double Magnitude { get; private set; }
        

        /// <summary>
        /// Initialises a new instance of the Vector class with a specified angle and magnitude.
        /// </summary>
        /// <param name="angle">The angle (in radians); 0 is directly east.</param>
        /// <param name="magnitude">The magnitude.</param>
        public Vector(double angle, double magnitude)
            : this()
        {
            Angle = angle;
            Magnitude = magnitude;
        }
    }
}