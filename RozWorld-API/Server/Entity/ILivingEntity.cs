/**
 * Oddmatics.RozWorld.API.Server.Entity.ILivingEntity -- RozWorld Living Entity
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Entity
{
    /// <summary>
    /// Represents a living entity in a world.
    /// </summary>
    public interface ILivingEntity : IEntity
    {
        /// <summary>
        /// Gets or sets the experience of this ILivingEntity.
        /// </summary>
        int Experience { get; set; }

        /// <summary>
        /// Gets or sets the health of this ILivingEntity.
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// Gets whether this ILivingEntity is alive.
        /// </summary>
        bool IsAlive { get; }

        /// <summary>
        /// Gets whether this ILivingEntity is burning.
        /// </summary>
        bool IsBurning { get; }

        /// <summary>
        /// Gets whether this ILivingEntity is frozen.
        /// </summary>
        bool IsFrozen { get; }

        /// <summary>
        /// Gets whether this ILivingEntity is stunned.
        /// </summary>
        bool IsStunned { get; }

        /// <summary>
        /// Gets or sets the level of this ILivingEntity.
        /// </summary>
        int Level { get; set; }

        /// <summary>
        /// Gets the maximum health of this ILivingEntity.
        /// </summary>
        int MaxHealth { get; }


        /// <summary>
        /// Kills this IEntity.
        /// </summary>
        void Kill();
    }
}
