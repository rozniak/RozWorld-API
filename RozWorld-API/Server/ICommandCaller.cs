/**
 * Oddmatics.RozWorld.API.Server.ICommandCaller -- RozWorld Server Command Caller
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Event;

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
        /// Gets the chat formatted name of this ICommandCaller.
        /// </summary>
        string FormattedName { get; }


        /// <summary>
        /// Gets whether this ICommandCaller has a certain permission.
        /// </summary>
        /// <param name="key">The permission key to check for.</param>
        /// <returns>True if the permission associated with the given key is granted.</returns>
        bool HasPermission(string key);

        /// <summary>
        /// Makes it so that chat messages sent by this ICommandCaller are passed to the specified delegate rather than the game chat.
        /// </summary>
        /// <param name="callback">The delegate to pass the message to.</param>
        /// <returns>A token used to release the callback hook if the hook was successful, -1 if the hook failed.</returns>
        int HookChatToCallback(ChatHookCallback callback);

        /// <summary>
        /// Releases the active chat hook and allows this ICommandCaller to resume normal chat usage.
        /// 
        /// Note: This function will only operate when called when a hook is in progress.
        /// </summary>
        /// <param name="token">The token to use in order to verify the hook release.</param>
        /// <returns>True if the hook was released.</returns>
        bool ReleaseChatHook(int token);

        /// <summary>
        /// Sends a generic chat message to this ICommandCaller
        /// </summary>
        /// <param name="message">The message to send.</param>
        void SendMessage(string message);
    }
}
