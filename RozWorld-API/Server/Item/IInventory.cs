

using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Item
{
    public interface IInventory
    {
        short SlotCount { get; }

        IList<IItemSlot> Slots { get; }


    }
}
