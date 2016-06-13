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
        /// Checks the status of a permission by account only (group membership ignored).
        /// </summary>
        /// <param name="account">The IAccount to use.</param>
        /// <param name="key">The permission key to check.</param>
        /// <returns>Whether or not the permission is granted.</returns>
        bool CheckPermissionByAccount(IAccount account, string key);

        /// <summary>
        /// Checks the status of a permission by account only (group membership ignored).
        /// </summary>
        /// <param name="name">The name of the account to use.</param>
        /// <param name="key">The permission key to check.</param>
        /// <returns>Whether or not the permission is granted.</returns>
        bool CheckPermissionByAccount(string name, string key);

        /// <summary>
        /// Creates a new blank IPermissionGroup with the given name.
        /// </summary>
        /// <param name="name">The name to give the new IPermissionGroup.</param>
        /// <returns>The newly created IPermissionGroup instance.</returns>
        IPermissionGroup CreateNewGroup(string name);

        /// <summary>
        /// Gets an IPermissionGroup by its name.
        /// </summary>
        /// <param name="name">The name of the IPermissionGroup to get.</param>
        /// <returns>The IPermissionGroup associated with the given name.</returns>
        IPermissionGroup GetGroup(string name);

        /// <summary>
        /// Gets PermissionInfo associated with a permission by its key.
        /// </summary>
        /// <param name="key">The permission key to identify by.</param>
        /// <returns>The associated PermissionInfo instance of the permission.</returns>
        PermissionInfo GetPermissionInfo(string key);

        /// <summary>
        /// Registers a permission and gives it a description.
        /// </summary>
        /// <param name="key">The permission key to register.</param>
        /// <param name="description">The description of the permission.</param>
        void RegisterPermission(string key, string description);

        /// <summary>
        /// Checks the status of a permission by account only (group membership ignored).
        /// </summary>
        /// <param name="account">The IAccount to use.</param>
        /// <param name="key">The permission key to set.</param>
        /// <param name="status">The new status of this permission.</param>
        void SetPermissionByAccount(IAccount account, string key, bool status);

        /// <summary>
        /// Checks the status of a permission by account only (group membership ignored).
        /// </summary>
        /// <param name="name">The name of the account to use.</param>
        /// <param name="key">The permission key to set.</param>
        /// <param name="status">The new status of this permission.</param>
        void SetPermissionByAccount(string name, string key, bool status);
    }
}
