/**
 * RozWorld-API.Container.QuickInventory -- RozWorld Player Quick Inventory
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Container
{
    public class QuickInventory : Inventory
    {
        public QuickInventory()
        {
            Slot = new ItemSlot[10];
            MaxSlotQuantity = 99;
        }
    }
}
