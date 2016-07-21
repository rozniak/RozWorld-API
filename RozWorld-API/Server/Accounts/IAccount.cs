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

using Oddmatics.RozWorld.API.Server.Entities;
using Oddmatics.RozWorld.API.Server.Game;
using System;
using System.Collections.Generic;
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
        /// Gets or sets the display name of this IAccount.
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// Gets whether this IAccount has an associated Player instance.
        /// </summary>
        bool IsPlayer { get; }

        /// <summary>
        /// Gets the IP of the last login of the account associated with this IAccount.
        /// </summary>
        IPAddress LastLoginIP { get; }

        /// <summary>
        /// Gets the IPermissionGroup this IAccount is assigned to.
        /// </summary>
        IPermissionGroup PermissionGroup { get; }

        /// <summary>
        /// Gets the individual permissions granted to this IAccount.
        /// </summary>
        IList<string> Permissions { get; }

        /// <summary>
        /// Gets the associated Player instance of this IAccount.
        /// </summary>
        Player PlayerInstance { get; }

        /// <summary>
        /// Gets the username of the player of this IAccount.
        /// </summary>
        string Username { get; }


        /// <summary>
        /// Checks the PermissionState of a given permission for this IAccount (not checking IPermissionGroup membership).
        /// </summary>
        /// <param name="key">The permission key to check by.</param>
        /// <returns>The PermissionState of the permission associated with the given key.</returns>
        PermissionState CheckAccountPermission(string key);

        /// <summary>
        /// Gets whether this IAccount has a certain permission by checking its own permissions and its IPermissionGroup membership.
        /// </summary>
        /// <param name="key">The permission key to check for.</param>
        /// <returns>Whether or not the permission associated with the given key is granted.</returns>
        bool HasPermission(string key);

        /// <summary>
        /// Sets the PermissionState of a permission exclusively for this IAccount.
        /// </summary>
        /// <param name="key">The permission key to set by.</param>
        /// <param name="newState">The new PermissionState to set.</param>
        /// <returns>True if the PermissionState was set for the specified permission.</returns>
        bool SetAccountPermission(string key, PermissionState newState);

        /// <summary>
        /// Sets the IPermissionGroup this IAccount is assigned to.
        /// </summary>
        /// <param name="name">The name of the IPermissionGroup to assign.</param>
        /// <returns>True if the IPermissionGroup of the specified name was set for this IAccount.</returns>
        bool SetPermissionGroup(string name);
    }
}
