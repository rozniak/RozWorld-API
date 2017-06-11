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
using System;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a task that is operated by the renderer.
    /// </summary>
    public interface IRenderTask : IDisposable
    {
        /// <summary>
        /// Gets or sets the list of render parts in this task.
        /// </summary>
        List<RenderPart> Parts { get; set; }

        /// <summary>
        /// Gets or sets the rotation amount (in radians) that will be applied to all render parts in this task.
        /// </summary>
        float Rotation { get; set; }

        /// <summary>
        /// Gets or sets the rotation origin that will be used when rotating all render parts in this task.
        /// </summary>
        Location RotationOrigin { get; set; }

        /// <summary>
        /// Gets or sets the tint effect that will be applied to all render parts in this task.
        /// </summary>
        byte[] Tint { get; set; }
        

        /// <summary>
        /// Constructs or reconstructs this task ready for the renderer to use.
        /// </summary>
        /// <returns>Success if the task was constructed.</returns>
        RwResult ConstructNow();
    }
}
