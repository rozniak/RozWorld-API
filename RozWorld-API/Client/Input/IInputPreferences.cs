/**
 * Oddmatics.RozWorld.API.Client.Input.IInputPreferences -- RozWorld Client Profile Input Preferences
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Input
{
    /// <summary>
    /// Represents input preferences for a player's profile.
    /// </summary>
    public interface IInputPreferences
    {
        /// <summary>
        /// Gets or sets the ControlMethod being used.
        /// </summary>
        ControlMethod ControlMethod { get; set; }

        /// <summary>
        /// Gets or sets whether to use the gamepad-controlled cursor in dialogs when left to user preference.
        /// </summary>
        bool UseCursorInDialogs { get; set; }

        /// <summary>
        /// Gets or sets the left analog stick's inner deadzone for the x-axis.
        /// </summary>
        byte XboxLeftAnalogXDeadzone { get; set; }

        /// <summary>
        /// Gets or sets the left analog stick's inner deadzone for the y-axis.
        /// </summary>
        byte XboxLeftAnalogYDeadzone { get; set; }

        /// <summary>
        /// Gets or sets the left trigger's activation threshold.
        /// </summary>
        byte XboxLeftTriggerThreshold { get; set; }

        /// <summary>
        /// Gets or sets the right analog stick's inner deadzone for the x-axis.
        /// </summary>
        byte XboxRightAnalogXDeadzone { get; set; }

        /// <summary>
        /// Gets or sets the right analog stick's inner deadzone for the y-axis.
        /// </summary>
        byte XboxRightAnalogYDeadzone { get; set; }

        /// <summary>
        /// Gets or sets the right trigger's activation threshold.
        /// </summary>
        byte XboxRightTriggerThreshold { get; set; }
    }
}
