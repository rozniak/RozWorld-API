/**
 * Oddmatics.RozWorld.API.Generic.Level.ITile -- RozWorld World Tile
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Level
{
    /// <summary>
    /// Represents a tile in a world segment.
    /// </summary>
    public interface ITile
    {
        /// <summary>
        /// Gets the natural light level of this ITile.
        /// </summary>
        byte NaturalLightLevel { get; }

        /// <summary>
        /// Gets the sourced (artificial) light level of this ITile.
        /// </summary>
        byte SourcedLightLevel { get; }


        /// <summary>
        /// Gets an ITile relative to this ITile.
        /// </summary>
        /// <param name="diffX">The difference on the x-axis relative to this ITile.</param>
        /// <param name="diffY">The difference on the y-axis relative to this ITile.</param>
        /// <param name="diffZ">The difference on the z-axis relative to this ITile.</param>
        /// <param name="generateNonexistent">Whether or not to generate the segment if the ITile specified doesn't exist yet.</param>
        /// <returns>The ITile at the given</returns>
        ITile GetRelative(int diffX, int diffY, int diffZ, bool generateNonexistent = true);
    }
}
