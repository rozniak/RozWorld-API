/**
 * Oddmatics.RozWorld.API.Server.ILogger -- RozWorld Server Logger
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server
{
    /// <summary>
    /// Represents a logger for RozWorld's server.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Outputs a message into the logger.
        /// </summary>
        /// <param name="message">The message to output.</param>
        void Out(string message);

        /// <summary>
        /// Saves the output from this logging session.
        /// If a log file already exists, it will be appended to.
        /// </summary>
        /// <returns>Whether or not the save was successful.</returns>
        bool Save();
    }
}
