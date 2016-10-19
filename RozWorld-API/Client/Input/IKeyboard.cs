/**
 * Oddmatics.RozWorld.API.Client.Input.IKeyboard -- Keyboard Controls Statuses
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Input
{
    /// <summary>
    /// Represents the keyboard.
    /// </summary>
    public interface IKeyboard
    {
        /// <summary>
        /// Gets the currently pressed keys as an IList&lt;byte&gt; collection.
        /// </summary>
        IList<byte> KeysDown { get; }

        /// <summary>
        /// Gets the currently released keys as an IList&lt;byte&gt; collection.
        /// </summary>
        IList<byte> KeysUp { get; }
    }
}
