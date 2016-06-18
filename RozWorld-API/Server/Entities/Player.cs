/**
 * Oddmatics.RozWorld.API.Server.Entities.IPlayer -- RozWorld Player
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Level;
using Oddmatics.RozWorld.API.Server.Accounts;

namespace Oddmatics.RozWorld.API.Server.Entities
{
    /// <summary>
    /// Represents a RozWorld player entity.
    /// </summary>
    public abstract class Player : LivingEntity
    {
        /// <summary>
        /// Gets the IAccount associated with this Player.
        /// </summary>
        public virtual IAccount Account { get; protected set; }

        /// <summary>
        /// Gets or sets the AFK (away from keyboard) status of this Player.
        /// </summary>
        public abstract bool AFK { get; set; }

        /// <summary>
        /// Gets or sets the display name for this Player.
        /// </summary>
        public abstract string DisplayName { get; set; }

        /// <summary>
        /// Gets whether this Player is a real player.
        /// </summary>
        public abstract bool IsRealPlayer { get; protected set; }

        /// <summary>
        /// Gets or sets the joinable status of this Player.
        /// </summary>
        public abstract bool Joinable { get; set; }

        /// <summary>
        /// Gets whether this Player is online or not.
        /// </summary>
        public abstract bool Online { get; }

        /// <summary>
        /// Gets or sets the status message of this Player.
        /// </summary>
        public abstract string Status { get; set; }

        /// <summary>
        /// Gets or sets the visibility of this Player.
        /// </summary>
        public abstract byte Visibility { get; set; }

        /// <summary>
        /// Gets or sets whether this Player shows up on scoreboards.
        /// </summary>
        public abstract bool VisibleOnScoreboard { get; set; }


        /// <summary>
        /// Bans this Player from the server with a specified reason.
        /// </summary>
        /// <param name="reason">Provide a reason to this Player for banning them, leave blank for no reason given.</param>
        public abstract void Ban(string reason = "");

        /// <summary>
        /// Bans this Player's IP address from the server with a specified reason.
        /// </summary>
        public abstract void BanIP(string reason = "");

        /// <summary>
        /// Gets whether this Player has a certain permission by checking its IAccount.
        /// </summary>
        /// <param name="key">The permission key to check for.</param>
        /// <returns>Whether or not the permission associated with the given key is granted.</returns>
        public abstract bool HasPermission(string key);

        /// <summary>
        /// Kicks this Player from the server with a specified reason.
        /// </summary>
        /// <param name="reason">Provide a reason to this Player for kicking them, leave blank for no reason given.</param>
        public abstract void Kick(string reason = "");

        /// <summary>
        /// Sends an invitation to this Player as another Player.
        /// </summary>
        /// <param name="sender">The Player to pose as the sender of this invitation.</param>
        public abstract void SendInvite(Player sender);

        /// <summary>
        /// Sends a generic chat message to this Player.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public abstract void SendMessage(string message);

        /// <summary>
        /// Sends a private message to this Player as another Player.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The Player to pose as the sender of this private message.</param>
        public abstract void SendPrivateMessage(string message, Player sender);
    }
}
