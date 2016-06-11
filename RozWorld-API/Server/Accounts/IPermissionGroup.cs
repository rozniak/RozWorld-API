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
        /// Gets or sets the name of this IPermissionGroup.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the colour to apply to names of player in this IPermissionGroup when they send chat messages.
        /// </summary>
        ChatColour ColourModifier { get; set; }

        /// <summary>
        /// Gets an IList&lt;string&gt; object representing the permissions granted in this IPermissionGroup.
        /// </summary>
        IList<string> Permissions { get; }

        /// <summary>
        /// Gets or sets the prefix to apply to names of players in this IPermissionGroup when they send chat messages.
        /// </summary>
        string ChatPrefix { get; set; }

        /// <summary>
        /// Gets or sets the suffix to apply to names of players in this IPermissionGroup when they send chat messages.
        /// </summary>
        string ChatSuffix { get; set; }

        /// <summary>
        /// Checks whether a player's in this IPermissionGroup have the specified permission.
        /// </summary>
        /// <param name="permKey">The permission key to check for.</param>
        /// <returns>Whether or not this IPermissionGroup grants the specified permission.</returns>
        bool HasPermission(string permKey);

        /// <summary>
        /// Attempts to add a permission to this IPermissionGroup.
        /// </summary>
        /// <param name="permKey">The permission key to try to add.</param>
        /// <returns>Whether or not the permission was added; will return false if the permission is already granted.</returns>
        bool AddPermission(string permKey);
    }
}
