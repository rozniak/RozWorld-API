/**
 * Oddmatics.RozWorld.API.Generic.Velocity -- Motion Velocity
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
    /// Represents a velocity vector.
    /// </summary>
    public struct Velocity
    {
        /// <summary>
        /// The angle (in radians) of this Velocity.
        /// 0 is directly east.
        /// </summary>
        public double Angle { get; private set; }

        /// <summary>
        /// The speed of this Velocity.
        /// </summary>
        public double Speed { get; private set; }
        

        /// <summary>
        /// Initialises a new instance of the Velocity class with a specified speed and angle.
        /// </summary>
        /// <param name="angle">The angle (in radians); 0 is directly east.</param>
        /// <param name="speed">The speed.</param>
        public Velocity(double angle, double speed)
            : this()
        {
            Angle = angle;
            Speed = speed;
        }
    }
}
