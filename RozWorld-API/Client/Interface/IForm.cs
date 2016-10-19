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

using Oddmatics.RozWorld.API.Client.Interface.Control;
using Oddmatics.RozWorld.API.Generic;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a single interface form for the RozWorld client's interface handler.
    /// </summary>
    public interface IForm : IControlContainer
    {
        /// <summary>
        /// Gets or sets whether this IForm is active.
        /// </summary>
        bool Active { get; set; }

        /// <summary>
        /// Gets or sets the Location of this IForm.
        /// </summary>
        Location Location { get; set; }

        /// <summary>
        /// Gets or sets the name of this IForm.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the parent IInterfaceHandler of this IForm.
        /// </summary>
        IInterfaceHandler Parent { get; }

        /// <summary>
        /// Gets or sets whether this IForm should maintain persistent input focus.
        /// </summary>
        bool PersistentInputFocus { get; set; }


        /// <summary>
        /// Selects the control below the currently selected control.
        /// </summary>
        void MoveSelectionDown();

        /// <summary>
        /// Selects the control to the left of the currently selected control.
        /// </summary>
        void MoveSelectionLeft();

        /// <summary>
        /// Selects the control to the right of the currently selected control.
        /// </summary>
        void MoveSelectionRight();

        /// <summary>
        /// Selects the control above the currently selected control.
        /// </summary>
        void MoveSelectionUp();
    }
}
