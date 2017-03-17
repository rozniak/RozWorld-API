/**
 * Oddmatics.RozWorld.API.Generic.EmptyLogger -- RozWorld Empty Logger
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
    /// Represents a logger that does not do anything - this is to be used when a logger is optional so that null-checks are not required for every log call.
    /// </summary>
    public class EmptyLogger : ILogger
    {
        public void Out(string message, LogLevel level, bool colours = true) { }
    }
}
