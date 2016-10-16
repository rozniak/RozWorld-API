/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.IControl -- RozWorld Client Interface Control
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface.Control
{
    /// <summary>
    /// Represents a single interface control inside of a Form.
    /// </summary>
    public interface IControl
    {
        /// <summary>
        /// Gets or sets the Location of this IControl.
        /// </summary>
        Location Location { get; set; }

        /// <summary>
        /// Gets the parent Form of this IControl.
        /// </summary>
        Form Parent { get; }


        /// <summary>
        /// Inform the renderer that the specified parts must be redrawn.
        /// </summary>
        void Invalidate(int[] parts);
    }
}
