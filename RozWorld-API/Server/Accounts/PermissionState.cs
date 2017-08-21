/**
 * Oddmatics.RozWorld.API.Server.Accounts.PermissionState -- RozWorld Permission State
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Accounts
{
    /// <summary>
    /// Specifies constants defining the state of a permission.
    /// </summary>
    public enum PermissionState
    {
        /// <summary>
        /// Represents that the permission is denied.
        /// </summary>
        Denied,
        /// <summary>
        /// Represents that the permission is granted.
        /// </summary>
        Granted,
        /// <summary>
        /// Represents that the permission is neither explicitly granted nor denied.
        /// </summary>
        Unset
    }
}
