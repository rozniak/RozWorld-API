/**
 * RozWorld-API.Level.World.Chunk -- RozWorld World Chunk
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
    public interface Chunk
    {
        /// <summary>
        /// Gets the x-coordinate of this chunk.
        /// </summary>
        int X { get; }

        /// <summary>
        /// Gets the y-coordinate of this chunk.
        /// </summary>
        int Y { get; }

        /// <summary>
        /// Gets the z-coordinate of this chunk.
        /// </summary>
        int Z { get; }

        /// <summary>
        /// Gets the parent world of this chunk.
        /// </summary>
        World ParentWorld { get; }


        /// <summary>
        /// Gets a tile by its position in this chunk.
        /// </summary>
        /// <param name="x">The x-coordinate of the tile.</param>
        /// <param name="y">The y-coordinate of the tile.</param>
        /// <returns>The tile at the specified location.</returns>
        Tile GetTileAt(int x, int y);

        /// <summary>
        /// Makes an explosion at a given position in this chunk.
        /// </summary>
        /// <param name="x">The x-coordinate to explode at.</param>
        /// <param name="y">The y-coordinate to explode at.</param>
        /// <param name="z">The z-coordinate to explode at.</param>
        void MakeExplosion(int x, int y, int z);
    }
}
