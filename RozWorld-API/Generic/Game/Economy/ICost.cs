/**
 * Oddmatics.RozWorld.API.Generic.Game.Economy.ICost -- RozWorld Economy Cost
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Generic.Game.Economy
{
    /// <summary>
    /// Represents the cost of an object (usually an item) by an amount of a given currency.
    /// </summary>
    public interface ICost
    {
        /// <summary>
        /// Gets the amount of the given currency required.
        /// </summary>
        uint Amount { get; }

        /// <summary>
        /// Gets the type of ICurrency required in this ICost.
        /// </summary>
        Type Currency { get; }
    }
}
