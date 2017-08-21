/**
 * Oddmatics.RozWorld.API.Generic.RwInstanceType -- RozWorld Instance Type
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Specifies constants defining what kind of instance RozWorld is running under.
    /// </summary>
    public enum RwInstanceType
    {
        /// <summary>
        /// Represents that the instance type has not been stated.
        /// </summary>
        Unset,
        /// <summary>
        /// Represents that this instance is client-only.
        /// </summary>
        ClientOnly,
        /// <summary>
        /// Represents that this instance is server-only.
        /// </summary>
        ServerOnly,
        /// <summary>
        /// Represents that this is a client and local server instance.
        /// </summary>
        Both
    }
}
