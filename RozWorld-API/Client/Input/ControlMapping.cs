/**
 * Oddmatics.RozWorld.API.Client.Input.ControlMapping -- RozWorld Client Profile Control Mapping
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Client.Input
{
    /// <summary>
    /// Represents the control mapping scheme for a player's profile.
    /// </summary>
    public class ControlMapping : ICloneable
    {
        /// <summary>
        /// Gets or sets the control used to move the cursor down.
        /// </summary>
        public byte CursorMoveDown;

        /// <summary>
        /// Gets or sets the control used to move the cursor left.
        /// </summary>
        public byte CursorMoveLeft;

        /// <summary>
        /// Gets or sets the control used to move the cursor right.
        /// </summary>
        public byte CursorMoveRight;

        /// <summary>
        /// Gets or sets the control used to move the cursor up.
        /// </summary>
        public byte CursorMoveUp;

        /// <summary>
        /// Gets or sets the control used to make the cursor press.
        /// </summary>
        public byte CursorPress;

        /// <summary>
        /// Gets or sets the control used to make the cursor release.
        /// </summary>
        public byte CursorRelease;
    }
}
