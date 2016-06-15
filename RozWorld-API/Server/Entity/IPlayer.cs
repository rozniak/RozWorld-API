/**
 * Oddmatics.RozWorld.API.Server.Entity.IPlayer -- RozWorld Player
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

namespace Oddmatics.RozWorld.API.Server.Entity
{
    /// <summary>
    /// Represents a RozWorld player entity.
    /// </summary>
    public interface IPlayer : IEntity
    {
        /// <summary>
        /// Gets the IAccount associated with this IPlayer.
        /// </summary>
        IAccount Account { get; }

        /// <summary>
        /// Gets or sets the AFK (away from keyboard) status of this IPlayer.
        /// </summary>
        bool AFK { get; set; }

        /// <summary>
        /// Gets or sets the joinable status of this IPlayer.
        /// </summary>
        bool Joinable { get; set; }

        /// <summary>
        /// Gets whether this IPlayer is online or not.
        /// </summary>
        bool Online { get; }

        /// <summary>
        /// Gets or sets the status message of this IPlayer.
        /// </summary>
        string Status { get; set; }


        /// <summary>
        /// Bans this IPlayer from the server with a specified reason.
        /// </summary>
        /// <param name="reason">Provide a reason to this IPlayer for banning them, leave blank for no reason given.</param>
        void Ban(string reason = "");

        /// <summary>
        /// Bans this IPlayer's IP address from the server with a specified reason.
        /// </summary>
        void BanIP(string reason = "");

        /// <summary>
        /// Gets whether this IPlayer has a certain permission by checking its IAccount.
        /// </summary>
        /// <param name="key">The permission key to check for.</param>
        /// <returns>Whether or not the permission associated with the given key is granted.</returns>
        bool HasPermission(string key);

        /// <summary>
        /// Kicks this IPlayer from the server with a specified reason.
        /// </summary>
        /// <param name="reason">Provide a reason to this IPlayer for kicking them, leave blank for no reason given.</param>
        void Kick(string reason = "");

        /// <summary>
        /// Sends an invitation to this IPlayer as another IPlayer.
        /// </summary>
        /// <param name="sender">The IPlayer to pose as the sender of this invitation.</param>
        void SendInvite(IPlayer sender);

        /// <summary>
        /// Sends a generic chat message to this IPlayer.
        /// </summary>
        /// <param name="message">The message to send.</param>
        void SendMessage(string message);

        /// <summary>
        /// Sends a private message to this IPlayer as another IPlayer.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="sender">The IPlayer to pose as the sender of this private message.</param>
        void SendPrivateMessage(string message, IPlayer sender);
    }
}
