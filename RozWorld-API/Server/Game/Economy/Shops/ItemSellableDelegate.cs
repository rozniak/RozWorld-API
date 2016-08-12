/**
 * Oddmatics.RozWorld.API.Generic.Game.Economy.Shops.ItemSellableDelegate -- RozWorld Item Sellable Conditions Delegate
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Item;

namespace Oddmatics.RozWorld.API.Server.Game.Economy.Shops
{
    /// <summary>
    /// Represents the method that will be called by IShop.CanSell() if it has been attached.
    /// </summary>
    /// <param name="shop">The IShop instance that issued the call.</param>
    /// <param name="item">The IItem to evaluate.</param>
    /// <returns>True if the IItem can be sold at the IShop sender.</returns>
    public delegate bool ItemSellableDelegate(IShop shop, IItem item);
}
