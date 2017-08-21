/**
 * Oddmatics.RozWorld.API.Generic.Location -- 2D Location
 * 
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents a location on a 2D plane.
    /// </summary>
    public struct RwPoint
    {
        /// <summary>
        /// Gets or sets the X coordinate of this location.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate of this location.
        /// </summary>
        public int Y { get; set; }


        /// <summary>
        /// Initialises a new instance of the Location class with a specified set of 2D coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate.</param>
        /// <param name="y">The y-coordinate.</param>
        public RwPoint(int x, int y)
            : this()
        {
            X = x;
            Y = y;
        }
    }
}
