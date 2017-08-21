/**
 * Oddmatics.RozWorld.API.Server.Event.HealthCauseEvent -- RozWorld Server Health Changed with Cause Event
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
    /// Represents the method that will handle the DamageTaken and Healed events of a LivingEntity.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A HealthCauseEventArgs object that contains event data.</param>
    public delegate void HealthCauseEventHandler(object sender, HealthCauseEventArgs e);


    /// <summary>
    /// Provides data for the LivingEntity.DamageTaken and LivingEntity.Healed events.
    /// </summary>
    public class HealthCauseEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the object responsible for the health change.
        /// </summary>
        public object Causer { get; private set; }

        /// <summary>
        /// Gets the object that was used to change the health.
        /// </summary>
        public object CausedWith { get; private set; }

        /// <summary>
        /// Gets the health change that occurred.
        /// </summary>
        public int Difference { get; private set; }

        /// <summary>
        /// Gets the new health.
        /// </summary>
        public int NewHealth { get; private set; }


        /// <summary>
        /// Initialises a new instance of the HeathCauseEventArgs class with specified properties.
        /// </summary>
        /// <param name="causer">The subject causer of the health change, cast as an object.</param>
        /// <param name="difference">The health change that occurred.</param>
        /// <param name="newHealth">The new health.</param>
        public HealthCauseEventArgs(object causer, int difference, int newHealth)
        {
            Causer = causer;
            Difference = difference;
            NewHealth = newHealth;
        }

        /// <summary>
        /// Initialises a new instance of the HeathCauseEventArgs class with specified properties.
        /// </summary>
        /// <param name="causer">The subject causer of the health change, cast as an object.</param>
        /// <param name="causedWith">The object used to cause health change, cast as an object.</param>
        /// <param name="difference">The health change that occurred.</param>
        /// <param name="newHealth">The new health.</param>
        public HealthCauseEventArgs(object causer, object causedWith, int difference, int newHealth)
        {
            Causer = causer;
            CausedWith = causedWith;
            Difference = difference;
            NewHealth = newHealth;
        }
    }
}
