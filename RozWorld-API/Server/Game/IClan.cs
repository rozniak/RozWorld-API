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
        /// Gets an IList containing all the members of this IClan as Players.
        /// </summary>
        IList<Player> Members { get; }

        /// <summary>
        /// Gets or sets whether or not this IClan is public.
        /// </summary>
        bool Public { get; set; }


        /// <summary>
        /// Adds a new member to this IClan by their account name.
        /// </summary>
        /// <param name="name">The account name of the Player to add to this IClan.</param>
        /// <returns>True if the Player of the given account name is in this IClan (regardless of whether they were already in it).</returns>
        bool AddMember(string name);

        /// <summary>
        /// Adds a new member to this IClan by their Player instance.
        /// </summary>
        /// <param name="player">The Player instance of the player to add.</param>
        /// <returns>True if the Player is in this IClan (regardless of whether they were already in it).</returns>
        bool AddMember(Player player);

        /// <summary>
        /// Removes a member from this IClan by their account name.
        /// </summary>
        /// <param name="name">The account name of the player to remove from this IClan.</param>
        /// <returns>True if the Player of the given account name is not in this IClan (regardless of whether they were already out of it).</returns>
        bool RemoveMember(string name);

        /// <summary>
        /// Removes a member from this IClan by their Player instance.
        /// </summary>
        /// <param name="player">The Player instance of the player to remove.</param>
        /// <returns>True if the Player of the given account name is not in this IClan (regardless of whether they were already out of it).</returns>
        bool RemoveMember(Player player);
    }
}
