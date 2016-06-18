/**
 * Oddmatics.RozWorld.API.Server.Event.StateChangedEventHandler -- RozWorld Server Animation State Changed Event Handler
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents the method that will handle a StateChanged event.
    /// </summary>
    /// <param name="sender">Represents the object that fired the event.</param>
    /// <param name="newState">The new animation state.</param>
    public delegate void StateChangedEventHandler(object sender, byte newState, bool loop, byte nextState);
}
