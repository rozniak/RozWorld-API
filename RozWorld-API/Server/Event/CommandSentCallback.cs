/**
 * Oddmatics.RozWorld.API.Server.Event.CommandSentCallback -- RozWorld Server Command Sent Callback
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Accounts;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents the method that will handle the command it was registered to being sent.
    /// </summary>
    /// <param name="sender">The ICommandCaller that sent the command.</param>
    /// <param name="args">The argument passed alongside the command.</param>
    /// <returns>True if the command execution was successful.</returns>
    public delegate bool CommandSentCallback(ICommandCaller sender, IList<string> args);
}
