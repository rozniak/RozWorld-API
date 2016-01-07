/**
 * RozWorld-API.Level.WorldGenerator -- RozWorld World Generator
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace RozWorld_API.Level.World
{
    public abstract class WorldGenerator
    {
        /// <summary>
        /// Generates a new world of the specified name.
        /// </summary>
        /// <param name="worldName">The name the new world should have (should be unique).</param>
        /// <param name="args">The arguments to pass to this generator.</param>
        /// <returns>A new world of the specified name (if it is unique).</returns>
        public abstract World MakeWorld(string worldName, IList<string> args);

        /// <summary>
        /// Generates a new chunk for a given world at the specified location.
        /// </summary>
        /// <param name="parentWorld">The parent world of this chunk.</param>
        /// <param name="x">The x-coordinate of where to generate this chunk.</param>
        /// <param name="y">The y-coordinate of where to generate this chunk.</param>
        /// <param name="z">The z-coordinate of where to generate this chunk.</param>
        /// <param name="chunkInstructions">The instructions given to this chunk from surrounding chunks.</param>
        /// <param name="args">The arguments to pass to this generator.</param>
        /// <returns>The chunk that was just generated for the world</returns>
        public abstract Chunk MakeChunk(World parentWorld, int x, int y, int z, IList<string> chunkInstructions, IList<string> args);
    }
}
