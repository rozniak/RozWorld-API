/**
 * RozWorld-API.Logging.Logger -- RozWorld Logging Handler
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Logging
{
    public abstract class Logger
    {
        /// <summary>
        /// Gets or sets whether chat messages should be logged.
        /// </summary>
        public abstract bool LogChatMessages { get; set; }

        /// <summary>
        /// Gets or sets whether server messages should be logged.
        /// </summary>
        public abstract bool LogServerMessages { get; set; }


        /// <summary>
        /// Sends a message to the server log and output.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public abstract void LogMessage(string message);
    }
}
