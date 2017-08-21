/**
 * Oddmatics.RozWorld.API.Client.Input.ControlMethod -- RozWorld Client Control Method Definitions
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Input
{
    /// <summary>
    /// Specifies constants defining a selected method of input.
    /// </summary>
    public enum ControlMethod
    {
        /// <summary>
        /// Represents that input will be read from the attached keyboard and mouse.
        /// </summary>
        KeyboardAndMouse,
        /// <summary>
        /// Represents that input will be read from the keyboard only.
        /// </summary>
        KeyboardOnly,
        /// <summary>
        /// Represents that no input method has been specified.
        /// </summary>
        Unset,
        /// <summary>
        /// Represents that input will be read from the first Xbox 360 controller.
        /// </summary>
        XboxControllerOne,
        /// <summary>
        /// Represents that input will be read from the second Xbox 360 controller.
        /// </summary>
        XboxControllerTwo,
        /// <summary>
        /// Represents that input will be read from the third Xbox 360 controller.
        /// </summary>
        XboxControllerThree,
        /// <summary>
        /// Represents that input will be read from the fourth Xbox 360 controller.
        /// </summary>
        XboxControllerFour,
    }
}
