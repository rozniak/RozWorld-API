/**
 * Oddmatics.RozWorld.API.Client.Interface.IControlContainer -- RozWorld Client Control Container
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents an object that may contain interface controls.
    /// </summary>
    public interface IControlContainer
    {
        /// <summary>
        /// Gets the child controls of this container as an IList&lt;IControl&gt; collection.
        /// </summary>
        ControlCollection Controls { get; }
        
        /// <summary>
        /// Gets or sets the currently focused control.
        /// </summary>
        Control FocusedControl { get; set; }
    }
}
