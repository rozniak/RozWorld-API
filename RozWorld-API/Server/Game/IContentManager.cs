﻿/**
 * Oddmatics.RozWorld.API.Server.Game.IContentManager -- RozWorld Server Content Manager
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entity;

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
        /// Gets IEntityAttributes associated with an IEntity by its type name.
        /// </summary>
        /// <param name="type">The type name of the IEntity.</param>
        /// <returns>The IEntityAttributes associated with the IEntity specified.</returns>
        IEntityAttributes GetEntityAttributes(string type);
    }
}
