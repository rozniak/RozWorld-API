/**
 * Oddmatics.RozWorld.API.Server.Event.HealthCauseEventHandler -- RozWorld Server Health Changed with Cause Event Handler
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
    /// Represents the method that will handle a LivingEntity's DamageTaken and Healed events.
    /// </summary>
    /// <param name="sender">The LivingEntity instance that fired the event.</param>
    /// <param name="cause">The object that was the cause of the health change.</param>
    /// <param name="newHealth">The new health value of the LivingEntity.</param>
    /// <param name="difference">The difference in change in health.</param>
    public delegate void HealthCauseEventHandler(LivingEntity sender, object cause, int newHealth, int difference);
}
