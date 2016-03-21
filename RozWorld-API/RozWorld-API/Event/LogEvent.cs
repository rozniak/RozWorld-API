/**
 * RozWorld-API.Event.LogEvent -- RozWorld Message Log Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Logging;

using System;

namespace RozWorld_API.Event
{
    /// <summary>
    /// Represents the method that will handle the LogMessageSent event of a Server.
    /// </summary>
    /// <param name="e"></param>
    public delegate void LogEvent(LogEventArgs e);

    /// <summary>
    /// Provides data for the Server.LogMessageSent event.
    /// </summary>
    public class LogEventArgs
    {
        /// <summary>
        /// Gets the message being logged.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets the time the message was sent to be logged.
        /// </summary>
        public DateTime Time { get; private set; }

        /// <summary>
        /// Gets the type of message being logged.
        /// </summary>
        public LogMessageType MessageType { get; private set; }


        public LogEventArgs(string message, DateTime time, LogMessageType messageType)
        {
            Message = message;
            Time = time;
            MessageType = messageType;
        }
    }
}
