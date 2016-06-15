﻿/**
 * Oddmatics.RozWorld.API.Server.Accounts.IAccount -- RozWorld Server User Account
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entity;
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
        /// Gets whether this IAccount has an associated IPlayer instance.
        /// </summary>
        bool IsPlayer { get; }

        /// <summary>
        /// Gets whether this IAccount is representative of the server itself.
        /// </summary>
        bool IsServer { get; }

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

        /// <summary>
        /// Gets the individual permissions granted to this IAccount.
        /// </summary>
        IList<string> Permissions { get; }


        /// <summary>
        /// Checks the PermissionState of a given permission for this IAccount (not checking IPermissionGroup membership).
        /// </summary>
        /// <param name="key">The permission key to check by.</param>
        /// <returns>The PermissionState of the permission associated with the given key.</returns>
        PermissionState CheckAccountPermission(string key);

        /// <summary>
        /// Gets the associated IPlayer instance of this IAccount.
        /// </summary>
        /// <returns>The IPlayer instance of this IAccount.</returns>
        IPlayer GetPlayer();

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
        void SetAccountPermission(string key, PermissionState newState);
    }
}
