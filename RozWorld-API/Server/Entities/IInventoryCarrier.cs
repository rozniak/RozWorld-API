
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
