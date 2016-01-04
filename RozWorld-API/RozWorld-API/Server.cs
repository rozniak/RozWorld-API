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


namespace RozWorld_API
{
    public abstract class Server
    {
        #region Server Properties

        /// <summary>
        /// Gets the version of this server.
        /// </summary>
        public abstract ushort Version { get; }

        /// <summary>
        /// Gets the name of this server implementation.
        /// </summary>
        public abstract string ImplementationName { get; }

        /// <summary>
        /// Gets whether this server is compatible with vanilla clients.
        /// </summary>
        public abstract bool VanillaClientCompatible { get; }

        /// <summary>
        /// Gets the list of client implementations allowed to join this server.
        /// </summary>
        public IList<Tuple<string, ushort>> AllowedClientImplementations { get; protected set; }
        
        /// <summary>
        /// Gets or sets the max number of clients allowed on this server.
        /// </summary>
        public abstract ushort MaxClients { get; protected set; }

        /// <summary>
        /// Gets or sets the list of whitelisted players on this server.
        /// </summary>
        public abstract IList<string> WhitelistedPlayers { get; protected set; }

        /// <summary>
        /// Gets or sets whether to whitelist this server.
        /// </summary>
        public abstract bool WhitelistActive { get; set; }

        /// <summary>
        /// Gets or sets the port that this server is running on.
        /// </summary>
        public abstract int Port { get; protected set; }

        /// <summary>
        /// Gets or sets whether the server is active or not.
        /// </summary>
        public abstract bool IsActive { get; protected set; }

        /// <summary>
        /// Gets or sets whether the server is running on a LAN or purely local or not.
        /// </summary>
        public abstract bool IsLocal { get; protected set; }

        /// <summary>
        /// Gets or sets the logger on this server.
        /// </summary>
        public abstract Logger Log { get; protected set; }

        #endregion

        #region Game Events

        public event PlayerChatEvent PlayerChatMessageSent;
        public event PlayerGameModeEvent PlayerGameModeChanged;
        public event LogEvent LogMessageSent;

        #endregion
        
        #region Server Functions

        /// <summary>
        /// Gets a player by their username, case insensitive.
        /// </summary>
        /// <param name="name">The player's username to locate them by.</param>
        /// <returns>The player if they exist on the server, null otherwise.</returns>
        public abstract Player GetPlayer(string username);

        /// <summary>
        /// Load or reloads the whitelist from the disk.
        /// </summary>
        public abstract void LoadWhitelist();

        /// <summary>
        /// Saves all players' data to the disk.
        /// </summary>
        public abstract void SavePlayers();

        /// <summary>
        /// Broadcasts a message to all players on the server.
        /// </summary>
        /// <param name="message">The message to broadcast.</param>
        public abstract void BroadcastMessage(string message);

        /// <summary>
        /// Creates a new instance of the item with the exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the item.</param>
        /// <returns>A new instance of the item with the specified name.</returns>
        public abstract Item CreateItem(string name);

        /// <summary>
        /// Gets the ID of an item by its exact specified name (case-sensitive).
        /// </summary>
        /// <param name="name">The exact case-sensitive name of the item.</param>
        /// <returns>The ID of the item if it exists, 0 otherwise.</returns>
        public abstract ushort GetItemID(string name);

        /// <summary>
        /// Registers a logger to this server instance if it does not have one already.
        /// </summary>
        /// <param name="logger">The logger to register.</param>
        /// <returns>Whether registering the logger was successful or not.</returns>
        public abstract bool RegisterLogger(Logger logger);

        #endregion
    }
}
