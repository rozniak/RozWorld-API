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

using Oddmatics.RozWorld.API.Client.Input;
using Oddmatics.RozWorld.API.Generic;
using System;

namespace Oddmatics.RozWorld.API.Client
{
    /// <summary>
    /// Represents a graphics renderer for the RozWorld client.
    /// </summary>
    public abstract class Renderer
    {
        /// <summary>
        /// Gets whether this Renderer is initialised.
        /// </summary>
        public abstract bool Initialised { get; protected set; }

        /// <summary>
        /// Gets the InputUpdateCallback for this Renderer.
        /// </summary>
        protected InputUpdateCallback InputUpdateCallback
        {
            get { return _InputUpdateCallback; }
            set { if (_InputUpdateCallback == null) _InputUpdateCallback = value; else
                    throw new InvalidOperationException("Renderer.InputUpdateCallback.Set: Cannot set input update callback, it is not null."); }
        }
        private InputUpdateCallback _InputUpdateCallback;

        /// <summary>
        /// Gets the amount of windows active.
        /// </summary>
        public abstract byte WindowCount { get; }


        /// <summary>
        /// Occurs when the user closes the renderer's last window.
        /// </summary>
        public event EventHandler Closed;


        /// <summary>
        /// Initialises this Renderer.
        /// </summary>
        /// <returns>True if the renderer was successfully initialised.</returns>
        public abstract bool Initialise();
        
        /// <summary>
        /// Attempts to set the amount of live windows.
        /// </summary>
        /// <param name="count">The amount of windows to set.</param>
        public abstract void SetWindows(byte count);

        /// <summary>
        /// Sets the size of a given window.
        /// </summary>
        /// <param name="window">The index of the window.</param>
        /// <param name="width">The new width.</param>
        /// <param name="height">The new height</param>
        public abstract void SetWindowSize(byte window, short width, short height);

        /// <summary>
        /// Starts this Renderer.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Stops this Renderer.
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// Informs this Renderer that the screen(s) should be updated.
        /// </summary>
        public abstract void Update();
    }
}
