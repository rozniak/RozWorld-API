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
    public interface IControlMapping : ICloneable
    {
        /// <summary>
        /// Gets or sets the control used to move the cursor down.
        /// </summary>
        byte CursorMoveDown { get; set; }

        /// <summary>
        /// Gets or sets the control used to move the cursor left.
        /// </summary>
        byte CursorMoveLeft { get; set; }

        /// <summary>
        /// Gets or sets the control used to move the cursor right.
        /// </summary>
        byte CursorMoveRight { get; set; }

        /// <summary>
        /// Gets or sets the control used to move the cursor up.
        /// </summary>
        byte CursorMoveUp { get; set; }

        /// <summary>
        /// Gets or sets the control used to make the cursor press.
        /// </summary>
        byte CursorPress { get; set; }

        /// <summary>
        /// Gets or sets the control used to make the cursor release.
        /// </summary>
        byte CursorRelease { get; set; }

        /// <summary>
        /// Gets or sets the control used to scroll down.
        /// </summary>
        byte ScrollDown { get; set; }

        /// <summary>
        /// Gets or sets the control used to scroll up.
        /// </summary>
        byte ScrollUp { get; set; }


        /// <summary>
        /// Sets this IControlMapping to defaults.
        /// </summary>
        void SetToDefaults();
    }
}
