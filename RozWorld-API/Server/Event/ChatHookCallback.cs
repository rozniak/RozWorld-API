/**
 * Oddmatics.RozWorld.API.Server.Event.ChatHookCallback -- RozWorld Server Chat Hook Callback
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
    /// Represents the method that will be called when hooked to ICommandCaller's chat message sending session.
    /// </summary>
    /// <param name="sender">The ICommandCaller that was hooked and sent the message.</param>
    /// <param name="message">The message that was sent.</param>
    /// <returns>True if the hook executed successfully.</returns>
    public delegate bool ChatHookCallback(ICommandCaller sender, string message);
}
