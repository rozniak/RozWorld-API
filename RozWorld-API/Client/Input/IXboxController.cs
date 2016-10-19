/**
 * Oddmatics.RozWorld.API.Client.Input.IXboxController -- Xbox 360 Controller Controls Statuses
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
    /// Represents an Xbox 360 controller.
    /// </summary>
    public interface IXboxController
    {
        /// <summary>
        /// Gets whether this Xbox controller is plugged in.
        /// </summary>
        bool Active { get; }

        /// <summary>
        /// Gets the currently pressed buttons as an IList&lt;byte&gt; collection.
        /// </summary>
        IList<byte> ButtonsDown { get; }

        /// <summary>
        /// Gets the currently released buttons as an IList&lt;byte&gt; collection.
        /// </summary>
        IList<byte> ButtonsUp { get; }

        /// <summary>
        /// Gets the amount of horizontal movement for the left analog stick.
        /// </summary>
        byte LeftAnalogX { get; }

        /// <summary>
        /// Gets the amount of vertical movement for the left analog stick.
        /// </summary>
        byte LeftAnalogY { get; }

        /// <summary>
        /// Gets the amount that the left trigger is pressed by.
        /// </summary>
        byte LeftTriggerZ { get; }

        /// <summary>
        /// Gets the amount of horizontal movement for the right analog stick.
        /// </summary>
        byte RightAnalogX { get; }

        /// <summary>
        /// Gets the amount of vertical movement for the right analog stick.
        /// </summary>
        byte RightAnalogY { get; }

        /// <summary>
        /// Gets the amount that the right trigger is pressed by.
        /// </summary>
        byte RightTriggerZ { get; }
    }
}
