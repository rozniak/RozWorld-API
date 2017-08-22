/**
 * Oddmatics.RozWorld.API.Client.Graphics.IRenderJob -- RozWorld Client Renderer Job
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
    /// Represents a job for the renderer.
    /// </summary>
    public interface IRenderJob : IDisposable
    {
        /// <summary>
        /// Gets the identifier of the texture of this job.
        /// </summary>
        string TextureIdentifier { get; }


        /// <summary>
        /// Creates a draw sprite within this job.
        /// </summary>
        /// <param name="location">The top-left point to draw the sprite.</param>
        /// <param name="blitStart">The top-left point in which to start blitting from.</param>
        /// <param name="blitEnd">The bottom-right point in which to cease blitting.</param>
        /// <returns>The sprite that this method creates, cast as an IDrawSprite.</returns>
        IDrawSprite CreateSprite(RwPoint location, RwPoint blitStart, RwPoint blitEnd);

        /// <summary>
        /// Creates a draw sprite within this job.
        /// </summary>
        /// <param name="location">The top-left point to draw the sprite.</param>
        /// <param name="blitStart">The top-left point in which to start blitting from.</param>
        /// <param name="blitEnd">The bottom-right point in which to cease blitting.</param>
        /// <param name="rotation">The amount to rotate the sprite, in radians.</param>
        /// <returns>The sprite that this method creates, cast as an IDrawSprite.</returns>
        IDrawSprite CreateSprite(RwPoint location, RwPoint blitStart, RwPoint blitEnd, float rotation);

        /// <summary>
        /// Creates a draw sprite within this job.
        /// </summary>
        /// <param name="location">The top-left point to draw the sprite.</param>
        /// <param name="blitStart">The top-left point in which to start blitting from.</param>
        /// <param name="blitEnd">The bottom-right point in which to cease blitting.</param>
        /// <param name="colour">The tint to apply to the sprite.</param>
        /// <returns>The sprite that this method creates, cast as an IDrawSprite.</returns>
        IDrawSprite CreateSprite(RwPoint location, RwPoint blitStart, RwPoint blitEnd, float rotation, Colour colour);
    }
}
