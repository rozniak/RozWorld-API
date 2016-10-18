/**
 * Oddmatics.RozWorld.API.Client.Input.InputType -- RozWorld Client Input Type Definitions
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
    /// Specifies constants defining the current input status update.
    /// </summary>
    public enum InputType
    {
        /// <summary>
        /// Represents a keyboard key being pressed down.
        /// </summary>
        KeyboardKeyPress,
        /// <summary>
        /// Represents a keyboard key being released.
        /// </summary>
        KeyboardKeyRelease,
        /// <summary>
        /// Represents a mouse button being pressed down.
        /// </summary>
        MouseButtonPress,
        /// <summary>
        /// Represents a mouse button being released.
        /// </summary>
        MouseButtonRelease,
        /// <summary>
        /// Represents an Xbox 360 controller button being pressed down.
        /// </summary>
        XboxButtonPress,
        /// <summary>
        /// Represents an Xbox 360 controller button being released.
        /// </summary>
        XboxButtonRelease,
        /// <summary>
        /// Represents an Xbox 360 controller's left analog stick being moved horizontally.
        /// </summary>
        XboxLeftAnalogXAt,
        /// <summary>
        /// Represents an Xbox 360 controller's left analog stick being moved vertically.
        /// </summary>
        XboxLeftAnalogYAt,
        /// <summary>
        /// Represents an Xbox 360 controller's left trigger being moved.
        /// </summary>
        XboxLeftTriggerAt,
        /// <summary>
        /// Represents an Xbox 360 controller's right analog stick being moved horizontally.
        /// </summary>
        XboxRightAnalogXAt,
        /// <summary>
        /// Represents an Xbox 360 controller's right analog stick being moved vertically.
        /// </summary>
        XboxRightAnalogYAt,
        /// <summary>
        /// Represents an Xbox 360 controller's right trigger being moved.
        /// </summary>
        XboxRightTriggerAt
    }
}
