/**
 * Oddmatics.RozWorld.API.Client.Window.IRendererInterface -- RozWorld Client Renderer Controller Interface
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Window
{
    /// <summary>
    /// Represents a controller for issuing commands to the active renderer.
    /// </summary>
    public interface IRendererInterface
    {
        /// <summary>
        /// Adds an instruction to the render instruction queue.
        /// </summary>
        /// <param name="window">The window index.</param>
        /// <param name="instruction">The instruction.</param>
        /// <returns>The ID of the instruction as it exists in the queue.</returns>
        uint AddInstruction(byte window, AbstractRendererInstruction instruction);

        /// <summary>
        /// Acquires an ID for a loaded font.
        /// </summary>
        /// <param name="font">The definitions for the font to load.</param>
        /// <returns>The ID of the font resource that was loaded.</returns>
        uint GetFont(FontInfo font);

        /// <summary>
        /// Removes an instruction from the render instruction queue.
        /// </summary>
        /// <param name="window">The window index.</param>
        /// <param name="id">The ID of the instruction.</param>
        void RemoveInstruction(byte window, uint id);
    }
}
