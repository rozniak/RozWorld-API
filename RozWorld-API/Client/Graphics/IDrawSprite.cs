/**
 * Oddmatics.RozWorld.API.Client.Graphics.IDrawSprite -- RozWorld Client Renderer Sprite
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

namespace Oddmatics.RozWorld.API.Client.Graphics
{
    /// <summary>
    /// Represents an individual sprite to be drawn by the renderer in a given job.
    /// </summary>
    public interface IDrawSprite : IDisposable
    {
        /// <summary>
        /// Gets or sets the point in which to start blitting from.
        /// </summary>
        RwPoint BlitStart { get; set; }

        /// <summary>
        /// Gets or sets the point in which to start blitting to.
        /// </summary>
        RwPoint BlitEnd { get; set; }

        /// <summary>
        /// Gets or sets the tint to apply to this sprite.
        /// </summary>
        Colour Colour { get; set; }

        /// <summary>
        /// Gets the point at which to draw this sprite to the viewport.
        /// </summary>
        RwPoint Location { get; set; }

        /// <summary>
        /// Gets or sets the amount to rotate this sprite, in radians.
        /// </summary>
        float Rotation { get; set; }
    }
}
