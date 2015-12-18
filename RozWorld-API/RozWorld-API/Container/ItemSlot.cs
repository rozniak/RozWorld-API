/**
 * RozWorld-API.Container.ItemSlot -- RozWorld Inventory Item Slot
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
    public abstract class ItemSlot
    {
        /// <summary>
        /// Gets or sets the item in this slot.
        /// </summary>
        public Item Contents;

        /// <summary>
        /// Gets or sets the parent inventory of this item slot.
        /// </summary>
        protected Inventory ParentInventory
        {
            get { return _ParentInventory; }
            set { if (_ParentInventory != null) _ParentInventory = value; }
        }
        private Inventory _ParentInventory;

        /// <summary>
        /// Gets or sets the maximum quantity of an item allowed in this slot.
        /// </summary>
        public ushort MaxQuantity
        {
            get
            {
                // If the item itself does not allow a stack, return 1 regardless of other settings
                if (!Contents.AllowMultiple)
                    return 1;

                if (ParentInventory == null)
                    return _MaxQuantity;
                else
                    return ParentInventory.MaxSlotQuantity;
            }

            set { if (ParentInventory == null) _MaxQuantity = value; }
        }
        private ushort _MaxQuantity;

        /// <summary>
        /// Gets or sets the quantity of the item in this slot.
        /// </summary>
        public ushort Quantity
        {
            get { return _Quantity; }
            set { if (value > MaxQuantity) _Quantity = MaxQuantity; else _Quantity = value; }
        }
        private ushort _Quantity;
    }
}
