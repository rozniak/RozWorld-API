/**
 * Oddmatics.RozWorld.API.Server.Entities.IInventoryCarrier -- RozWorld Server Inventory Carrier
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Item;

namespace Oddmatics.RozWorld.API.Server.Entities
{
    /// <summary>
    /// Represents an entity's inventory information.
    /// </summary>
    public interface IInventoryCarrier
    {
        /// <summary>
        /// Gets or sets the IInventory for this IInventoryCarrier.
        /// </summary>
        IInventory Inventory { get; set; }

        /// <summary>
        /// Gets the IItem in this IInventoryCarrier's hand.
        /// </summary>
        IItem ItemInHand { get; }
    }
}
