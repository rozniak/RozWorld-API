/**
 * Oddmatics.RozWorld.API.Server.Event.PlayerLogInEvent -- RozWorld Server Player Log In Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entities;
using System;

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents the method that will handle the PlayerLogIn event of an IRwServer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A PlayerLogInEventArgs object that contains event data.</param>
    public delegate void PlayerLogInEventHandler(object sender, PlayerLogInEventArgs e);


    /// <summary>
    /// Provides data for the IRwServer.PlayerLogIn event.
    /// </summary>
    public class PlayerLogInEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the Player instance that has been logged in.
        /// </summary>
        public Player Player { get; private set; }


        /// <summary>
        /// Initialises a new instance of the PlayerLogInEventArgs class with a Player instance.
        /// </summary>
        /// <param name="player">The Player instance that has been logged in.</param>
        public PlayerLogInEventArgs(Player player)
        {
            Player = player;
        }
    }
}
