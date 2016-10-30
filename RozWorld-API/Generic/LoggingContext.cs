/**
 * Oddmatics.RozWorld.API.Generic.LoggingContext -- RozWorld Logging Contexts
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents contextual states that messages are logged by the client or server in.
    /// </summary>
    public static class LoggingContext
    {
        /// <summary>
        /// The message is logged in the chat message context.
        /// </summary>
        public const string CHAT = "CHAT";

        /// <summary>
        /// The message is logged in the command context.
        /// </summary>
        public const string COMMAND = "CMD";

        /// <summary>
        /// The message is logged in the error context.
        /// </summary>
        public const string ERROR = "ERROR";

        /// <summary>
        /// The message is logged in the fatal error context.
        /// </summary>
        public const string FATAL_ERROR = "FATAL";

        /// <summary>
        /// The message is logged in the fatal error detailed message context.
        /// </summary>
        public const string FATAL_MESSAGE = "FATAL-MSG";

        /// <summary>
        /// The message is logged in the plugin context.
        /// </summary>
        public const string PLUGIN = "PLUGIN";

        /// <summary>
        /// The message is logged in the status context.
        /// </summary>
        public const string STATUS = "STAT";

        /// <summary>
        /// The message is logged in the disconnect status update context.
        /// </summary>
        public const string STATUS_DICONNECT = "STAT/DISC";

        /// <summary>
        /// The message is logged in the login status context.
        /// </summary>
        public const string STATUS_LOGIN = "STAT/LOGIN";

        /// <summary>
        /// The message is logged in the UDP diagnostic context.
        /// </summary>
        public const string UDP = "UDP";

        /// <summary>
        /// The message is logged in the warning context.
        /// </summary>
        public const string WARNING = "WARN";
    }
}
