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

using Oddmatics.RozWorld.API.Generic.Game;
using Oddmatics.RozWorld.API.Server.Accounts;
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
        /// Gets the name of this IRwServer that will appear in people's browsers.
        /// </summary>
        string BrowserName { get; }

        /// <summary>
        /// Gets or sets the current game difficulty.
        /// </summary>
        Difficulty GameDifficulty { get; }

        /// <summary>
        /// Gets the current game mode.
        /// </summary>
        GameMode GameMode { get; }
        
        /// <summary>
        /// Gets the port that this IRwServer is being hosted on.
        /// </summary>
        ushort HostingPort { get; }

        /// <summary>
        /// Gets whether this IRwServer is running locally (as in, a singleplayer or splitscreen game).
        /// </summary>
        bool IsLocal { get; }

        /// <summary>
        /// Gets whether this IRwServer is whitelisted.
        /// </summary>
        bool IsWhitelisted { get; }

        /// <summary>
        /// Gets the ILogger this IRwServer is using.
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// Gets the maximum amount of players allowed on this IRwServer at once.
        /// </summary>
        short MaxPlayers { get; }

        /// <summary>
        /// Gets a list of the currently online players.
        /// </summary>
        IList<IPlayer> OnlinePlayers { get; }

        /// <summary>
        /// Gets this IRwServer's IPermissionAuthority.
        /// </summary>
        IPermissionAuthority PermissionAuthority { get; }

        /// <summary>
        /// Gets a list of the currently installed plugins.
        /// </summary>
        IList<IPlugin> Plugins { get; }

        /// <summary>
        /// Gets the target RozWorld version of this server implementation.
        /// </summary>
        string RozWorldVersion { get; }

        /// <summary>
        /// Gets the name of this server implementation.
        /// </summary>
        string ServerName { get; }

        /// <summary>
        /// Gets the version of this server implementation.
        /// </summary>
        string ServerVersion { get; }

        /// <summary>
        /// Gets the tick rate to use for this server in milliseconds.
        /// </summary>
        byte TickRate { get; }
        
        /// <summary>
        /// Gets a list of the whitelisted players.
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
        /// Occurs when the tick rate has elapsed.
        /// </summary>
        event EventHandler Tick;


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
    }
}
