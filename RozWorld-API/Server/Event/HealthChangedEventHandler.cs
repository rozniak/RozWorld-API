/**
 * Oddmatics.RozWorld.API.Server.Event.HealthChangedEventHandler -- RozWorld Server Health Changed Event Handler
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
    /// Represents the method that will handle a LivingEntity's HealthChanged event.
    /// </summary>
    /// <param name="sender">The LivingEntity instance that fired the event.</param>
    /// <param name="newHealth">The new health of the LivingEntity.</param>
    public delegate void HealthChangedEventHandler(LivingEntity sender, int newHealth);
}
