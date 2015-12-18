/**
 * RozWorld-API.Container.Inventory -- RozWorld Inventory
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Thing;

namespace RozWorld_API.Container
{
    public abstract class Inventory
    {
        /// <summary>
        /// Gets or sets slot data in this inventory.
        /// </summary>
        protected ItemSlot[] Slot;

        /// <summary>
        /// Gets or sets the maximum quantity of an item per slot in this inventory.
        /// </summary>
        public ushort MaxSlotQuantity;


        /// <summary>
        /// Gets an item slot from this inventory.
        /// </summary>
        /// <param name="slot">The slot number to get.</param>
        /// <returns>The item slot of the specified number, null otherwise.</returns>
        public virtual ItemSlot GetItemSlot(int slot)
        {
            if (slot >= 0 && slot < Slot.Length)
                return Slot[slot];
            else
                return null;
        }


        /// <summary>
        /// Adds an item to this inventory
        /// </summary>
        /// <param name="item">The item to add.</param>
        /// <param name="quantity">The quantity of the item to add.</param>
        /// <param name="carryOver">Whether to carry over the item if the quantity overloads the maximum per slot.</param>
        /// <param name="slot">The slot to attempt to add the item to, an invalid or occupied value will result in the item being added to the first available slot.</param>
        /// <returns>Any leftovers that did not fit inside this inventory as an item stack, or null if successful.</returns>
        public virtual ItemSlot AddItem(Item item, ushort quantity, bool carryOver, int targetSlot = -1)
        {
            // Unfinished (of course)
            return null;
        }


        /// <summary>
        /// Adds an item slot to this inventory.
        /// </summary>
        /// <param name="itemSlot">The item slot to add.</param>
        /// <param name="carryOver">Whether to carry over the item if the quantity overloads the maximum per slot.</param>
        /// <param name="targetSlot">The slot to attempt to add the item slot into, an invalid or occupied value will result in the item being added to the first available slot.</param>
        /// <returns>Any leftovers that did not fit inside this inventory as an item stack, or null if successful.</returns>
        public virtual ItemSlot AddItemSlot(ItemSlot itemSlot, bool carryOver, int targetSlot = -1)
        {
            return AddItem(itemSlot.Contents, itemSlot.Quantity, carryOver, targetSlot);
        }
    }
}
