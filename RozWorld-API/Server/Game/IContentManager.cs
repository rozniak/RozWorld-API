/**
 * Oddmatics.RozWorld.API.Server.Game.IContentManager -- RozWorld Server Content Manager
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entities;
using System;

namespace Oddmatics.RozWorld.API.Server.Game
{
    /// <summary>
    /// Represents a content manager for accessing factory systems.
    /// </summary>
    public interface IContentManager
    {
        /// <summary>
        /// Gets this IContentManager's IEntityFactory.
        /// </summary>
        IEntityFactory EntityFactory { get; }


        /// <summary>
        /// Registers an Entity Type to this IContentManager.
        /// </summary>
        /// <param name="entityType">The Entity's Type to register.</param>
        /// <returns>True if the Type is not already registered.</returns>
        bool RegisterEntity(Type entityType);

        /// <summary>
        /// Registers an animation state for an Entity.
        /// </summary>
        /// <param name="state">The state to register.</param>
        /// <param name="entityType">The Entity's Type that owns the animation state.</param>
        /// <returns>True if the state has not been registered for the given Entity Type and the Entity Type is also registered.</returns>
        bool RegisterEntityState(byte state, Type entityType);
    }
}
