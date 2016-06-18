/**
 * Oddmatics.RozWorld.API.Server.Game.IClan -- RozWorld Player Clan
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entities;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Game
{
    /// <summary>
    /// Represents a clan formed by players.
    /// </summary>
    public interface IClan
    {
        /// <summary>
        /// Gets an IList containing all the members of this IClan as IPlayers.
        /// </summary>
        IList<Player> Members { get; }

        /// <summary>
        /// Gets or sets whether or not this IClan is public.
        /// </summary>
        bool Public { get; set; }

        /// <summary>
        /// Adds a new member to this IClan by their account name.
        /// </summary>
        /// <param name="name">The account name of the player to add to this IClan.</param>
        /// <returns>Whether or not the player was added to this IClan.</returns>
        bool AddMember(string name);

        /// <summary>
        /// Adds a new member to this IClan by their IPlayer instance.
        /// </summary>
        /// <param name="player">The IPlayer instance of the player to add.</param>
        /// <returns>Whether or not the player was added to this IClan.</returns>
        bool AddMember(Player player);

        /// <summary>
        /// Removes a member from this IClan by their account name.
        /// </summary>
        /// <param name="name">The account name of the player to remove from this IClan.</param>
        /// <returns>Whether or not the player was removed from this IClan.</returns>
        bool RemoveMember(string name);

        /// <summary>
        /// Removes a member from this IClan by their IPlayer instance.
        /// </summary>
        /// <param name="player">The IPlayer instance of the player to remove.</param>
        /// <returns>Whether or not the player was removed from this IClan.</returns>
        bool RemoveMember(Player player);
    }
}
