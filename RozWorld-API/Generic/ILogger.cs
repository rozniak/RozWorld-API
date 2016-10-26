/**
 * Oddmatics.RozWorld.API.Generic.ILogger -- RozWorld Logger
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents a logger for RozWorld client or server.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Outputs a message into the logger.
        /// </summary>
        /// <param name="message">The message to output.</param>
        /// <param name="colours">Allow colours in the logged message.</param>
        void Out(string message, bool colours = true);
    }
}
