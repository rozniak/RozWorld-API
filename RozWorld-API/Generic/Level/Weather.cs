/**
 * Oddmatics.RozWorld.API.Generic.Level.Weather -- RozWorld World's Weather
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
    /// Specifies constants defining the current weather in a world.
    /// </summary>
    public enum Weather
    {
        /// <summary>
        /// Represents clear weather.
        /// </summary>
        Clear,
        /// <summary>
        /// Represents dull weather with lightning.
        /// </summary>
        Lightning,
        /// <summary>
        /// Represents dull weather with rain.
        /// </summary>
        Rain,
        /// <summary>
        /// Represents clear weather with snow.
        /// </summary>
        Snow
    }
}
