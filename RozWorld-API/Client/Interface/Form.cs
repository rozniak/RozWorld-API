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
using Oddmatics.RozWorld.API.Generic;
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
        /// Gets the child controls of this Form as a List&lt;IControl&gt; collection.
        /// </summary>
        public List<IControl> Controls { get { return _Controls; } }
        private List<IControl> _Controls = new List<IControl>();

        /// <summary>
        /// Gets or sets the Location of this Form.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Gets the parent IInterfaceHandler of this Form.
        /// </summary>
        public IInterfaceHandler Parent
        {
            get { return _Parent; }
            set
            {
                if (value.Forms.Contains(this))
                    _Parent = value;
            }
        }
        private IInterfaceHandler _Parent;
    }
}
