/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.Control -- RozWorld Client Interface Control
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic;
using System;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a single interface control inside of a Form.
    /// </summary>
    public abstract class Control
    {
        /// <summary>
        /// Gets whether this control can be focused.
        /// </summary>
        public abstract bool CanFocus { get; }

        /// <summary>
        /// Gets whether this control is currently focused.
        /// </summary>
        public bool Focused
        {
            get { return Parent?.FocusedControl == this; }
        }

        /// <summary>
        /// Gets or sets the control that is above this control, and will be selected when moving up.
        /// </summary>
        public Control ControlAbove { get; set; }

        /// <summary>
        /// Gets or sets the control that is below this control, and will be selected when moving down.
        /// </summary>
        public Control ControlBelow { get; set; }

        /// <summary>
        /// Gets or sets the control that is on the left of this control, and will be selected when moving left.
        /// </summary>
        public Control ControlLeft { get; set; }

        /// <summary>
        /// Gets or sets the control that is on the right of this control, and will be selected when moving right.
        /// </summary>
        public Control ControlRight { get; set; }

        /// <summary>
        /// Gets or sets the location of this IControl.
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        /// Gets or sets the name of this control.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parent container of this control.
        /// </summary>
        IControlContainer Parent { get; set; }


        /// <summary>
        /// Occurs when the cursor enters the bounds of this control.
        /// </summary>
        public event EventHandler CursorEnter;

        /// <summary>
        /// Occurs when the cursor leaves the bounds of this control.
        /// </summary>
        public event EventHandler CursorLeave;


        /// <summary>
        /// Gives focus to this control.
        /// </summary>
        public void Focus()
        {
            if (!CanFocus)
                throw new InvalidOperationException("Control.Focus: This control is not allowed to be focused.");

            if (Parent == null)
                throw new InvalidOperationException("Control.Focus: This control cannot be focused as no parent object reference has been set.");

            Parent.FocusedControl = this;
        }

        /// <summary>
        /// Inform the renderer that the specified parts must be redrawn.
        /// </summary>
        public void Invalidate(int[] parts)
        {
            // TODO: Code this
        }
    }
}
