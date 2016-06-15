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

using Oddmatics.RozWorld.API.Server.Game;

namespace Oddmatics.RozWorld.API.Server.Entity
{
    /// <summary>
    /// Represents a living entity in a world.
    /// </summary>
    public interface ILivingEntity : IEntity
    {
        /// <summary>
        /// Gets the ILivingEntityAttributes for this ILivingEntity.
        /// </summary>
        ILivingEntityAttributes Attributes { get; }

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
        /// Gets whether this ILivingEntity is poisoned.
        /// </summary>
        bool IsPoisoned { get; }

        /// <summary>
        /// Gets whether this ILivingEntity is stunned.
        /// </summary>
        bool IsStunned { get; }

        /// <summary>
        /// Gets the SafeStatHandler for this ILivingEntity 
        /// </summary>
        SafeStatHandler Stats { get; }


        /// <summary>
        /// Kills this IEntity.
        /// </summary>
        void Kill();
    }
}
