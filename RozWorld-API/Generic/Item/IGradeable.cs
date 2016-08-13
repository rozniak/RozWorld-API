/**
 * Oddmatics.RozWorld.API.Server.Item.IItem -- RozWorld Gradeable Object
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Item
{
    /// <summary>
    /// Represents a gradeable item.
    /// This is some sub-data for things such as weapons.
    /// (eg. 'Flaming Axe II' - a 'Flaming Axe' weapon of grade 2).
    /// </summary>
    public interface IGradeable
    {
        /// <summary>
        /// Gets the grade of this IGradeable object.
        /// </summary>
        byte Grade { get; }
    }
}
