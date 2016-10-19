/**
 * Oddmatics.RozWorld.API.Client.Input.IMouse -- Mouse Controls Statuses
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Input
{
    /// <summary>
    /// Represents the mouse.
    /// </summary>
    public interface IMouse
    {
        /// <summary>
        /// Gets the currently pressed buttons as an IList&lt;byte&gt; collection.
        /// </summary>
        IList<byte> ButtonsDown { get; }

        /// <summary>
        /// Gets the currently released buttons as an IList&lt;bytegt; collection.
        /// </summary>
        IList<byte> ButtonsUp { get; }

        /// <summary>
        /// Gets the Location of the mouse pointer.
        /// </summary>
        Location Location { get; }
    }
}
