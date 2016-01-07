/**
 * RozWorld-API.Level.World.Tile -- RozWorld World Tile
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Level.World
{
    public interface Tile
    {
        /// <summary>
        /// Gets the x-coordinate of this tile.
        /// </summary>
        byte X { get; }

        /// <summary>
        /// Gets the y-coordinate of this tile.
        /// </summary>
        byte Y { get; }

        /// <summary>
        /// Gets or set the wall of this tile.
        /// </summary>
        Wall Wall { get; set; }

        /// <summary>
        /// Gets or sets the floor of this tile.
        /// </summary>
        Floor Floor { get; set; }
    }
}
