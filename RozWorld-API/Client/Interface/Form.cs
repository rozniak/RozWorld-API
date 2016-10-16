/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.Form -- RozWorld Client Interface Form
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Client.Interface.Control;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a single interface form for the RozWorld client's interface handler.
    /// </summary>
    public abstract class Form : IControlContainer
    {
        /// <summary>
        /// Gets whether this Form is active or not.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets the controls of this Form as an IList&lt;IControl&gt; collection.
        /// </summary>
        public IList<IControl> Controls { get { return null; } } // TODO: Code this

        /// <summary>
        /// Gets the parent IInterfaceHandler of this Form.
        /// </summary>
        public IInterfaceHandler Parent { get { return null; } } // TODO: Code this
    }
}
