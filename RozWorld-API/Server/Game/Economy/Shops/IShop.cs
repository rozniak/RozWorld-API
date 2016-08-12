/**
 * Oddmatics.RozWorld.API.Server.Game.Economy.Shops.IShop -- RozWorld Server Shop
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Entities;
using Oddmatics.RozWorld.API.Server.Item;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Server.Game.Economy.Shops
{
    /// <summary>
    /// Represents an object that is able to act like a shop
    /// </summary>
    public interface IShop
    {
        /// <summary>
        /// Gets an IList&lt;IShopItem&gt; collection containing all the listed items for sale.
        /// </summary>
        IList<IShopItem> Items { get; }

        /// <summary>
        /// Gets or sets the name of this IShop.
        /// </summary>
        string ShopName { get; set; }


        /// <summary>
        /// Buys an item from this IShop.
        /// </summary>
        /// <param name="buyer">The IInventoryCarrier instance of the buyer.</param>
        /// <param name="itemIndex">The index of the item to purchase.</param>
        /// <returns>True if the item was bought successfully.</returns>
        bool Buy(IInventoryCarrier buyer, int itemIndex);

        /// <summary>
        /// Evaluates whether the specified IItem can be sold at this IShop.
        /// </summary>
        /// <param name="item">The IItem to evaluate.</param>
        /// <returns>True if the specified IItem can be sold at this IShop.</returns>
        bool CanSell(IItem item);

        /// <summary>
        /// Sells an item to this IShop
        /// </summary>
        /// <param name="seller">The IInventoryCarrier instance of the seller.</param>
        /// <param name="item">The IItem being sold.</param>
        /// <param name="quantity">The amount to sell to this IShop.</param>
        /// <returns>True if the item was sold successfully.</returns>
        bool Sell(IInventoryCarrier seller, IItem item, int quantity);
    }
}
