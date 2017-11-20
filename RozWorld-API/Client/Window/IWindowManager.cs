/**
 * Oddmatics.RozWorld.API.Client.Window.IWindowManager -- RozWorld Client Window Manager
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */
 
using System;

namespace Oddmatics.RozWorld.API.Client.Window
{
    /// <summary>
    /// Represents a window manager for the RozWorld client.
    /// </summary>
    public interface IWindowManager
    {
        /// <summary>
        /// Gets the 'nice' name of this window manager.
        /// </summary>
        string NiceName { get; }

        /// <summary>
        /// Gets the number of windows that are active in this window manager.
        /// </summary>
        byte WindowCount { get; set; }


        /// <summary>
        /// Occurs when the windows are all closed.
        /// </summary>
        event EventHandler Closed;


        /// <summary>
        /// Starts this window manager, with a single open window.
        /// </summary>
        void Start();

        /// <summary>
        /// Retrieves the latest input state from this window manager.
        /// </summary>
        /// <returns>The latest input state.</returns>
        InputUpdate GetInputEvents();

        /// <summary>
        /// Stops this window manager, closing all open windows.
        /// </summary>
        void Stop();
    }
}
