/**
 * Oddmatics.RozWorld.API.Server.Game.Economy.IEconomySystem -- RozWorld Server Economy System
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Game.Economy;
using Oddmatics.RozWorld.API.Server.Game.Economy.Shops;
using System;

namespace Oddmatics.RozWorld.API.Server.Game.Economy
{
    /// <summary>
    /// Represents the economic system for the game, providing factory methods and registery of economy-related classes.
    /// </summary>
    public interface IEconomySystem
    {
        /// <summary>
        /// Creates a new ICost instance of the default server currency and amount.
        /// </summary>
        /// <param name="amount">The amount of cost.</param>
        /// <returns>A new ICost instance of the default server currency and amount.</returns>
        ICost CreateCost(uint amount);

        /// <summary>
        /// Creates a new ICost instance of the given currency (by name) and amount.
        /// </summary>
        /// <param name="currencyName">The name of the ICurrency's Type to use.</param>
        /// <param name="amount">The amount of cost.</param>
        /// <returns>A new ICost instance of the given ICurrency Type and amount if the name specified is valid, null otherwise.</returns>
        ICost CreateCost(string currencyName, uint amount);

        /// <summary>
        /// Creates a new ICost instance of the given currency (by Type) and amount.
        /// </summary>
        /// <param name="currencyType">The ICurrency's Type to use.</param>
        /// <param name="amount">The amount of cost.</param>
        /// <returns>A new ICost instance of the given ICurrency Type and amount if the Type specified is valid, null otherwise.</returns>
        ICost CreateCost(Type currencyType, uint amount);

        /// <summary>
        /// Creates a generic IShop of the given name.
        /// </summary>
        /// <param name="name">The name to give the IShop.</param>
        /// <returns>A new IShop instance using the given name.</returns>
        IShop CreateShop(string name);

        /// <summary>
        /// Gets a registered ICurrency instance by its Type's name.
        /// </summary>
        /// <param name="currencyName">The name of the ICurrency Type.</param>
        /// <returns>The ICurrency instance of the given Type name if it is registered, null otherwise.</returns>
        bool GetCurrencyByName(string currencyName);

        /// <summary>
        /// Gets a registered ICurrency instance by its Type.
        /// </summary>
        /// <param name="currencyType">The Type of ICurrency.</param>
        /// <returns>The ICurrency instance of the given Type if it is registered, null otherwise.</returns>
        bool GetCurrencyByType(Type currencyType);

        /// <summary>
        /// Registers an ICurrency's Type into this IEconomySystem.
        /// </summary>
        /// <param name="currencyType">The Type of ICurrency.</param>
        /// <returns>True if the Type was registered.</returns>
        bool RegisterCurrencyType(Type currencyType);
    }
}
