/**
 * Oddmatics.RozWorld.API.Generic.LogLevel -- RozWorld Log Level for Logged Messages
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
    /// Specifies constants defining the log level of a given logged message.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Represents that the message is for debugging purposes.
        /// </summary>
        Debug,
        /// <summary>
        /// Represents that the message is reporting an error.
        /// </summary>
        Error,
        /// <summary>
        /// Represents that the message is reporting a fatal error.
        /// </summary>
        Fatal,
        /// <summary>
        /// Represents that the message is stating information.
        /// </summary>
        Info,
        /// <summary>
        /// Represents that the message is stating a warning.
        /// </summary>
        Warning
    }
}
