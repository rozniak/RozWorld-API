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

using System;
using System.Collections.Generic;


namespace RozWorld_API
{
    public interface Server
    {
        /**
         * 
         * SERVER PROPERTIES
         * 
         */
        #region Server Properties

        /// <summary>
        /// Gets the version of this server.
        /// </summary>
        public ushort Version { get; }


        /// <summary>
        /// Gets the name of this server implementation.
        /// </summary>
        public string ImplementationName { get; }


        /// <summary>
        /// Gets whether this server is compatible with vanilla clients.
        /// </summary>
        public bool VanillaClientCompatible { get; }


        /// <summary>
        /// Gets the list of client implementations allowed to join this server.
        /// </summary>
        public IList<Tuple<string, ushort>> AllowedClientImplementations { get; protected set; }
        

        /// <summary>
        /// Gets or sets the max number of clients allowed on this server.
        /// </summary>
        public ushort MaxClients { get; protected set; }


        /// <summary>
        /// Gets or sets the list of whitelisted players on this server.
        /// </summary>
        public IList<string> WhitelistedPlayers { get; protected set; }


        /// <summary>
        /// Gets or sets whether to whitelist this server.
        /// </summary>
        public bool WhitelistActive { get; set; }


        /// <summary>
        /// Gets or sets the port that this server is running on.
        /// </summary>
        public int Port { get; protected set; }


        /// <summary>
        /// Gets or sets whether the server is active or not.
        /// </summary>
        public bool IsActive { get; protected set; }

        #endregion


        /**
         * 
         * SERVER FUNCTIONS
         * 
         */
        #region Server Functions

        /// <summary>
        /// Gets a player by their username, case insensitive.
        /// </summary>
        /// <param name="name">The player's username to locate them by.</param>
        /// <returns>The player if they exist on the server, null otherwise.</returns>
        public Player GetPlayer(string username);


        /// <summary>
        /// Load or reloads the whitelist from the disk.
        /// </summary>
        public void LoadWhitelist();


        /// <summary>
        /// Saves all players' data to the disk.
        /// </summary>
        public void SavePlayers();


        /// <summary>
        /// Broadcasts a message to all players on the server.
        /// </summary>
        /// <param name="message">The message to broadcast.</param>
        public void BroadcastMessage(string message);

        #endregion
    }
}
