/**
 * Oddmatics.RozWorld.API.Server.Item.IInventory -- RozWorld Inventory
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Item
{
    public interface IInventory
    {
        /// <summary>
        /// Gets the amount of IItemSlots available in this inventory.
        /// </summary>
        short SlotCount { get; }

        /// <summary>
        /// Gets the IItemSlots in this IInventory.
        /// </summary>
        IItemSlot[] Slots { get; }


        /// <summary>
        /// Gets the data for this IInventory for sending to clients.
        /// </summary>
        /// <returns>The data of this IInventory as an IList&lt;byte&gt; collection.</returns>
        IList<byte> GetBytes();
    }
}
