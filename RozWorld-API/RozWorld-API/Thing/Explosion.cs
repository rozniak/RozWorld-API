/**
 * RozWorld-API.Thing.Explosion -- RozWorld Explosion
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Level;

namespace RozWorld_API.Thing
{
    public interface Explosion
    {
        /// <summary>
        /// Gets or sets the blast radius of this explosion.
        /// </summary>
        ushort BlastRadius { get; set; }

        /// <summary>
        /// Gets or sets the damage distribution cutoff of this explosion.
        /// Values in range 0.0 - 1.0.
        /// </summary>
        double Intensity { get; set; }

        /// <summary>
        /// Gets or sets the origin point of this explosion.
        /// </summary>
        WorldPosition Position { get; set; }
    }
}
