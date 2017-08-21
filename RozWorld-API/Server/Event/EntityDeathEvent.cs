/**
 * Oddmatics.RozWorld.API.Server.Event.EntityDeathEvent -- RozWorld Server Living Entity Death Event
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
    /// Represents the method that will handle the Died event of a LivingEntity.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An EntityDeathEventArgs object that contains the event data.</param>
    public delegate void EntityDeathEventHandler(object sender, EntityDeathEventArgs e);


    /// <summary>
    /// Provides data for the LivingEntity.Died event.
    /// </summary>
    public class EntityDeathEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the object that was used to kill this LivingEntity.
        /// </summary>
        public object KilledWith { get; private set; }

        /// <summary>
        /// Gets the killer responsible for the death of this LivingEntity.
        /// </summary>
        public object Killer { get; private set; }


        /// <summary>
        /// Initialises a new instance of the EntityDeathEventArgs class using the specified object as the killer.
        /// </summary>
        /// <param name="killer">An instance that represents the killer, cast as an object.</param>
        public EntityDeathEventArgs(object killer)
        {
            Killer = killer;
        }

        /// <summary>
        /// Initialises a new instance of the EntityDeathEventArgs class using the specified objects as the killer and item used.
        /// </summary>
        /// <param name="killer">An instance that represents the killer, cast as an object.</param>
        /// <param name="killedWith">An instance that represents the item used, cast as an object.</param>
        public EntityDeathEventArgs(object killer, object killedWith)
        {
            Killer = killer;
            KilledWith = killedWith;
        }
    }
}
