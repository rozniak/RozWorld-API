/**
 * Oddmatics.RozWorld.API.Server.Accounts.IPermissionGroup -- RozWorld Server Permission Group
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Chat;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Accounts
{
    /// <summary>
    /// Represents a permission group that defines player account rules.
    /// </summary>
    public interface IPermissionGroup
    {
        /// <summary>
        /// Gets or sets the prefix to apply to names of players in this IPermissionGroup when they send chat messages.
        /// </summary>
        string ChatPrefix { get; set; }

        /// <summary>
        /// Gets or sets the suffix to apply to names of players in this IPermissionGroup when they send chat messages.
        /// </summary>
        string ChatSuffix { get; set; }

        /// <summary>
        /// Gets or sets the colour to apply to names of player in this IPermissionGroup when they send chat messages.
        /// </summary>
        char ColourModifier { get; set; }

        /// <summary>
        /// Gets an IList&lt;string&gt; collection representing the permissions granted in this IPermissionGroup.
        /// </summary>
        IList<string> Permissions { get; }

        /// <summary>
        /// Gets an IList&lt;IAccount&gt; collection represents the members of this IPermissionGroup.
        /// </summary>
        IList<IAccount> Members { get; }


        /// <summary>
        /// Adds a permission to this IPermissionGroup.
        /// </summary>
        /// <param name="key">The permission key to try to add.</param>
        /// <returns>True if the this IPermissionGroup grants the permission (regardless of whether it already granted it).</returns>
        bool AddPermission(string key);

        /// <summary>
        /// Checks whether a player's in this IPermissionGroup have the specified permission.
        /// </summary>
        /// <param name="key">The permission key to check for.</param>
        /// <returns>True if this IPermissionGroup grants the specified permission.</returns>
        bool HasPermission(string key);

        /// <summary>
        /// Evaluates all accounts to locate members of this IPermissionGroup.
        /// </summary>
        void RecalculateMembers();

        /// <summary>
        /// Removes a permission from this IPermissionGroup.
        /// </summary>
        /// <param name="key">The permission key to remove.</param>
        /// <returns>True if this IPermissionGroup does not grant the permission (regardless of whether it never granted it).</returns>
        bool RemovePermission(string key);
    }
}
