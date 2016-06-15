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

using Oddmatics.RozWorld.API.Generic;
using Oddmatics.RozWorld.API.Generic.Level;

namespace Oddmatics.RozWorld.API.Server.Entity
{
    /// <summary>
    /// Represents an entity that exists in a world.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets the ID of this IEntity.
        /// </summary>
        ushort ID { get; }

        /// <summary>
        /// Gets whether this IEntity can be controlled externally (eg. by IPlugins).
        /// </summary>
        bool IsControllable { get; }

        /// <summary>
        /// Gets whether this IEntity is valid (spawned in an IWorld).
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Gets the location of this IEntity.
        /// </summary>
        Location Location { get; }

        /// <summary>
        /// Gets the permitted update type for this IEntity.
        /// </summary>
        ServerEntityUpdate UpdatePermit { get; }


        /// <summary>
        /// Changes the animation state of this IEntity on clients.
        /// </summary>
        /// <param name="newState">The new animation state.</param>
        void ChangeState(short newState);

        /// <summary>
        /// Sets the Velocity of this IEntity.
        /// </summary>
        /// <param name="velocity">The new Velocity.</param>
        void SetVelocity(Velocity velocity);

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
    }
}
