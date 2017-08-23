/**
 * Oddmatics.RozWorld.API.Client.IRenderer -- RozWorld Client Renderer
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Client.Input;
using Oddmatics.RozWorld.API.Generic;
using System;

namespace Oddmatics.RozWorld.API.Client.Graphics
{
    /// <summary>
    /// Represents a graphics renderer for the RozWorld client.
    /// </summary>
    public abstract class Renderer
    {
        /// <summary>
        /// Gets the value that indicates whether this renderer has been initialised.
        /// </summary>
        public virtual bool Initialised { get; protected set; }

        /// <summary>
        /// Gets the InputUpdateCallback for this renderer.
        /// </summary>
        protected InputUpdateCallback InputUpdateCallback
        {
            get { return _InputUpdateCallback; }
            set { if (_InputUpdateCallback == null) _InputUpdateCallback = value; else
                    throw new InvalidOperationException("Renderer.InputUpdateCallback.Set: Cannot set input update callback, it is not null."); }
        }
        private InputUpdateCallback _InputUpdateCallback;

        /// <summary>
        /// Gets the amount of windows active in this renderer.
        /// </summary>
        public abstract byte WindowCount { get; }


        /// <summary>
        /// Occurs when the user closes this renderer's last window.
        /// </summary>
        public abstract event EventHandler Closed;


        /// <summary>
        /// Gets the render context of a window.
        /// </summary>
        /// <param name="window">The index of the window.</param>
        /// <returns>The IRendererContext used by the window if it was found, null otherwise.</returns>
        public abstract IRendererContext GetContext(byte window);

        /// <summary>
        /// Initialises this renderer.
        /// </summary>
        /// <returns>True if the renderer was successfully initialised.</returns>
        public abstract bool Initialise();

        /// <summary>
        /// Loads a font from the specified filepath and point size, and maps it to the given identifier.
        /// </summary>
        /// <param name="filepath">The filepath of the font.</param>
        /// <param name="pointSize">The point size to load.</param>
        /// <param name="identifier">The font identifier.</param>
        /// <returns>Success if the font was loaded and mapped to the identifier.</returns>
        public abstract RwResult LoadFont(string filepath, int pointSize, string identifier);

        /// <summary>
        /// Renders the next frame to all contexts.
        /// </summary>
        public abstract void RenderFrame();
        
        /// <summary>
        /// Sets the amount of windows in this renderer.
        /// </summary>
        /// <param name="count">The amount of windows.</param>
        public abstract void SetWindows(byte count);

        /// <summary>
        /// Sets the size of a window.
        /// </summary>
        /// <param name="window">The index of the window.</param>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height</param>
        public abstract void SetWindowSize(byte window, short width, short height);

        /// <summary>
        /// Starts this renderer.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Stops this renderer.
        /// </summary>
        public abstract void Stop();
    }
}
