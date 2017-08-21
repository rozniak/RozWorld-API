/**
 * Oddmatics.RozWorld.API.Generic.Game.Economy.ICurrency -- RozWorld Game Currency
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Game.Economy
{
    /// <summary>
    /// Represents a currency in the game economy.
    /// </summary>
    public interface ICurrency
    {
        /// <summary>
        /// Gets the language string ID for this ICurrency's name.
        /// </summary>
        ushort LidName { get; }

        /// <summary>
        /// Gets the small GUI icon path (relative to texture pack directories) for this ICurrency.
        /// This value is client-side only.
        /// </summary>
        string PathSmallGuiIcon { get; }
    }
}
