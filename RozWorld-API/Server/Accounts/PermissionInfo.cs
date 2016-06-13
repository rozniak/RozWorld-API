/**
 * Oddmatics.RozWorld.API.Server.Accounts.PermissionInfo -- RozWorld Permission Info
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Accounts
{
    /// <summary>
    /// Represents information regarding a registered permission.
    /// </summary>
    public struct PermissionInfo
    {
        /// <summary>
        /// Gets the registrar of the associated permission. 
        /// </summary>
        string Registrar { get; private set; }

        /// <summary>
        /// Gets the description of the associated permission.
        /// </summary>
        string Description { get; private set; }


        /// <summary>
        /// Initializes a new instance of the PermissionInfo class with a registrar and description.
        /// </summary>
        /// <param name="registrar">The registrar of the associated permission.</param>
        /// <param name="description">The description of the associated permission.</param>
        public PermissionInfo(string registrar, string description)
            : this()
        {
            Registrar = registrar;
            Description = description;
        }
    }
}
