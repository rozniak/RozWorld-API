/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.IForm -- RozWorld Client Interface Form
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using Oddmatics.RozWorld.API.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a single interface form for the RozWorld client's interface handler.
    /// </summary>
    public abstract class Form : IControlContainer
    {
        /// <summary>
        /// Gets or sets whether this form is active.
        /// </summary>
        public bool Focused
        {
            get
            {
                return Parent?.FocusedForm == this;
            }
        }

        /// <summary>
        /// Gets or sets the location of this form.
        /// </summary>
        Location Location { get; set; }

        /// <summary>
        /// Gets or sets the name of this form.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the parent IInterfaceHandler object of this form.
        /// </summary>
        public IInterfaceHandler Parent { get; protected set; }

        /// <summary>
        /// Gets whether this form should maintain persistent input focus.
        /// </summary>
        public bool PersistentInputFocus { get; }

        /// <summary>
        /// Gets the collection of controls contained within the control.
        /// </summary>
        public ControlCollection Controls { get; protected set; }

        /// <summary>
        /// Gets or sets the currently focused control.
        /// </summary>
        public Control FocusedControl { get; set; }


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
