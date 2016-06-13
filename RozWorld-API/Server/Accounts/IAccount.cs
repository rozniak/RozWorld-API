/**
 * Oddmatics.RozWorld.API.Server.Accounts.IAccount -- RozWorld Server User Account
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Game;
using System;
using System.Net;

namespace Oddmatics.RozWorld.API.Server.Accounts
{
    /// <summary>
    /// Represents a user's account.
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Gets the IClan that the user of this IAccount belongs to.
        /// </summary>
        IClan Clan { get; }

        /// <summary>
        /// Gets the creation date of the account associated with this IAccount.
        /// </summary>
        DateTime CreationDate { get; }

        /// <summary>
        /// Gets the creation IP of the account associated with this IAccount.
        /// </summary>
        IPAddress CreationIP { get; }

        /// <summary>
        /// Gets the IP of the last login of the account associated with this IAccount.
        /// </summary>
        IPAddress LastLoginIP { get; }

        /// <summary>
        /// Gets or sets the level of the player of this IAccount.
        /// </summary>
        int Level { get; set; }

        /// <summary>
        /// Gets or sets the permission group this IAccount is assigned to.
        /// </summary>
        string PermissionGroupName { get; set; }

        /// <summary>
        /// Gets the name of the player of this IAccount.
        /// </summary>
        string Name { get; }



    }
}
