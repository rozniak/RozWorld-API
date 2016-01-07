/**
 * RozWorld-API.Server -- RozWorld Server Instance
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Entity;
using RozWorld_API.Event;
using RozWorld_API.Logging;
using RozWorld_API.Thing;

using System;
using System.Collections.Generic;
using RozWorld_API.Level.World;


namespace RozWorld_API
{
    public delegate bool ServerCommand(string sender, IList<string> args);

    public interface Server
    {
        #region Server Properties

        /// <summary>
        /// Gets the version of this server.
        /// </summary>
        ushort Version { get; }

        /// <summary>
        /// Gets the name of this server implementation.
        /// </summary>
        string ImplementationName { get; }

        /// <summary>
        /// Gets whether this server is compatible with vanilla clients.
        /// </summary>
        bool VanillaClientCompatible { get; }

        /// <summary>
        /// Gets the list of client implementations allowed to join this server.
        /// </summary>
        IList<Tuple<string, ushort>> AllowedClientImplementations { get; }
        
        /// <summary>
        /// Gets or sets the max number of clients allowed on this server.
        /// </summary>
        ushort MaxClients { get; set; }

        /// <summary>
        /// Gets the number of players present on this server.
        /// </summary>
        ushort PlayerCount { get; }

        /// <summary>
        /// Gets the list of whitelisted players on this server.
        /// </summary>
        IList<string> WhitelistedPlayers { get; }

        /// <summary>
        /// Gets or sets whether to whitelist this server.
        /// </summary>
        bool WhitelistActive { get; set; }

        /// <summary>
        /// Gets the port that this server is running on.
        /// </summary>
        int Port { get; }

        /// <summary>
        /// Gets whether the server is active or not.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Gets whether the server is running on a LAN or purely local or not.
        /// </summary>
        bool IsLocal { get; }

        /// <summary>
        /// Gets the logger on this server.
        /// </summary>
        Logger Log { get; }

        /// <summary>
        /// Gets or sets the difficulty of this server.
        /// </summary>
        byte Difficulty { get; set; }

        /// <summary>
        /// Gets or sets the message of the day that players receive when they join this server.
        /// </summary>
        string MOTD { get; }

        /// <summary>
        /// Gets this server's name that will appear in clients' server lists.
        /// </summary>
        string Name { get; }

        #endregion

        #region Game Events

        event PlayerChatEvent PlayerChatMessageSent;
        event PlayerGameModeEvent PlayerGameModeChanged;
        event LogEvent LogMessageSent;

        #endregion
        
        #region Server Functions

        /// <summary>
        /// Gets a player by their username, case insensitive.
        /// </summary>
        /// <param name="name">The player's username to locate them by.</param>
        /// <returns>The player if they exist on the server, null otherwise.</returns>
        Player GetPlayer(string username);

        /// <summary>
        /// Gets all players currently on this server.
        /// </summary>
        /// <returns>A full list of all players on this server.</returns>
        IList<Player> GetPlayers();

        /// <summary>
        /// Gets a world by its name, case insensitive.
        /// </summary>
        /// <param name="name">The world's name to locate it by.</param>
        /// <returns>The world if they exist on the server, null otherwise.</returns>
        World GetWorld(string name);

        /// <summary>
        /// Gets all worlds currently on this server.
        /// </summary>
        /// <returns>A full list of all worlds on this server.</returns>
        IList<World> GetWorlds();
        
        /// <summary>
        /// Load or reloads the whitelist from the disk.
        /// </summary>
        void LoadWhitelist();

        /// <summary>
        /// Saves all players' data to the disk.
        /// </summary>
        void SavePlayers();

        /// <summary>
        /// Broadcasts a message to all players on the server.
        /// </summary>
        /// <param name="message">The message to broadcast.</param>
        void BroadcastMessage(string message);

        /// <summary>
        /// Creates a new instance of the item with the exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the item.</param>
        /// <returns>A new instance of the item with the specified name.</returns>
        Item CreateItem(string name);

        /// <summary>
        /// Gets the ID of an item by its exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the item.</param>
        /// <returns>The ID of the item if it exists, 0 otherwise.</returns>
        ushort GetItemID(string name);

        /// <summary>
        /// Creates a new instance of the floor with the exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the floor.</param>
        /// <returns>A new instance of the floor with the specified name.</returns>
        Floor CreateFloor(string name);

        /// <summary>
        /// Gets the ID of a floor by its exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the floor.</param>
        /// <returns>The ID of the floor if it exists, 0 otherwise.</returns>
        ushort GetFloorID(string name);

        /// <summary>
        /// Creates a new instance of the wall with the exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the wall.</param>
        /// <returns>A new instance of the floor with the specified name.</returns>
        Wall CreateWall(string name);

        /// <summary>
        /// Creates a new instance of the wall with the exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the wall.</param>
        /// <returns>The ID of the wall if it exists, 0 otherwise.</returns>
        ushort GetWallID(string name);

        /// <summary>
        /// Registers a logger to this server instance if it does not have one already.
        /// </summary>
        /// <param name="logger">The logger to register.</param>
        /// <returns>Whether registering the logger was successful or not.</returns>
        bool RegisterLogger(Logger logger);

        /// <summary>
        /// Starts this server, as long as it isn't already started.
        /// </summary>
        void Start();

        /// <summary>
        /// Reloads this server, as long as it is already started.
        /// </summary>
        void Reload();

        /// <summary>
        /// Stops this server, as long as it is already started.
        /// </summary>
        void Stop();

        /// <summary>
        /// Attempts to register a command on this server.
        /// </summary>
        /// <param name="name">The name of the command that will trigger it.</param>
        /// <param name="command">The delegate to pass onto.</param>
        /// <returns>Whether the command was successfully registered or not.</returns>
        bool RegisterCommand(string name, ServerCommand command);

        #endregion
    }
}
