/**
 * Oddmatics.RozWorld.API.Server.Accounts.IPermissionAuthority -- RozWorld Server Permission Authority
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Accounts
{
    /// <summary>
    /// Represents a server's permission authority.
    /// </summary>
    public interface IPermissionAuthority
    {
        /// <summary>
        /// Gets or sets the default IPermissionGroup for new players by name.
        /// </summary>
        string DefaultGroupName { get; set; }

        /// <summary>
        /// Gets all IPermissionGroup names available.
        /// </summary>
        IList<string> GroupNames { get; }

        /// <summary>
        /// Gets an IList&lt;string&gt; collection representing all registered permissions.
        /// </summary>
        IList<string> RegisteredPermissions { get; }


        /// <summary>
        /// Creates a new blank IPermissionGroup with the given name.
        /// </summary>
        /// <param name="name">The name to give the new IPermissionGroup.</param>
        /// <returns>The newly created IPermissionGroup instance, null if an IPermissionGroup of the same name already exists.</returns>
        IPermissionGroup CreateNewGroup(string name);

        /// <summary>
        /// Gets an IPermissionGroup by its name.
        /// </summary>
        /// <param name="name">The name of the IPermissionGroup to get.</param>
        /// <returns>The IPermissionGroup associated with the given name, null if no IPermissionGroup was found.</returns>
        IPermissionGroup GetGroup(string name);

        /// <summary>
        /// Gets PermissionInfo associated with a permission by its key.
        /// </summary>
        /// <param name="key">The permission key to identify by.</param>
        /// <returns>The associated PermissionInfo instance of the permission, null if the permissions wasn't found.</returns>
        PermissionInfo? GetPermissionInfo(string key);

        /// <summary>
        /// Registers a permission and gives it a description.
        /// </summary>
        /// <param name="key">The permission key to register.</param>
        /// <param name="description">The description of the permission.</param>
        /// <returns>True if the permission was reigstered.</returns>
        bool RegisterPermission(string key, string description);
    }
}
