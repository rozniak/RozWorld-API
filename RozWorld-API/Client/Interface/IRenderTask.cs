/**
 * Oddmatics.RozWorld.API.Client.Interface.IRenderTask -- RozWorld Client Renderer Task
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a task that is operated by the renderer.
    /// </summary>
    public interface IRenderTask
    {
        /// <summary>
        /// Gets or sets the location that this render task takes place at.
        /// </summary>
        Location Location { get; set; }

        /// <summary>
        /// Gets or sets the opacity of this render task.
        /// </summary>
        float Opacity { get; set; }

        /// <summary>
        /// Gets or sets the name of the texture resource to use.
        /// </summary>
        string TextureName { get; set; }
    }
}
