/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.Form -- RozWorld Client Interface Form
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */
 
using Oddmatics.RozWorld.API.Generic;
using System;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a single interface form for the RozWorld client's interface handler.
    /// </summary>
    public abstract class Form : IControlContainer
    {
        /// <summary>
        /// Gets whether this form can be focused.
        /// </summary>
        public abstract bool CanFocus { get; }

        /// <summary>
        /// Gets whether this form is currently focused.
        /// </summary>
        public bool Focused
        {
            get { return Parent?.FocusedForm == this; }
        }

        /// <summary>
        /// Gets or sets the location of this form.
        /// </summary>
        public virtual RwPoint Location { get; set; }

        /// <summary>
        /// Gets or sets the name of this form.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the parent IInterfaceHandler object of this form.
        /// </summary>
        public IInterfaceHandler Parent { get; protected set; }

        /// <summary>
        /// Gets whether this form should maintain persistent input focus.
        /// </summary>
        public abstract bool PersistentInputFocus { get; }

        /// <summary>
        /// Gets the collection of controls contained within the control.
        /// </summary>
        public ControlCollection Controls { get; protected set; }

        /// <summary>
        /// Gets or sets the currently focused control.
        /// </summary>
        public Control FocusedControl { get; set; }


        /// <summary>
        /// Gives focus to this form.
        /// </summary>
        public void Focus()
        {
            if (!CanFocus)
                throw new InvalidOperationException("Form.Focus: This control is not allowed to be focused.");

            if (Parent == null)
                throw new InvalidOperationException("Form.Focus: This control cannot be focused as no parent object reference has been set.");

            Parent.FocusedForm = this;
        }

        /// <summary>
        /// Selects the control below the currently selected control.
        /// </summary>
        public void MoveSelectionDown()
        {
            // TODO: Code this
        }

        /// <summary>
        /// Selects the control to the left of the currently selected control.
        /// </summary>
        public void MoveSelectionLeft()
        {
            // TODO: Code this
        }

        /// <summary>
        /// Selects the control to the right of the currently selected control.
        /// </summary>
        public void MoveSelectionRight()
        {
            // TODO: Code this
        }

        /// <summary>
        /// Selects the control above the currently selected control.
        /// </summary>
        public void MoveSelectionUp()
        {
            // TODO: Code this
        }
    }
}
