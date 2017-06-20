/**
 * Oddmatics.RozWorld.API.Client.Interface.IRendererContext -- RozWorld Client Renderer Context
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic;

namespace Oddmatics.RozWorld.API.Client.Graphics
{
    /// <summary>
    /// Represents a renderer context to be used by interface components.
    /// </summary>
    public interface IRendererContext
    {
        /// <summary>
        /// Gets the size of the client area of the parent window.
        /// </summary>
        RwSize ClientSize { get; }


        /// <summary>
        /// Creates a font texture.
        /// </summary>
        /// <param name="fontFilename">The filename of the font file to use.</param>
        /// <param name="text">The text string.</param>
        /// <param name="pt">The font size in points (pt).</param>
        /// <param name="colour">The colour of the text.</param>
        /// <returns>The texture ID of the created font texture, -1 if the creation failed.</returns>
        int CreateFontTexture(string fontFilename, string text, byte pt, Colour colour);

        /// <summary>
        /// Creates a task for the renderer.
        /// </summary>
        /// <returns>The IRenderTask object this method creates.</returns>
        IRenderTask CreateTask();

        /// <summary>
        /// Deletes a texture.
        /// </summary>
        /// <param name="id">The ID of the texture to delete.</param>
        /// <returns>Success if the texture was deleted.</returns>
        RwResult DeleteTexture(int id);

        /// <summary>
        /// Retrieves a texture's ID by its string identifier.
        /// </summary>
        /// <param name="identifier">The texture identifier.</param>
        /// <returns>The ID of the texture if it was found, -1 otherwise.</returns>
        int GetTextureId(string identifier);
    }
}
