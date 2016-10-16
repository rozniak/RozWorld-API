/**
 * Oddmatics.RozWorld.API.Client.Interface.IControlContainer -- RozWorld Client Control Container
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
    /// Represents an object that may contain interface controls.
    /// </summary>
    public interface IControlContainer
    {
        /// <summary>
        /// Gets the child IControl instances of this IControlContainer.
        /// </summary>
        IList<IControl> Controls { get; }
    }
}
