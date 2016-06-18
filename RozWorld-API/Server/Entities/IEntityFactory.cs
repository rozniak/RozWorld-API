/**
 * Oddmatics.RozWorld.API.Server.Entities.IEntityFactory -- RozWorld Entity Factory
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
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
        /// Creates a new Entity instance of the given type.
        /// </summary>
        /// <param name="type">The type name of Entity to create.</param>
        /// <returns>A new instance of the Entity of the given type.</returns>
        Entity CreateEntity(string type);

        /// <summary>
        /// Creates a new Player instance with the given.
        /// This will be an NPC posing as a player once placed into an IWorld.
        /// </summary>
        /// <param name="name">The display name to give this Player.</param>
        /// <returns>A new instance of an NPC Player with the given display name.</returns>
        Player CreatePlayer(string name);

        /// <summary>
        /// Checks whether the specified type of Entity is loaded.
        /// </summary>
        /// <param name="type">The Entity type name.</param>
        /// <returns>Whether or not the Entity of the specified type is loaded.</returns>
        bool IsLoaded(string type);
    }
}
