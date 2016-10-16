/**
 * Oddmatics.RozWorld.API.Client.IRenderer -- RozWorld Client Renderer
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client
{
    /// <summary>
    /// Represents a graphics renderer for the RozWorld client.
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// Gets whether this IRenderer is initialised or not.
        /// </summary>
        bool Initialised { get; }

        /// <summary>
        /// Gets the amount of windows active.
        /// </summary>
        byte WindowCount { get; }


        /// <summary>
        /// Initialises this IRenderer.
        /// </summary>
        void Initialise();
        
        /// <summary>
        /// Attempts to set the amount of live windows.
        /// </summary>
        /// <param name="count">The amount of windows to set.</param>
        void SetWindows(byte count);

        /// <summary>
        /// Sets the size of a given window.
        /// </summary>
        /// <param name="window">The index of the window.</param>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height</param>
        void SetWindowSize(byte window, short width, short height);
    }
}
