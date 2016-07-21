/**
 * Oddmatics.RozWorld.API.Server.ICommandCaller -- RozWorld Server Command Caller
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server
{
    /// <summary>
    /// Represents an object that is capable of issuing server commands.
    /// </summary>
    public interface ICommandCaller
    {
        /// <summary>
        /// Gets the display name of this ICommandCaller.
        /// </summary>
        string DisplayName { get; }


        /// <summary>
        /// Gets whether this ICommandCaller has a certain permission.
        /// </summary>
        /// <param name="key">The permission key to check for.</param>
        /// <returns>True if the permission associated with the given key is granted.</returns>
        bool HasPermission(string key);

        /// <summary>
        /// Sends a generic chat message to this ICommandCaller
        /// </summary>
        /// <param name="message">The message to send.</param>
        void SendMessage(string message);
    }
}
