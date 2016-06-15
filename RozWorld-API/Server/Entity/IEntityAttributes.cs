/**
 * Oddmatics.RozWorld.API.Server.Entity.IEntityAttributes -- RozWorld Entity Attributes
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
    /// Represents attributes for an entity.
    /// </summary>
    public interface IEntityAttributes
    {
        /// <summary>
        /// Gets whether the ILivingEntity is flammable.
        /// </summary>
        bool IsFlammable { get; }
    }
}
