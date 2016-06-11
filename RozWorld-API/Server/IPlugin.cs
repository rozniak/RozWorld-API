/**
 * Oddmatics.RozWorld.API.Server.IPlugin -- RozWorld Server Plugin
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
    /// Represents a server plugin, any generic plugins (those for handling commands for instance) should implement
    /// this interface.
    /// 
    /// Note that for starting up and shutting down plugins safely, you should attach your functions to the server's
    /// events rather than use the constructor.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Gets the description of this IPlugin.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the name of this IPlugin.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the version of this IPlugin.
        /// </summary>
        string Version { get; }
    }
}
