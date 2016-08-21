/**
 * Oddmatics.RozWorld.API.Server.Event.PlayerCommandEvent -- RozWorld Server Player Command Sent Event
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
    /// Represents the method that will handle the PlayerCommanding event of an IRwServer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A PlayerCommandEventArgs object that contains event data.</param>
    public delegate void PlayerCommandEventHandler(object sender, PlayerCommandEventArgs e);


    /// <summary>
    /// Provides data for the IRwServer.PlayerCommanding event.
    /// </summary>
    public class PlayerCommandEventArgs : EventArgs, ICancellable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the event should be cancelled.
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// Gets the command being sent.
        /// </summary>
        public string Command { get; private set; }

        /// <summary>
        /// Gets the instance of the Player that sent the command.
        /// </summary>
        public Player Player { get; private set; }


        /// <summary>
        /// Initialises a new instance of the PlayerCommandEventArgs class with a Player and a command string.
        /// </summary>
        /// <param name="player">The Player object that sent the command.</param>
        /// <param name="message">The command being sent.</param>
        public PlayerCommandEventArgs(Player player, string cmd)
        {
            Command = cmd;
            Player = player;
        }
    }
}
