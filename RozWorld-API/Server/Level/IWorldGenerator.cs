/**
 * Oddmatics.RozWorld.API.Server.Level.IWorldGenerator -- RozWorld World Generator
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Level;

namespace Oddmatics.RozWorld.API.Server.Level
{
    /// <summary>
    /// Represents a world generator.
    /// </summary>
    public interface IWorldGenerator
    {
        /// <summary>
        /// Attempts to generate a segment at the given coordinates, as long as the segment has not already been generated.
        /// </summary>
        /// <param name="world">The IWorld to generate the chunk in.</param>
        /// <param name="x">The x-coordinate of the segement to generate.</param>
        /// <param name="y">The y-coordinate of the segement to generate.</param>
        /// <param name="z">The z-coordinate of the segement to generate.</param>
        /// <returns>Whether or not the segment was generated successfully.</returns>
        ISegment GenerateSegmentAt(IWorld world, int x, int y, int z);

        /// <summary>
        /// Attempts to generate a new IWorld.
        /// </summary>
        /// <param name="name">The name of the IWorld to generate.</param>
        /// <returns>The generated IWorld if it was generated successfully.</returns>
        IWorld GenerateWorld(string name);
    }
}
