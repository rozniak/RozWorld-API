/**
 * Oddmatics.RozWorld.API.Server.Entities.IEntityFactory -- RozWorld Entity Factory
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Level;

namespace Oddmatics.RozWorld.API.Server.Entities
{
    /// <summary>
    /// Provides factory methods for creating entities.
    /// </summary>
    public interface IEntityFactory
    {
        /// <summary>
        /// Creates a new chat bot Player instance (bot only shows up in the chat, no instance in an IWorld).
        /// </summary>
        /// <param name="name">The display name to give this chat bot.</param>
        /// <returns>A new instance of Player, as a chat bot.</returns>
        Player CreateChatBotPlayer(string name);

        /// <summary>
        /// Creates a new Entity instance of the given type name.
        /// </summary>
        /// <param name="type">The type name of Entity to create.</param>
        /// <returns>A new instance of the Entity of the given type, null if the type doesn't exist.</returns>
        Entity CreateEntity(string type);

        /// <summary>
        /// Creates a new bot Player instance.
        /// </summary>
        /// <param name="name">The display name to give this Player bot.</param>
        /// <returns>A new instance of Player, controllable as a bot.</returns>
        Player CreateBotPlayer(string name);

        /// <summary>
        /// Checks whether the specified type of Entity is loaded.
        /// </summary>
        /// <param name="type">The Entity type name.</param>
        /// <returns>True if the Entity of the specified type is loaded.</returns>
        bool IsLoaded(string type);
    }
}
