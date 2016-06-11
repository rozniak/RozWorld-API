/**
 * Oddmatics.RozWorld.API.Server.Entity.IEntity -- RozWorld Entity
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Level;

namespace Oddmatics.RozWorld.API.Server.Entity
{
    /// <summary>
    /// Represents an entity that exists in a world.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Changes the animation state of this IEntity on clients.
        /// </summary>
        /// <param name="newState">The new animation state.</param>
        void ChangeState(short newState);

        /// <summary>
        /// Teleports this IEntity to a specified target IEntity.
        /// </summary>
        /// <param name="target">The target IEntity to teleport to.</param>
        void TeleportTo(IEntity target);

        /// <summary>
        /// Teleports this IEntity to the specified Location.
        /// </summary>
        /// <param name="target">The target Location to teleport to.</param>
        void TeleportTo(Location target);

        /// <summary>
        /// Teleport this IEntity to the specified coordinates.
        /// </summary>
        /// <param name="segX">The x-coordinate of the target segment.</param>
        /// <param name="segY">The y-coordinate of the target segment.</param>
        /// <param name="segZ">The z-coordinate of the target segment.</param>
        /// <param name="localX">The target local x-coordinate of the segment.</param>
        /// <param name="localY">The target local y-coordinate of the segment.</param>
        void TeleportTo(int segX, int segY, int segZ, int localX, int localY);

        /// <summary>
        /// Gets or sets the health of this IEntity.
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// Gets the maximum health of this IEntity.
        /// </summary>
        int MaxHealth { get; }

        /// <summary>
        /// Kills this IEntity.
        /// </summary>
        void Kill();

        /// <summary>
        /// Gets the location of this IEntity.
        /// </summary>
        Location Location { get; }
    }
}
