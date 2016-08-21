/**
 * Oddmatics.RozWorld.API.Server.Event.PlayerChatEvent -- RozWorld Server Player Chat Message Sent Event
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
    /// Represents the method that will handle the PlayerChatting event of an IRwServer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A PlayerChatEventArgs object that contains event data.</param>
    public delegate void PlayerChatEventHandler(object sender, PlayerChatEventArgs e);


    /// <summary>
    /// Provides data for the IRwServer.PlayerChatting event.
    /// </summary>
    public class PlayerChatEventArgs : EventArgs, ICancellable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the event should be cancelled.
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// Gets the message being sent in the chat.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets the instance of the Player that sent the message.
        /// </summary>
        public Player Player { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use the server's formatting for this chat message.
        /// </summary>
        public bool UseServerFormatting;


        /// <summary>
        /// Initialises a new instance of the PlayerChatEventArgs class with a Player, a message string and (optional) whether to use server chat formatting.
        /// </summary>
        /// <param name="player">The Player object that sent the chat message.</param>
        /// <param name="message">The chat message being sent.</param>
        /// <param name="useServerFormatting">Whether server chat formatting is to be used for this message.</param>
        public PlayerChatEventArgs(Player player, string message, bool useServerFormatting = true)
        {
            Message = message;
            Player = player;
            UseServerFormatting = useServerFormatting;
        }
    }
}
