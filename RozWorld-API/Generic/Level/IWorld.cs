/**
 * Oddmatics.RozWorld.API.Generic.Level.IWorld -- RozWorld World
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Level
{
    /// <summary>
    /// Represents a world.
    /// </summary>
    public interface IWorld
    {
        /// <summary>
        /// Gets or sets the time in this IWorld.
        /// </summary>
        int Time { get; set; }

        /// <summary>
        /// Gets or sets the weather in this IWorld.
        /// </summary>
        Weather Weather { get; set; }
    }
}
