/**
 * Oddmatics.RozWorld.API.Server.Event.ServerTickEvent -- RozWorld Server Tick Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents the method that will handle the Tick event of an IRwServer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A ServerTickEventArgs object that contains event data.</param>
    public delegate void ServerTickEventHandler(object sender, ServerTickEventArgs e);


    /// <summary>
    /// Provides data for the IRwServer.Tick event.
    /// </summary>
    public class ServerTickEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the delta-time since the last Tick event was fired.
        /// </summary>
        public byte DeltaTime { get; private set; }


        /// <summary>
        /// Initialises a new instance of the ServerTickEventArgs class with a delta-time.
        /// </summary>
        /// <param name="deltaTime">The delta-time between ticks.</param>
        public ServerTickEventArgs(byte deltaTime)
        {
            if (deltaTime != 0)
                DeltaTime = deltaTime;
            else
                throw new ArgumentException("ServerTickEventArgs.New: 0 is not a valid delta-time.");
        }
    }
}
