/**
 * Oddmatics.RozWorld.API.Server.Entity.ILivingEntityAttributes -- RozWorld Living Entity Attributes
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
    /// Represents attributes for a living entity.
    /// </summary>
    public interface ILivingEntityAttributes : IEntityAttributes
    {
        /// <summary>
        /// Gets whether the ILivingEntity is freezable.
        /// </summary>
        bool IsFreezable { get; }

        /// <summary>
        /// Gets whether the ILivingEntity is poisonable.
        /// </summary>
        bool IsPoisonable { get; }

        /// <summary>
        /// Gets whether the ILivingEntity is stunnable
        /// </summary>
        bool IsStunnable { get; }
    }
}
