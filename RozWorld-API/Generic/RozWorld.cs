/**
 * Oddmatics.RozWorld.API.Generic.RozWorld -- RozWorld Core
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server;
using System;

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents the RozWorld core systems for handling the client and server instances.
    /// </summary>
    public class RozWorld
    {
        /// <summary>
        /// Gets the current RozWorld server instance.
        /// </summary>
        public static IRwServer Server { get; private set; }


        /// <summary>
        /// Attempts to set the RozWorld server instance.
        /// This can't be done if an instance already exists; this function is for server executables to use on startup only.
        /// </summary>
        /// <param name="server">The server instance to set.</param>
        public static void SetServer(IRwServer server)
        {
            if (Server == null)
                Server = server;
            else
                throw new InvalidOperationException("Cannot set server, it is not null.");
        }
    }
}
