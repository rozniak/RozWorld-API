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
using Oddmatics.RozWorld.API.Server.Entities;
using Oddmatics.RozWorld.API.Server.Event;
using Oddmatics.RozWorld.API.Server.Game;
using Oddmatics.RozWorld.API.Server.Level;
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
        /// Gets the IAccountsManager instance for this IRwServer.
        /// </summary>
        IAccountsManager AccountsManager { get; }

        /// <summary>
        /// Gets the name of this IRwServer that will appear in people's browsers.
        /// </summary>
        string BrowserName { get; }

        /// <summary>
        /// Gets the IContentManager instance for this IRwServer.
        /// </summary>
        IContentManager ContentManager { get; }

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
        /// Gets whether this IRwServer is in a paused state (only applicable if running singleplayer or splitscreen).
        /// </summary>
        bool IsPaused { get; }

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
        IList<Player> OnlinePlayers { get; }

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
        /// Gets the name of the IWorld used as the spawn world.
        /// </summary>
        string SpawnWorldName { get; }

        /// <summary>
        /// Gets this IRwServer's default StatCalculator.
        /// </summary>
        IStatCalculator StatCalculator { get; }

        /// <summary>
        /// Gets the tick rate to use for this IRwServer in milliseconds.
        /// </summary>
        byte TickRate { get; }
        
        /// <summary>
        /// Gets a list of the whitelisted players.
        /// </summary>
        IList<string> WhitelistedPlayers { get; }


        /// <summary>
        /// Occurs on a successful sign up attempt.
        /// </summary>
        event AccountSignUpEventHandler AccountSignUp;

        /// <summary>
        /// Occurs when a chat message is sent by a player.
        /// </summary>
        event PlayerChatEventHandler PlayerChatting;

        /// <summary>
        /// Occurs when a player logs in.
        /// </summary>
        event PlayerLogInEventHandler PlayerLogIn;

        /// <summary>
        /// Occurs when this IRwServer is paused.
        /// </summary>
        event EventHandler Pause;

        /// <summary>
        /// Occurs when this IRwServer has fully started.
        /// </summary>
        event EventHandler Started;

        /// <summary>
        /// Occurs when this IRwServer is starting.
        /// </summary>
        event EventHandler Starting;

        /// <summary>
        /// Occurs when this IRwServer is stopping.
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
        /// Gets a Player by their account name.
        /// </summary>
        /// <param name="name">The account name of the Player.</param>
        /// <returns>The Player instance of the given account name, null if they are not online.</returns>
        Player GetPlayer(string name);

        /// <summary>
        /// Gets a Player by their account name, offline or online.
        /// </summary>
        /// <param name="name">The account name of the Player.</param>
        /// <returns>The Player instance of the given account name, null if they do not exist.</returns>
        Player GetPlayerAbsolute(string name);

        /// <summary>
        /// Gets a Player by their display name.
        /// </summary>
        /// <param name="name">The display name of the Player.</param>
        /// <returns>The Player instance of the given display name, null if they are not online.</returns>
        Player GetPlayerByDisplayName(string name);

        /// <summary>
        /// Gets an IWorld on this IRwServer by its name.
        /// </summary>
        /// <param name="name">The name of the IWorld.</param>
        /// <returns>The IWorld instance of the given name, null if it does not exist or isn't loaded.</returns>
        IWorld GetWorld(string name);

        /// <summary>
        /// Checks if an Entity of the given ID is valid (spawned in an IWorld).
        /// </summary>
        /// <param name="id">The Entity's ID.</param>
        /// <returns>True if the Entity is currently valid.</returns>
        bool IsValidEntity(ushort id);

        /// <summary>
        /// Attempts to register a command to the specified function.
        /// </summary>
        /// <param name="cmd">The command to register.</param>
        /// <param name="func">The function to bind to the command.</param>
        /// <returns>True if the registration was successful.</returns>
        bool RegisterCommand(string cmd, CommandSentCallback func);

        /// <summary>
        /// Checks if there is data for the world of the given name able to be loaded.
        /// </summary>
        /// <param name="name">The name of the world</param>
        /// <returns>True if the world of the given name can be loaded.</returns>
        bool WorldAvailable(string name);
    }
}
