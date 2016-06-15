/**
 * Oddmatics.RozWorld.API.Server.Entity.ServerEntityUpdate -- RozWorld World's Weather
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Entity
{
    /// <summary>
    /// Specifies constants defining the update type of a server entity.
    /// </summary>
    public enum ServerEntityUpdate
    {
        /// <summary>
        /// Represents that no updates are permitted.
        /// </summary>
        None,
        /// <summary>
        /// Represents that velocity updates are permitted.
        /// </summary>
        Velocity,
        /// <summary>
        /// Represents that location updates are permitted.
        /// </summary>
        Location,
        /// <summary>
        /// Represents that animation updates are permitted.
        /// </summary>
        Animation
    }
}
