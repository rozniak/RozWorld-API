/**
 * Oddmatics.RozWorld.API.Client.Interface.GamepadCursorMode -- RozWorld Client Gamepad Cursor Mode
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Specifies constants defining the enabled state of the gamepad-controlled cursor.
    /// </summary>
    public enum GamepadCursorMode
    {
        /// <summary>
        /// Represents that the gamepad-controlled cursor should be enabled.
        /// </summary>
        Enabled,
        /// <summary>
        /// Represents that the gamepad-controlled cursor should be disabled.
        /// </summary>
        Disabled,
        /// <summary>
        /// Represents that the gamepad-controlled cursor's enabled state should be left to user preference.
        /// </summary>
        UserPreference
    }
}
