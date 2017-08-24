/**
 * Oddmatics.RozWorld.API.Client.Graphics.IRendererContext -- RozWorld Client Renderer Context
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
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
        /// Gets the amount of render jobs being done by this context.
        /// </summary>
        int JobCount { get; }



        /// <summary>
        /// Creates a new render job.
        /// </summary>
        /// <param name="textureIdentifier">The identifier of the texture.</param>
        /// <returns>The render job that was created, cast as an IRenderJob.</returns>
        IRenderJob CreateJob(string textureIdentifier);

        /// <summary>
        /// Creates a new render job for drawing a string.
        /// </summary>
        /// <param name="text">The string of text.</param>
        /// <param name="fontIdentifier">The identifier of the font.</param>
        /// <returns>The render job that was created, cast as an IRenderJob.</returns>
        IRenderJob CreateStringJob(string text, string fontIdentifier);

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

        /// <summary>
        /// Loads a font from the specified filepath and point size, and maps it to the given identifier.
        /// </summary>
        /// <param name="filepath">The filepath of the font.</param>
        /// <param name="pointSize">The point size to load.</param>
        /// <param name="identifier">The font identifier.</param>
        /// <returns>Success if the font was loaded and mapped to the identifier.</returns>
        RwResult LoadFont(string filepath, int pointSize, string identifier);
    }
}
