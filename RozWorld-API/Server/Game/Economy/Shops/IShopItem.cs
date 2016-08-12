/**
 * Oddmatics.RozWorld.API.Server.Game.Economy.Shops.IShopItem -- RozWorld Server Shop Item
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Game.Economy;
using Oddmatics.RozWorld.API.Generic.Item;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Game.Economy.Shops
{
    /// <summary>
    /// Represents an item listing at a shop.
    /// </summary>
    public interface IShopItem
    {
        /// <summary>
        /// Gets the currency costs of this item listing as an IList&lt;ICost&gt; collection.
        /// </summary>
        IList<ICost> Cost { get; }

        /// <summary>
        /// Gets the IItem being listed.
        /// </summary>
        IItem Item { get; }

        /// <summary>
        /// Gets or sets the quantity of the item listed.
        /// -1 for infinite.
        /// </summary>
        short Quantity { get; set; }
    }
}
