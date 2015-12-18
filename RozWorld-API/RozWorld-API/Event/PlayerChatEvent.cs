/**
 * RozWorld-API.Event.PlayerChatEvent -- RozWorld Player Chat Message Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Entity;

using System.Collections.Generic;

namespace RozWorld_API.Event
{
    public delegate void PlayerChatEvent(PlayerChatEventArgs e);

    public class PlayerChatEventArgs
    {
        /// <summary>
        /// Gets the player who sent the chat message.
        /// </summary>
        public Player Sender { get; private set; }

        /// <summary>
        /// Gets the recipients of the chat message.
        /// </summary>
        public IList<Player> Recipients { get; private set; }

        /// <summary>
        /// Gets or sets the message being sent.
        /// </summary>
        public string Message;

        /// <summary>
        /// Gets or sets the cancelled status of the chat message event.
        /// </summary>
        public bool Cancelled;


        public PlayerChatEventArgs(Player sender, IList<Player> recipients, string message)
        {
            Sender = sender;
            Recipients = recipients;
            Message = message;
            Cancelled = false;
        }
    }
}
