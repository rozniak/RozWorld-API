/**
 * Oddmatics.RozWorld.API.Generic.Event -- RozWorld Game Update Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Generic.Event
{
    /// <summary>
    /// Represents the method that will handle the Updated event of an IRwGame.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A GameUpdateEventArgs object that contains the event data.</param>
    public delegate void GameUpdateEventHandler(object sender, GameUpdateEventArgs e);


    /// <summary>
    /// Provides data for the IRwGame.Updated event.
    /// </summary>
    public class GameUpdateEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the time elapsed since the last game update.
        /// </summary>
        public float DeltaTime { get; private set; }


        /// <summary>
        /// Initialises a new instance fo the GameUpdateEventArgs class with a specified time delta.
        /// </summary>
        /// <param name="deltaTime">The time elapsed since the last game update.</param>
        public GameUpdateEventArgs(float deltaTime)
        {
            DeltaTime = deltaTime;
        }
    }
}
