/**
 * Oddmatics.RozWorld.API.Server.IRwServer -- RozWorld Server
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entity;
using Oddmatics.RozWorld.API.Server.Event;
using System;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server
{
    /// <summary>
    /// Represents a RozWorld server.
    /// </summary>
    public interface IRwServer
    {
        /// <summary>
        /// The name of this server that will appear in people's browsers.
        /// </summary>
        string BrowserName { get; }

        /// <summary>
        /// The port that this server is being hosted on.
        /// </summary>
        ushort HostingPort { get; }

        /// <summary>
        /// The logger the server is using.
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// The maximum amount of players allowed on this server at once.
        /// </summary>
        short MaxPlayers { get; }

        /// <summary>
        /// A list of the currently online players.
        /// </summary>
        IList<IPlayer> OnlinePlayers { get; }

        /// <summary>
        /// A list of the currently installed plugins.
        /// </summary>
        IList<IPlugin> Plugins { get; }

        /// <summary>
        /// The target RozWorld version of this server implementation
        /// </summary>
        string RozWorldVersion { get; }

        /// <summary>
        /// The name of this server implementation.
        /// </summary>
        string ServerName { get; }

        /// <summary>
        /// The version of this server implementation.
        /// </summary>
        string ServerVersion { get; }

        /// <summary>
        /// The tick rate to use for this server in milliseconds.
        /// </summary>
        byte TickRate { get; }
        
        /// <summary>
        /// A list of the whitelisted players.
        /// </summary>
        IList<string> WhitelistedPlayers { get; }


        /// <summary>
        /// Occurs when this server is starting.
        /// </summary>
        event EventHandler Starting;

        /// <summary>
        /// Occurs when this server is stopping.
        /// </summary>
        event EventHandler Stopping;


        /// <summary>
        /// Broadcasts a message to all players on this server.
        /// </summary>
        /// <param name="message">The message to broadcast.</param>
        void BroadcastMessage(string message);

        /// <summary>
        /// Attempts to register a command to the specified function.
        /// </summary>
        /// <param name="cmd">The command to register.</param>
        /// <param name="func">The function to bind to the command.</param>
        /// <returns>Whether or not the registration was successful.</returns>
        bool RegisterCommand(string cmd, CommandSentCallback func);

        /// <summary>
        /// Restarts this server.
        /// </summary>
        void Restart();

        /// <summary>
        /// Starts this server.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops this server.
        /// </summary>
        void Stop();
    }
}
