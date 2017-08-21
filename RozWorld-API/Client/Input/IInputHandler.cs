/**
 * Oddmatics.RozWorld.API.Client.Input.IInputHandler -- RozWorld Client Input Handler
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Input
{
    /// <summary>
    /// Represents the main input handler for RozWorld client.
    /// </summary>
    public interface IInputHandler
    {
        /// <summary>
        /// Gets the currently defined controls as an IList&lt;string&gt; collection.
        /// </summary>
        IList<string> DefinedControls { get; }

        /// <summary>
        /// Gets the status of the keyboard.
        /// </summary>
        IKeyboard Keyboard { get; }

        /// <summary>
        /// Gets the status of the mouse.
        /// </summary>
        IMouse Mouse { get; }

        /// <summary>
        /// Gets the statuses of Xbox controllers as an IList&lt;IXboxController&gt; collection.
        /// </summary>
        IList<IXboxController> XboxController { get; }
    }
}
