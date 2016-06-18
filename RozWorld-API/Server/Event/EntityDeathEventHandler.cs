/**
 * Oddmatics.RozWorld.API.Server.Event.EntityDeathEventHandler -- RozWorld Server Living Entity Death Event Handler
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entities;

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents the method that will handle a LivingEntity's Died event.
    /// </summary>
    /// <param name="sender">The LivingEntity instance that fired the event.</param>
    /// <param name="cause">The object that was the cause of death.</param>
    public delegate void EntityDeathEventHandler(LivingEntity sender, object cause);
}
