/**
 * Oddmatics.RozWorld.API.Server.Event.HealthChangedEvent -- RozWorld Server Health Changed Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entities;
using System;

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents the method that will handle the HealthChanged event of a LivingEntity.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A HealthChangedEventArgs object that contains event data.</param>
    public delegate void HealthChangedEventHandler(object sender, HealthChangedEventArgs e);


    /// <summary>
    /// Provides data for the LivingEntity.HealthChanged event.
    /// </summary>
    public class HealthChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the health change that occurred.
        /// </summary>
        public int Difference { get; private set; }

        /// <summary>
        /// Gets the new health.
        /// </summary>
        public int NewHealth { get; private set; }


        /// <summary>
        /// Initialises a new instance of the HealthChangedEventArgs class with health difference and new health properties.
        /// </summary>
        /// <param name="difference">The health change that occurred.</param>
        /// <param name="newHealth">The new health.</param>
        public HealthChangedEventArgs(int difference, int newHealth)
        {
            Difference = difference;
            NewHealth = newHealth;
        }
    }
}
